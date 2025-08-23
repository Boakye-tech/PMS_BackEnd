// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyMasterViewDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/08/2025 12:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
using Modules.Estates.Domain.Entities.Registration.ViewModels;

namespace Modules.Estates.Application.DTO.Management.Property
{
    public class PropertyMasterViewDto : PropertyMasterView
    {
        public PropertyLeaseDetailsReadDto? LeaseDetails { get; set; }

    }
}

