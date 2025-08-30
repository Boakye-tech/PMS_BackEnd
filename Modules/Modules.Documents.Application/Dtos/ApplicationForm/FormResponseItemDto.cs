// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/FormResponseItemDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:10 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;


namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record FormResponseItemDto
    {
        [Required(ErrorMessage = "Form field ID is required")]
        public int FormFieldId { get; init; }

        [Required(ErrorMessage = "Response value is required")]
        public required string ResponseValue { get; init; }
    }
}

