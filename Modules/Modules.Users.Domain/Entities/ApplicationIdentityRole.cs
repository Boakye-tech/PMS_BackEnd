using System;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Domain.Entities
{
	public class ApplicationIdentityRole : IdentityRole
	{
        public int DepartmentId { get; set; }
        public int UnitId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }
        public short Status { get; set; }


        public ApplicationIdentityRole() : base()
		{
		}
	}
}

