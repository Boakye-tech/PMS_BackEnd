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
using Modules.Documents.Domain.ValueObjects;

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
        public ApplicationStatus Status { get; private set; }
        public WorkflowState WorkflowState { get; private set; }
        public DateTime SubmittedDate { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastStatusChangeDate { get; private set; }
        public string? StatusNotes { get; private set; }
        // Navigation properties
        public FormTemplates FormTemplate { get; private set; } = null!;

        //Navigation property for Submission Form responses
        public ICollection<ApplicationFormResponse> Responses { get; set; } = new List<ApplicationFormResponse>();

        public ICollection<StatusHistory> StatusHistory { get; set; } = new List<StatusHistory>();


        // Private constructor for EF Core
        private ApplicationFormSubmission() { }

        public ApplicationFormSubmission(int formTemplateId, string applicantName, string applicantEmail, string propertyNumber)
        {
            //FormSubmissionId = formSubmissionId;
            FormTemplateId = formTemplateId;
            ApplicantName = applicantName ?? throw new ArgumentNullException(nameof(applicantName));
            ApplicantEmail = applicantEmail ?? throw new ArgumentNullException(nameof(applicantEmail));
            PropertyNumber = propertyNumber;
            Status = ApplicationStatus.Draft;
            WorkflowState = WorkflowState.ApplicationReceived;
            CreatedDate = DateTime.UtcNow;
            LastStatusChangeDate = DateTime.UtcNow;

            // Record initial status
            StatusHistory.Add(new StatusHistory(ApplicationStatus.Draft, WorkflowState.ApplicationReceived, "Submission created", Id));
        }

        // Domain methods
        public void AddResponse(int formFieldId, string responseValue)
        {
            if (Status != ApplicationStatus.Draft)
            {
                throw new InvalidOperationException("Responses can only be added to draft submissions.");
            }

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
            if (Status != ApplicationStatus.Draft)
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

            Status = ApplicationStatus.Submitted;
            SubmittedDate = DateTime.UtcNow;

            //AddDomainEvent(new FormSubmissionSubmittedEvent(this));
        }

        public void UpdateStatus(ApplicationStatus status, WorkflowState workflowState, string? notes = null)
        {
            // Business rules for status transitions
            ValidateStatusTransition(status, workflowState);

            var previousStatus = Status;
            var previousWorkflowState = WorkflowState;

            Status = status;
            WorkflowState = workflowState;
            StatusNotes = notes;
            LastStatusChangeDate = DateTime.UtcNow;

            // Record status history
            StatusHistory.Add(new StatusHistory(status, workflowState, notes, Id));

            //AddDomainEvent(new FormSubmissionStatusChangedEvent(this, previousStatus, previousWorkflowState));
        }

        public void MarkUnderReview(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.UnderReview, WorkflowState.ApplicationReceived, notes ?? "Application is under review");
        }

        public void SendProposal(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.ProposalSent, WorkflowState.AwaitingCustomerResponse, notes ?? "Proposal sent to customer");
        }

        public void AcceptProposal(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.ProposalAccepted, WorkflowState.AcceptanceProcessing, notes ?? "Proposal accepted by customer");
        }

        public void RejectProposal(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.ProposalRejected, WorkflowState.Completed, notes ?? "Proposal rejected by customer");
        }

        public void GenerateOffer(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.OfferGenerated, WorkflowState.DocumentGeneration, notes ?? "Offer document generated");
        }

        public void Complete(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.Completed, WorkflowState.Completed, notes ?? "Application process completed");
        }

        public void Cancel(string? notes = null)
        {
            UpdateStatus(ApplicationStatus.Cancelled, WorkflowState.Completed, notes ?? "Application cancelled");
        }

        private void ValidateStatusTransition(ApplicationStatus newStatus, WorkflowState newWorkflowState)
        {
            // Implement business rules for valid status transitions
            var validTransitions = new Dictionary<ApplicationStatus, ApplicationStatus[]>
            {
                [ApplicationStatus.Draft] = new[] { ApplicationStatus.Submitted },
                [ApplicationStatus.Submitted] = new[] { ApplicationStatus.UnderReview, ApplicationStatus.Cancelled },
                [ApplicationStatus.UnderReview] = new[] { ApplicationStatus.ProposalSent, ApplicationStatus.Cancelled },
                [ApplicationStatus.ProposalSent] = new[] { ApplicationStatus.ProposalAccepted, ApplicationStatus.ProposalRejected, ApplicationStatus.Cancelled },
                [ApplicationStatus.ProposalAccepted] = new[] { ApplicationStatus.OfferGenerated, ApplicationStatus.Cancelled },
                [ApplicationStatus.ProposalRejected] = new[] { ApplicationStatus.Completed },
                [ApplicationStatus.OfferGenerated] = new[] { ApplicationStatus.Completed, ApplicationStatus.Cancelled },
                [ApplicationStatus.Completed] = new ApplicationStatus[] { },
                [ApplicationStatus.Cancelled] = new ApplicationStatus[] { }
            };

            if (validTransitions.ContainsKey(Status) &&
                !validTransitions[Status].Contains(newStatus))
            {
                throw new InvalidOperationException(
                    $"Invalid status transition from {Status} to {newStatus}");
            }
        }

        //public FormResponse? GetResponseForField(int formFieldId)
        //{
        //    return _responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
        //}

        //public StatusHistory? GetLatestStatusHistory()
        //{
        //    return _statusHistory.OrderByDescending(sh => sh.ChangeDate).FirstOrDefault();
        //}


        public ApplicationFormResponse? GetResponseForField(int formFieldId)
        {
            return Responses.FirstOrDefault(r => r.FormFieldId == formFieldId);
        }
    }
}

