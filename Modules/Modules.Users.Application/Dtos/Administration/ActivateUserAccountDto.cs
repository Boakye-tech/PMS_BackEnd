using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ActivateUserAccountDto(string activatedBy, DateTime activatedDate) : ConfirmUserAccountDto();
    public record DeactivateUserAccountDto(string DeactivatedBy, DateTime DeactivatedDate, string DeactivatedReasons) : ConfirmUserAccountDto();

}

