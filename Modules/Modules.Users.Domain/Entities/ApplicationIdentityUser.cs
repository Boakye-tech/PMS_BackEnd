
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Domain.Entities
{
	public class ApplicationIdentityUser : IdentityUser
	{
        [StringLength(10)]
        public string? IdentificationNumber { get; set; }

        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? MiddleName { get; set; }

        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(256)]
        public string? PartnerName { get; set; }

        public int DepartmentId { get; set; }

        public int UnitId { get; set; }

        [StringLength(256)]
        public string? ProfilePicture { get; set; }

        [StringLength(50)]
        public string? LastReceiptNumber { get; set; }

        [StringLength(256)]
        public string? LastReceiptImage { get; set; }

        public int IdentificationTypeId { get; set; }


        [StringLength(50)]
        public string? GhanaCardNumber { get; set; }

        [StringLength(256)]
        public string? GhanaCardFrontImage { get; set; }

        [StringLength(256)]
        public string? GhanaCardBackImage { get; set; }

        [StringLength(256)]
        public string? SelfieImage { get; set; }

        [StringLength(256)]
        public string? PassportPicture { get; set; }

        [StringLength(10)]
        public string? Channel { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int Status { get; set; }

        [StringLength(150)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(100)]
        public string? ContactPerson_Email { get; set; }

        [StringLength(25)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(50)]
        public string? ContactPerson_Position { get; set; }

        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string? ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }

        public string? ActivatedBy { get; set; }
        public DateTime ActivatedDate { get; set; }

        public string? DeactivatedBy { get; set; }
        public DateTime DeactivatedDate { get; set; }


    }
}

