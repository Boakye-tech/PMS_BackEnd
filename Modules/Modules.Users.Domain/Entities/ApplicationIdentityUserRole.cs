using System;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Domain.Entities
{
	public class ApplicationIdentityUserRole : IdentityUserRole<string>
    {
        public DateTime AssignedOn { get; set; }
        public string? AssignedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }

        public ApplicationIdentityUserRole() : base()
		{
		}
	}
}

