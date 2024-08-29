// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Events/FormTemplateCreatedEvent.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 12:21 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Entities;

namespace Modules.Documents.Domain.Events
{
    public class FormTemplateCreatedEvent : BaseEvent
    {
        public FormTemplates FormTemplate { get; }

        public FormTemplateCreatedEvent(FormTemplates formTemplate)
        {
            FormTemplate = formTemplate;
        }
    }
}

