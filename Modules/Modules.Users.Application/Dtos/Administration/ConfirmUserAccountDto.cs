using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Administration
{
	public abstract record ConfirmUserAccountDto
	{
        public int UserAccountType { get; set; }

		[EmailAddress]
        public string? EmailAddress { get; set; }

        //public int status { get; set; }
    };
	
}

