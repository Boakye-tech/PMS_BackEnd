// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/StopDebitRequestDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 11:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management
{
    public record StopDebitRequestDto
    {
        //[Key]
        //public int StopDebitId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [StringLength(255)]
        public string? Reasons { get; set; }

        //public int DebtorStatus { get; set; }

        [StringLength(36)]
        public string? CreatedBy { get; set; }
    }
}

