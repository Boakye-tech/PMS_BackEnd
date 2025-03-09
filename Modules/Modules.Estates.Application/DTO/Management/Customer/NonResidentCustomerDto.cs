using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
    public record NonResidentCustomerDto
    {
        [StringLength(255)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(12)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string? ContactPerson_EmailAddress { get; set; }

        [StringLength(12)]
        public string? ContactPerson_Address { get; set; }

        public int ContactPerson_IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string? ContactPerson_IdentificationTypeImage { get; set; }
    }
}

