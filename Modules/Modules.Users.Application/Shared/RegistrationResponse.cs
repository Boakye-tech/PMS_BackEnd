using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public class RegistrationResponse
	{
        [Required]
        public int StatusCode { get; set; }

        [Required]
        public string? StatusMessage { get; set; }

        //[Required]
        public string? UserId { get; set; }

        public string? UserEmailAddress { get; set; }
    }
}

