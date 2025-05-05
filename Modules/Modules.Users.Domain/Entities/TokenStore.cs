// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class TokenStore
	{
        [Key]
        public int TokenStoreId { get; set; }

        [StringLength(15)]
        public string? MobilePhoneNumber { get; set; }

        [StringLength(75)]
        public string? EmailAddress { get; set; }

        [StringLength(10)]
        public string? Token { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime VerifiedDate { get; set; }

	}
}

