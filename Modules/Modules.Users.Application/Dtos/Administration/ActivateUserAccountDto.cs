using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ActivateUserAccountDto(string activatedBy, DateTime activatedDate, string Reasons) : ConfirmUserAccountDto();
	
}

