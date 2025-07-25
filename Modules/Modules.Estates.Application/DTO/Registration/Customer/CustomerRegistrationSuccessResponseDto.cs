// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Customer/CustomerRegistrationSuccessResponseDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Registration.Customer
{
    public class CustomerRegistrationSuccessResponseDto
    {
        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(255)]
        public string? FullName { get; set; }

        [StringLength(15)]
        public string? PhoneNumber { get; set; }

    }
}

