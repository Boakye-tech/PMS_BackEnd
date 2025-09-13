// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/UseCases/FormSubmissionService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:19 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.ApplicationForm;
using Modules.Documents.Application.Dtos.FormTemplates;
using Modules.Documents.Domain.Entities;
using Modules.Documents.Domain.Enums;
using Modules.Documents.Domain.Interfaces;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Application.UseCases
{
	public class FormSubmissionService : IFormSubmissionService
    {
        private readonly IUnitOfWork _unitofWork;

        public FormSubmissionService(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<FormSubmissionDto> GetSubmissionByIdAsync(int id)
        {
            var submission = await _unitofWork.ApplicationSubmissionForms.Get(id);  
            if (submission == null)
            {
                throw new KeyNotFoundException($"Form submission with ID {id} not found.");
            }

            return MapToDto(submission);
        }

        public async Task<List<FormSubmissionDto>> GetSubmissionsByTemplateAsync(int templateId)
        {
            var submissions = await _unitofWork.ApplicationSubmissionForms.GetAll(s => s.FormTemplateId == templateId);
            return submissions.Select(MapToDto).ToList();
        }

        public async Task<List<FormSubmissionDto>> GetSubmissionsByApplicantAsync(string email)
        {
            var submissions = await _unitofWork.ApplicationSubmissionForms.GetAll(s => s.ApplicantEmail == email);
            return submissions.Select(MapToDto).ToList();
        }

        public async Task<ReturnResponsesDto> CreateSubmissionAsync(CreateFormSubmissionDto createDto)
        {
            // Validate template exists
            var template = await _unitofWork.FormTemplates.Get(ft => ft.FormTemplateId == createDto.FormTemplateId) ;
            if (template == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"Form template with ID {createDto.FormTemplateId} not found." }
                };
            }

            var submission = new ApplicationFormSubmission(
                createDto.FormTemplateId,
                createDto.ApplicantName,
                createDto.ApplicantEmail,
                createDto.PropertyNumber
            );

            // Add responses
            foreach (var responseDto in createDto.Responses)
            {
                submission.AddResponse(responseDto.FormFieldId, responseDto.ResponseValue);
            }

            _unitofWork.ApplicationSubmissionForms.Insert(submission);
            await _unitofWork.Complete();


            var generatedId = submission.FormSubmissionId;
            //return MapToDto(createdSubmission);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = $"Draft application form submitted successfully. Application ID: {generatedId}" }
            };

        }

        public async Task<ReturnResponsesDto> UpdateSubmissionAsync(int id, UpdateFormSubmissionDto updateDto)
        {
            var submission = await GetSubmissionWithDetails(id);

            if (submission.Status != ApplicationStatus.Draft)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Only draft submissions can be updated." }
                };
            }

            // Update responses
            foreach (var responseDto in updateDto.Responses)
            {
                submission.AddResponse(responseDto.FormFieldId, responseDto.ResponseValue);
            }

            _unitofWork.ApplicationSubmissionForms.Update(submission);
            await _unitofWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Draft application form updated successfully." }
            };
        }

        public async Task<ReturnResponsesDto> SubmitSubmissionAsync(int id)
        {
            var submission = await GetSubmissionWithDetails(id);

            submission.Submit();

            _unitofWork.ApplicationSubmissionForms.Update(submission);
            await _unitofWork.Complete() ;

            // Remember the implementation, publish domain events here
            // await _domainEventService.PublishDomainEvents(submission);

            //return MapToDto(submission);
            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Application form submission updated successfully." }
            };

        }

        public async Task<ReturnResponsesDto> UpdateSubmissionStatusAsync(UpdateFormSubmissionStatusDto values)
        {
            var submission = await _unitofWork.ApplicationSubmissionForms.Get(s => s.FormSubmissionId == values.FormSubmissionId && s.Status == values.Status);
            if (submission == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = $"Form submission with ID {values.FormSubmissionId} not found." }
                };
            }

            //submission.UpdateStatus(status);

            _unitofWork.ApplicationSubmissionForms.Update(submission);
            await _unitofWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Application form submission status updated successfully." }
            };
        }

        public async Task DeleteSubmissionAsync(int id)
        {
            var submission = await _unitofWork.ApplicationSubmissionForms.Get(id);
            if (submission == null)
            {
                throw new KeyNotFoundException($"Form submission with ID {id} not found.");
            }

            _unitofWork.ApplicationSubmissionForms.Delete(submission);
            await _unitofWork.Complete();
        }

        public async Task<SubmissionSummaryDto> GetSubmissionSummaryAsync()
        {
            var allSubmissions = await _unitofWork.ApplicationSubmissionForms.GetAll();

            return new SubmissionSummaryDto
            {
                TotalSubmissions = allSubmissions.Count,
                DraftSubmissions = allSubmissions.Count(s => s.Status == ApplicationStatus.Draft),
                SubmittedSubmissions = allSubmissions.Count(s => s.Status == ApplicationStatus.Submitted),
                ApprovedSubmissions = allSubmissions.Count(s => s.Status == ApplicationStatus.ProposalAccepted),
                RejectedSubmissions = allSubmissions.Count(s => s.Status == ApplicationStatus.ProposalRejected)
            };
        }

        private async Task<ApplicationFormSubmission> GetSubmissionWithDetails(int id)
        {
            var submission = await _unitofWork.ApplicationSubmissionForms.Get(id);
            if (submission == null)
            {
                throw new KeyNotFoundException($"Form submission with ID {id} not found.");
            }
            //return MapToDto(submission!);

            return submission;
        }

        private FormSubmissionDto MapToDto(ApplicationFormSubmission submission)
        {
            return new FormSubmissionDto
            {
                FormSubmissionId = submission.Id,
                FormTemplateId = submission.FormTemplateId,
                ApplicantName = submission.ApplicantName,
                ApplicantEmail = submission.ApplicantEmail,
                PropertyNumber = submission.PropertyNumber,
                Status = submission.Status,
                WorkflowState = submission.WorkflowState,
                SubmittedDate = submission.SubmittedDate,
                CreatedDate = submission.CreatedDate,
                Responses = submission.Responses.Select(r => new FormResponseDto
                {
                    FormResponseId = r.Id,
                    FormFieldId = r.FormFieldId,
                    ResponseValue = r.ResponseValue,
                    FormSubmissionId = r.FormSubmissionId,
                    Field = r.FormField != null ? new FormFieldDto
                    {
                        FormFieldId = r.FormField.FormFieldId,
                        Label = r.FormField.Label,
                        FieldType = r.FormField.FieldType,
                        IsRequired = r.FormField.IsRequired,
                        Options = null, //r.FormField.Options,
                        Order = r.FormField.Order
                        //FormTemplateId = r.FormField.FormTemplateId
                    } : null
                }).ToList(),
                Template = submission.FormTemplate != null ? new FormTemplateDto
                {
                    FormTemplateId = submission.FormTemplate.FormTemplateId,
                    Name = submission.FormTemplate.Name,
                    Description = submission.FormTemplate.Description,
                    DateCreated = submission.FormTemplate.DateCreated
                } : null
            };
        }
    }
}

