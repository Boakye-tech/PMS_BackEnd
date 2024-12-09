using System;
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

        public TokenStore()
		{
		}
	}
}

