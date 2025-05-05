// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Identity;

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

