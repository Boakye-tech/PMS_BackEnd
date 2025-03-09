using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record CustomerListDto
	{
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [StringLength(300)]
        public string? FullName { get; set; }

        public string? Locality { get; set; }
       
        [StringLength(12)]
        public string? PrimaryMobileNumber { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        public string? DebtorStatus { get; set; }

    }

    

}

