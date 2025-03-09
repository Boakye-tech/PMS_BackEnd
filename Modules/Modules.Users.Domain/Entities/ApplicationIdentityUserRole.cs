using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Modules.Users.Domain.Entities
{
    //[Keyless]
	public class ApplicationIdentityUserRole : IdentityUserRole<string>
    {
        public DateTime AssignedOn { get; set; }
        public string? AssignedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }
        public short Status { get; set; }

        public ApplicationIdentityUserRole() : base()
		{
		}
	}
}

