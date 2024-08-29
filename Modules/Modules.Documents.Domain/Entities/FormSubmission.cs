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
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Enums;

namespace Modules.Documents.Domain.Entities
{
    public class FormSubmission : BaseEntity
    {
        public int FormTemplateId { get; private set; }
        public string ApplicantName { get; private set; }
        public string ApplicantEmail { get; private set; }
        public ApplicationSubmissionStatusEnum Status { get; private set; } // Draft, Submitted, UnderReview, Approved, Rejected
        public DateTime SubmittedDate { get; private set; }
        public DateTime CreatedDate { get; private set; }

        // Navigation properties
        public FormTemplates FormTemplate { get; private set; } = null!;
        private readonly List<FormResponse> _responses = new();
        public IReadOnlyCollection<FormResponse> Responses => _responses.AsReadOnly();

        // Private constructor for EF Core
        private FormSubmission() { }

        public FormSubmission(int formTemplateId, string applicantName, string applicantEmail)
        {
            FormTemplateId = formTemplateId;
            ApplicantName = applicantName ?? throw new ArgumentNullException(nameof(applicantName));
            ApplicantEmail = applicantEmail ?? throw new ArgumentNullException(nameof(applicantEmail));
            Status = ApplicationSubmissionStatusEnum.Draft;
            CreatedDate = DateTime.UtcNow;
        }

        // Domain methods
        public void AddResponse(int formFieldId, string responseValue)
        {
            var existingResponse = _responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
            if (existingResponse != null)
            {
                existingResponse.UpdateResponse(responseValue);
            }
            else
            {
                var response = new FormResponse(formFieldId, responseValue, Id);
                _responses.Add(response);
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
            var respondedFieldIds = _responses.Select(r => r.FormFieldId).ToList();

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

        //public void UpdateStatus(string status)
        //{
        //    if (!new[] { "UnderReview", "Approved", "Rejected" }.Contains(status))
        //    {
        //        throw new InvalidOperationException("Invalid status value.");
        //    }

        //    Status = status;
        //}

        public FormResponse? GetResponseForField(int formFieldId)
        {
            return _responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
        }
    }
}

