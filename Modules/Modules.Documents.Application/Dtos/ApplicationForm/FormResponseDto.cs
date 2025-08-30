// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/FormResponseDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:01 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record FormResponseDto
    {
        public int FormResponseId { get; init; }
        public int FormFieldId { get; init; }
        public required string ResponseValue { get; init; }
        public int FormSubmissionId { get; init; }
        public FormFieldDto? Field { get; init; }
    }

    
}

