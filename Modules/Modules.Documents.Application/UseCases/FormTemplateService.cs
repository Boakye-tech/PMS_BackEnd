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
using Microsoft.EntityFrameworkCore;

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
            var templates = await _unitofWork.FormTemplates.GetAll(includes: new List<string> { "Sections" });

            return templates
                .Select(t => t.ToDto())
                .ToList();
        }


        public List<FormTemplateDto> GetAllFormTemplatesAsync(int id, int landUseId, int landUseTypeId, string? name)
        {
            var query = _unitofWork.FormTemplates.GetQueryable(includes: new List<string> { "Sections", "Sections.Fields" });

            //var query = _unitofWork.FormTemplates.GetQueryable();

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


            //// Force eager load
            //var templates = query
            //    .Include(t => t.Sections)
            //        .ThenInclude(s => s.Fields)
            //    .ToList();

            //// Map to DTO
            //return templates.Select(MapToDto).ToList();

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

            var template = new FormTemplates(0, createDto.LandUseId, createDto.LandUseTypeId.FirstOrDefault(), createDto.Name, createDto.Description);


            // Add sections and their fields
            foreach (var sectionDto in createDto.Sections.OrderBy(s => s.Order))
            {
                template.AddSection(0, sectionDto.Name , sectionDto.Order);

                // Get the newly added section
                var newSection = template.Sections.OrderByDescending(s => s.FormSectionId).First();

                // Add fields to the section
                foreach (var fieldDto in sectionDto.Fields.OrderBy(f => f.Order))
                {
                    newSection.AddField(
                        0,
                        fieldDto.Label,
                        fieldDto.FieldType,
                        fieldDto.IsRequired,
                        fieldDto.Options,
                        fieldDto.Order
                    );
                }
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
            existingTemplate.UpdateTemplateDetails(updateDto.LandUseId, updateDto.LandUseTypeId, updateDto.Name, updateDto.Description);

            // Handle section update
            var existingSectionIds = existingTemplate.Sections.Select(f => f.FormSectionId).ToList();
            var updatedSectionIds = updateDto.Sections.Where(f => f.Id != 0).Select(f => f.Id).ToList();


            //// Handle field update
            //var existingFieldIds = existingTemplate.Fiel.Select(f => f.FormSectionId).ToList();
            //var updatedFieldIds = updateDto.Sections.Where(f => f.Id != 0).Select(f => f.Id).ToList();


            // Remove sections that are not in the update
            var fieldsToRemove = existingTemplate.Sections
                .Where(f => !updatedSectionIds.Contains(f.FormSectionId))
                .ToList();

            foreach (var field in fieldsToRemove)
            {
                existingTemplate.RemoveSection(field.FormSectionId);
            }

            // Update existing fields and add new ones
            foreach (var fieldDto in updateDto.Sections)
            {
                if (fieldDto.Id == 0)
                {
                    existingTemplate.AddSection(fieldDto.Id, fieldDto.Name, fieldDto.Order);


                    //// New field
                    //existingTemplate.AddField(
                    //    fieldDto.Id,
                    //    fieldDto.Label,
                    //    fieldDto.FieldType,
                    //    fieldDto.IsRequired,
                    //    fieldDto.Options,
                    //    fieldDto.Order
                    //);
                }
                else
                {
                    // Existing field
                    var existingField = existingTemplate.Sections.FirstOrDefault(f => f.FormSectionId == fieldDto.Id);
                    if (existingField != null)
                    {
                        existingField.UpdateDetails(
                            fieldDto.Name,
                            fieldDto.Order
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
                Sections = template.Sections.OrderBy(s => s.Order).Select(s => new FormSectionDto
                {
                    Id = s.FormSectionId,
                    Name = s.Name,
                    Order = s.Order,
                    FormTemplateId = s.FormTemplateId,
                    Fields = s.Fields.OrderBy(f => f.Order).Select(f => new FormFieldDto
                    {
                        Id = f.FormFieldId,
                        Label = f.Label,
                        FieldType = f.FieldType,
                        IsRequired = f.IsRequired,
                        Options = f.Options,
                        Order = f.Order,
                        FormSectionId = f.FormSectionId,
                        FormTemplateId = f.FormTemplateId
                    }).ToList()
                }).ToList()
            };
        }


    }
}

