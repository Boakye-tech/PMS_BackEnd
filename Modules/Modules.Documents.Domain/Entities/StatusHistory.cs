// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/StatusHistory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:16 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Domain.Entities
{
    public class StatusHistory : BaseEntity
    {
        public ApplicationStatus Status { get; private set; }
        public WorkflowState WorkflowState { get; private set; }
        public string? Notes { get; private set; }
        public DateTime ChangeDate { get; private set; }
        public int FormSubmissionId { get; private set; }

        // Navigation property
        public ApplicationFormSubmission FormSubmission { get; private set; } = null!;

        // Private constructor for EF Core
        private StatusHistory() { }

        public StatusHistory(ApplicationStatus status, WorkflowState workflowState, string? notes, int formSubmissionId)
        {
            Status = status ?? throw new ArgumentNullException(nameof(status));
            WorkflowState = workflowState ?? throw new ArgumentNullException(nameof(workflowState));
            Notes = notes;
            ChangeDate = DateTime.UtcNow;
            FormSubmissionId = formSubmissionId;
        }
    }
}

