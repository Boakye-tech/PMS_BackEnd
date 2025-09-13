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
using static System.Collections.Specialized.BitVector32;
using Microsoft.Data.SqlClient;

namespace Modules.Documents.Application.UseCases
{
    public class FormTemplateService : IFormTemplateService
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IDropdownDataSourceService _dataSources;

        public FormTemplateService(IUnitOfWork unitofWork, IDropdownDataSourceService dataSources) 
        {
            _unitofWork = unitofWork;
            _dataSources = dataSources;

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

            var dtoList = await Task.WhenAll(templates.Select(t => t.ToDtoAsync(_dataSources)));

            return dtoList.ToList();

            //return templates
            //    .Select(t => t.ToDtoAsync(_dataSources))
            //    .ToList();
        }


        public async Task<List<FormTemplateDto>> GetAllFormTemplatesAsync(int id, int landUseId, int landUseTypeId, string? name)
        {
            var query = _unitofWork.FormTemplates.GetQueryable(includes: new List<string> { "Sections", "Sections.Fields" });


            // Apply filters dynamically
            if (id > 0)
                query = query.Where(t => t.FormTemplateId == id);

            if (landUseId > 0)
                query = query.Where(t => t.LandUseId == landUseId);

            if (landUseTypeId > 0)
                query = query.Where(t => t.LandUseTypeId.Contains(landUseTypeId.ToString()));

            if (!string.IsNullOrWhiteSpace(name))
            {
                var loweredName = name.ToLower();
                query = query.Where(t => t.Name.ToLower().Contains(loweredName));
            }

            var templates = query.ToList();

            var dtoList = await Task.WhenAll(templates.Select(t => t.ToDtoAsync(_dataSources)));


            //return templates
            //    .Select(t => t.ToDto())
            //    .ToList();

            return dtoList.ToList();


        }

        public async Task<List<FormTemplateDto>> GetAllFormTemplatesAsync(string templateName)
        {
            //var result = _moduleComms.GetLocalityList();

            var query = _unitofWork.FormTemplates.GetQueryable(includes: new List<string> { "Sections", "Sections.Fields" });


            // Apply filters dynamically

            //if (landUseId > 0)
            //    query = query.Where(t => t.LandUseId == landUseId);

            //if (landUseTypeId > 0)
            //    query = query.Where(t => t.LandUseTypeId.Contains(landUseTypeId.ToString()));

            var templates = query.ToList();

            var dtoList = await Task.WhenAll(templates.Select(t => t.ToDtoAsync(_dataSources)));

            //return templates
            //    .Select(t => t.ToDtoAsync(_dataSources))
            //    .ToList();

            return dtoList.ToList();
        }

        public async Task<List<FormTemplateDto>> GetAllFormTemplatesAsync(int landUseId, int landUseTypeId)
        {
            var query = _unitofWork.FormTemplates.GetQueryable(includes: new List<string> { "Sections", "Sections.Fields" });

            // Apply filters dynamically

            if (landUseId > 0)
                query = query.Where(t => t.LandUseId == landUseId);

            if (landUseTypeId > 0)
                query = query.Where(t => t.LandUseTypeId.Contains(landUseTypeId.ToString()));

            var templates = query.ToList();

            var dtoList = await Task.WhenAll(templates.Select(t => t.ToDtoAsync(_dataSources)));

            return dtoList.ToList();

        }


        public async Task<ReturnResponsesDto> CreateFormTemplateAsync(CreateFormTemplateDto createDto)
        {
            int templateId = 0;

            try
            {
                // Validate business rules
                if (createDto.LandUseTypeId!.Count == 0)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "The land use type cannot be empty." }
                    };

                }

                if (await IsFormTemplateNameUniqueAsync(createDto.Name))
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"A form template with name '{createDto.Name}' already exists." }
                    };
                }


                string landUseTypeId = string.Join(',', createDto.LandUseTypeId!);

                var template = new FormTemplates(createDto.LandUseId, landUseTypeId, createDto.Name, createDto.Description);
                template.CreatedBy = createDto.CreatedBy;
                template.DateCreated = DateTime.UtcNow;
                _unitofWork.FormTemplates.Insert(template);
                await _unitofWork.Complete();

                templateId = template.FormTemplateId;

                //check if section already exist per template
                foreach (var section in createDto.Sections)
                {
                    if (await IsFormTemplateSectionNameUniqueAsync(section.Name, template.FormTemplateId))
                    {
                        _unitofWork.FormTemplates.Delete(template);
                        await _unitofWork.Complete();
                        return new ReturnResponsesDto
                        {
                            IsSuccess = false,
                            ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"A form template section with name '{section.Name}' already exists." }
                        };
                    }

                }


                // Add sections and their fields
                foreach (var sectionDto in createDto.Sections.OrderBy(s => s.Order))
                {
                    var _section = template.AddSection(sectionDto.Name, sectionDto.Order);
                    _section.CreatedBy = createDto.CreatedBy;
                    _section.DateCreated = DateTime.UtcNow;
                    _unitofWork.FormSections.Insert(_section);
                    await _unitofWork.Complete();

                    // Get the newly added section
                    var newSection = template.Sections.OrderByDescending(s => s.FormSectionId).First();


                    //check if field already exist per section per template
                    foreach (var _field in sectionDto.Fields) //IsFormTemplateSectionFieldNameUniqueAsync
                    {
                        if (await IsFormTemplateSectionFieldNameUniqueAsync(_field.Label, _section.FormSectionId, template.FormTemplateId))
                        {
                            _unitofWork.FormTemplates.Delete(template);
                            _unitofWork.FormSections.Delete(_section);
                            await _unitofWork.Complete();
                            return new ReturnResponsesDto
                            {
                                IsSuccess = false,
                                ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"A form template section with label name '{_field.Label}' already exists." }
                            };
                        }
                    }


                    // Add fields to the section
                    foreach (var fieldDto in sectionDto.Fields.OrderBy(f => f.Order))
                    {
                        var _field = newSection.AddField(
                            fieldDto.Label,
                            fieldDto.FieldType,
                            fieldDto.IsRequired,
                            fieldDto.Options,
                            fieldDto.Order
                        );
                        _field.CreatedBy = createDto.CreatedBy;
                        _field.DateCreated = DateTime.UtcNow;
                        _unitofWork.FormFields.Insert(_field);
                    }
                    await _unitofWork.Complete();
                }

                //template. AddDomainEvent(new FormTemplateCreatedEvent(template));

                //template.CreatedBy = createDto.CreatedBy;
                //template.DateCreated = DateTime.UtcNow;

                _unitofWork.FormTemplates.Update(template);
                await _unitofWork.Complete();


                // Remeber to publish domain events here
                // await _domainEventService.PublishDomainEvents(template);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Form template created successfully." }
                };
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 2601) // 2601 = Cannot insert duplicate key
                {
                    // Find duplicate field (label + section + template)
                    var message = sqlEx.Message;

                    // Extract useful info from the exception
                    var duplicateDetails = ex.InnerException.Message;

                    // Example: delete the conflicting field
                    var response_template = await _unitofWork.FormTemplates.Get(templateId);
                    var response_section = await _unitofWork.FormSections.Get(templateId);

                    _unitofWork.FormTemplates.Delete(response_template!);

                    if(response_section is not null)
                        _unitofWork.FormSections.Delete(response_section!);

                    await _unitofWork.Complete();

                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = $"Duplicate field found. Details: {duplicateDetails}" // and deleted.
                        }
                    };
                }


                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status500InternalServerError,
                        Message = ex.InnerException?.Message ?? ex.Message
                    }
                };

            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }
                };

            }
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
            existingTemplate.UpdateTemplateDetails(updateDto.LandUseId, updateDto.LandUseTypeId!, updateDto.Name, updateDto.Description);

            // Handle section update
            var existingSectionIds = existingTemplate.Sections.Select(f => f.FormSectionId).ToList();
            var updatedSectionIds = updateDto.Sections.Where(f => f.FormSectionId != 0).Select(f => f.FormSectionId).ToList();


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
                if (fieldDto.FormSectionId == 0)
                {
                    existingTemplate.AddSection(fieldDto.Name, fieldDto.Order); //fieldDto.FormSectionId, 


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
                    var existingField = existingTemplate.Sections.FirstOrDefault(f => f.FormSectionId == fieldDto.FormSectionId);
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


        public async Task<bool> IsFormTemplateSectionNameUniqueAsync(string sectionName, int templateId)
        {
            var result = await _unitofWork.FormSections.Get(ft => ft.Name == sectionName && ft.FormTemplateId == templateId );
            return result is null ? false : true;
        }


        public async Task<bool> IsFormTemplateSectionFieldNameUniqueAsync(string fieldName, int sectionId, int templateId)
        {
            var result = await _unitofWork.FormFields.Get(ft => ft.Label == fieldName && ft.FormSectionId == sectionId && ft.FormTemplateId == templateId);
            return result is null ? false : true;
        }

        private FormTemplateDto MapToDto(FormTemplates template)
        {
            return new FormTemplateDto
            {
                FormTemplateId = template.FormTemplateId,
                Name = template.Name,
                Description = template.Description,
                DateCreated = template.DateCreated,
                Sections = template.Sections.OrderBy(s => s.Order).Select(s => new FormSectionDto
                {
                    FormSectionId = s.FormSectionId,
                    Name = s.Name!,
                    Order = s.Order,
                    //FormTemplateId = s.FormTemplateId,
                    Fields = s.Fields.OrderBy(f => f.Order).Select(f => new FormFieldDto
                    {
                        FormFieldId = f.FormFieldId,
                        Label = f.Label,
                        FieldType = f.FieldType,
                        IsRequired = f.IsRequired,
                        Options = null,
                        Order = f.Order,
                        //FormSectionId = f.FormSectionId,
                        //FormTemplateId = f.FormTemplateId
                    }).ToList()
                }).ToList()
            };
        }


    }
}

