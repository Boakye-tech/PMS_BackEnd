// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/UseCases/FieldTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 10:33 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Application.UseCases
{
    public class FieldTypeService : IFieldTypeService
    {
        public IEnumerable<FieldType> GetAllFieldTypes()
        {
            return FieldType.GetAll();
        }
    }
}

