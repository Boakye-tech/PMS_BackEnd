// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/FormResponse.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 2:28 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.Common;

namespace Modules.Documents.Domain.Entities
{
    public class FormResponse : BaseEntity
    {
        public int FormFieldId { get; private set; }
        public string ResponseValue { get; private set; }
        public int FormSubmissionId { get; private set; }

        // Navigation properties
        public FormFields FormField { get; private set; } = null!;
        public FormSubmission FormSubmission { get; private set; } = null!;

        // Private constructor for EF Core
        private FormResponse() { }

        public FormResponse(int formFieldId, string responseValue, int formSubmissionId)
        {
            FormFieldId = formFieldId;
            ResponseValue = responseValue ?? throw new ArgumentNullException(nameof(responseValue));
            FormSubmissionId = formSubmissionId;
        }

        // Domain methods
        public void UpdateResponse(string responseValue)
        {
            ResponseValue = responseValue ?? throw new ArgumentNullException(nameof(responseValue));
        }
    }
}

