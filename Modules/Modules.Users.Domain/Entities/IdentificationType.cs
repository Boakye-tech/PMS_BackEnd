using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Modules.Users.Domain.Entities
{
    [Keyless]
	public class IdentificationType
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdentificationTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public string? IdentificationTypes { get; set; }

        public IdentificationType(int identificationTypeId, string identificationTypes)
        {
            IdentificationTypeId = identificationTypeId;
            IdentificationTypes = identificationTypes;
        }

        public static IdentificationType InsertUpdate(int identificationTypeId, string identificationTypes)
        {
            if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypeId <= 0)
            {
                throw new ArgumentException("Invalid Identification Type Data.");
            }

            if (identificationTypeId < 0)
                throw new ArgumentException("Identification Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypes.Length > 20)
                throw new ArgumentException("Identification Type must not be null or exceed 20 characters.");

            return new IdentificationType(identificationTypeId, identificationTypes);
        }

    }
}

