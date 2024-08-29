// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Events/FormFieldAddedEvent.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 12:22 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Entities;

namespace Modules.Documents.Domain.Events
{
    public class FormFieldAddedEvent : BaseEvent
    {
        public FormFields FormField { get; }
        public int FormTemplateId { get; }

        public FormFieldAddedEvent(FormFields formField, int formTemplateId)
        {
            FormField = formField;
            FormTemplateId = formTemplateId;
        }
    }
}

