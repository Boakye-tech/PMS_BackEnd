// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/FormSubmission.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 2:23 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Enums;

namespace Modules.Documents.Domain.Entities
{
    public class ApplicationFormSubmission : BaseEntity
    {
        [Key]
        public int FormSubmissionId { get; private  set; }

        [Required]
        public int FormTemplateId { get; private set; }

        [Required]
        public string ApplicantName { get; private set; }

        [Required]
        [EmailAddress]
        public string ApplicantEmail { get; private set; }

        [Required]
        public string PropertyNumber { get; private set; }
        public ApplicationSubmissionStatusEnum Status { get; private set; } // Draft, Submitted, UnderReview, Approved, Rejected
        public DateTime SubmittedDate { get; private set; }
        public DateTime CreatedDate { get; private set; }

        // Navigation properties
        public FormTemplates FormTemplate { get; private set; } = null!;

        //Navigation property for Submission Form responses
        public ICollection<ApplicationFormResponse> Responses { get; set; } = new List<ApplicationFormResponse>();

        // Private constructor for EF Core
        private ApplicationFormSubmission() { }

        public ApplicationFormSubmission(int formTemplateId, string applicantName, string applicantEmail, string propertyNumber)
        {
            //FormSubmissionId = formSubmissionId;
            FormTemplateId = formTemplateId;
            ApplicantName = applicantName ?? throw new ArgumentNullException(nameof(applicantName));
            ApplicantEmail = applicantEmail ?? throw new ArgumentNullException(nameof(applicantEmail));
            PropertyNumber = propertyNumber;
            Status = ApplicationSubmissionStatusEnum.Draft;
            CreatedDate = DateTime.UtcNow;
        }

        // Domain methods
        public void AddResponse(int formFieldId, string responseValue)
        {
            var existingResponse = Responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
            if (existingResponse != null)
            {
                existingResponse.UpdateResponse(responseValue);
            }
            else
            {
                var response = new ApplicationFormResponse(formFieldId, responseValue, FormSubmissionId, FormTemplateId);
                Responses.Add(response);
            }
        }

        public void Submit()
        {
            if (Status != ApplicationSubmissionStatusEnum.Draft)
            {
                throw new InvalidOperationException("Only draft submissions can be submitted.");
            }

            // Validate that all required fields have responses
            var requiredFields = FormTemplate.Fields.Where(f => f.IsRequired).ToList();
            var respondedFieldIds = Responses.Select(r => r.FormFieldId).ToList();

            var missingRequiredFields = requiredFields
                .Where(f => !respondedFieldIds.Contains(f.FormFieldId))
                .ToList();

            if (missingRequiredFields.Any())
            {
                var missingFieldNames = string.Join(", ", missingRequiredFields.Select(f => f.Label));
                throw new InvalidOperationException($"Missing responses for required fields: {missingFieldNames}");
            }

            Status = ApplicationSubmissionStatusEnum.Submitted;
            SubmittedDate = DateTime.UtcNow;

            //AddDomainEvent(new FormSubmissionSubmittedEvent(this));
        }


        public ApplicationFormResponse? GetResponseForField(int formFieldId)
        {
            return Responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
        }
    }
}

