using System;
namespace Modules.Users.Domain.Entities
{
	public class JwTokenResponse
	{
		public string? Token { get; set; }
		public DateTime? ExpiresAt { get; set; }
	}
}

