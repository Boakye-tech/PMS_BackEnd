using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public abstract record ConfirmUserAccountDto
	{
		public ConfirmUserAccountDto(){ }

		int UserAccountType;
		string? EmailAddress;
		int status;
	};
	
}

