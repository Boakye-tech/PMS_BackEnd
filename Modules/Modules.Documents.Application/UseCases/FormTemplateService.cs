// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/UseCases/FormTemplateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:29 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.FormTemplates;
using Modules.Documents.Application.Interfaces;
using Modules.Documents.Application.Extensions;
using Modules.Documents.Domain.Entities;
using Modules.Documents.Domain.Events;
using Modules.Documents.Domain.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Modules.Documents.Application.UseCases
{
    public class FormTemplateService : IFormTemplateService
    {
        private readonly IUnitOfWork _unitofWork;

        public FormTemplateService(IUnitOfWork unitofWork) 
        {
            _unitofWork = unitofWork;
        }

        //public async Task<FormTemplateDto> GetFormTemplateByIdAsync(int id)
        //{
        //    var template = await _unitofWork.FormTemplates.Get(id);

        //    if (template == null)
        //    {
        //        throw new KeyNotFoundException($"Form template with ID {id} not found.");
        //    }


        //    return MapToDto(template);
        //}

        public async Task<List<FormTemplateDto>> GetAllFormTemplatesAsync()
        {
            var templates = await _unitofWork.FormTemplates.GetAll(includes: new List<string> { "Fields" });

            return templates
                .Select(t => t.ToDto())
                .ToList();
        }


        public List<FormTemplateDto> GetAllFormTemplatesAsync(int id, int landUseId, int landUseTypeId, string? name)
        {
            var query = _unitofWork.FormTemplates.GetQueryable(includes: new List<string> { "Fields" });


            // Apply filters dynamically
            if (id > 0)
                query = query.Where(t => t.FormTemplateId == id);

            if (landUseId > 0)
                query = query.Where(t => t.LandUseId == landUseId);

            if (landUseTypeId > 0)
                query = query.Where(t => t.LandUseTypeId == landUseTypeId);

            if (!string.IsNullOrWhiteSpace(name))
            {
                var loweredName = name.ToLower();
                query = query.Where(t => t.Name.ToLower().Contains(loweredName));
            }

            var templates = query.ToList();

            return templates
                .Select(t => t.ToDto())
                .ToList();
        }


        public async Task<ReturnResponsesDto> CreateFormTemplateAsync(CreateFormTemplateDto createDto)
        {
            // Validate business rules
            if (await IsFormTemplateNameUniqueAsync(createDto.Name))
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"A form template with name '{createDto.Name}' already exists." }
                };
            }

            var template = new FormTemplates(0, createDto.Name, createDto.Description);

            // Add fields
            foreach (var fieldDto in createDto.Fields.OrderBy(f => f.Order))
            {
                template.AddField(
                    0,
                    fieldDto.Label,
                    fieldDto.FieldType,
                    fieldDto.IsRequired,
                    fieldDto.Options,
                    fieldDto.Order
                );
            }

            //template. AddDomainEvent(new FormTemplateCreatedEvent(template));

            template.CreatedBy = createDto.CreatedBy;
            template.DateCreated = DateTime.UtcNow;
            
            _unitofWork.FormTemplates.Insert(template);
            await _unitofWork.Complete();


            // Remeber to publish domain events here
            // await _domainEventService.PublishDomainEvents(template);


            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Form template created successfully." }
            };
        }

        public async Task<ReturnResponsesDto> UpdateFormTemplateAsync(int id, UpdateFormTemplateDto updateDto)
        {
            var existingTemplate = await _unitofWork.FormTemplates.Get(id);
            if (existingTemplate == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"Form template with ID {id} not found." }
                };

            }

            if (!string.Equals(existingTemplate.Name, updateDto.Name, StringComparison.OrdinalIgnoreCase))
            {
                // Check name uniqueness (excluding current template)
                if (await IsFormTemplateNameUniqueAsync(updateDto.Name, id))
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"A form template with name '{updateDto.Name}' already exists." }
                    };
                }
            }

            // Update template properties
            existingTemplate.UpdateDetails(updateDto.Name, updateDto.Description);

            // Handle fields update
            var existingFieldIds = existingTemplate.Fields.Select(f => f.FormFieldId).ToList();
            var updatedFieldIds = updateDto.Fields.Where(f => f.Id != 0).Select(f => f.Id).ToList();

            // Remove fields that are not in the update
            var fieldsToRemove = existingTemplate.Fields
                .Where(f => !updatedFieldIds.Contains(f.FormFieldId))
                .ToList();

            foreach (var field in fieldsToRemove)
            {
                existingTemplate.RemoveField(field.FormFieldId);
            }

            // Update existing fields and add new ones
            foreach (var fieldDto in updateDto.Fields)
            {
                if (fieldDto.Id == 0)
                {
                    // New field
                    existingTemplate.AddField(
                        fieldDto.Id,
                        fieldDto.Label,
                        fieldDto.FieldType,
                        fieldDto.IsRequired,
                        fieldDto.Options,
                        fieldDto.Order
                    );
                }
                else
                {
                    // Existing field
                    var existingField = existingTemplate.Fields.FirstOrDefault(f => f.FormFieldId == fieldDto.Id);
                    if (existingField != null)
                    {
                        existingField.UpdateDetails(
                            fieldDto.Label,
                            fieldDto.FieldType,
                            fieldDto.IsRequired,
                            fieldDto.Options
                        );
                        existingField.UpdateOrder(fieldDto.Order);
                    }
                }
            }

            existingTemplate.CreatedBy = updateDto.modifiedBy;
            existingTemplate.DateModified = DateTime.UtcNow;

            _unitofWork.FormTemplates.Update(existingTemplate);
            await _unitofWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Form template updated successfully." }
            };

        }

        public async Task<ReturnResponsesDto> DeleteFormTemplateAsync(int id)
        {
            var template = await _unitofWork.FormTemplates.Get(id );
            if (template == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"Form template with ID {id} not found." }
                };
            }

            _unitofWork.FormTemplates.Delete(template);
            await _unitofWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Form template with ID {id} deleted successfully." }
            };
        }

        public async Task<bool> IsFormTemplateNameUniqueAsync(string name, int? excludeId = null)
        {
           var result = await _unitofWork.FormTemplates.Get(ft => ft.Name == name);
           return result is null ? false : true;
        }


        private FormTemplateDto MapToDto(FormTemplates template)
        {
            return new FormTemplateDto
            {
                Id = template.FormTemplateId,
                Name = template.Name,
                Description = template.Description,
                DateCreated = template.DateCreated,
                Fields = template.Fields.Select(f => new FormFieldDto
                {
                    Id = f.FormFieldId,
                    Label = f.Label,
                    FieldType = f.FieldType,
                    IsRequired = f.IsRequired,
                    Options = f.Options,
                    Order = f.Order,
                    FormTemplateId = f.FormTemplateId
                }).ToList()
            };
        }


    }
}

