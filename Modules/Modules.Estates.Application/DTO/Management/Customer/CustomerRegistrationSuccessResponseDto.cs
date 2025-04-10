using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
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

