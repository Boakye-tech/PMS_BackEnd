using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ActivateUserAccountDto(string UserId, string activatedBy); //: ConfirmUserAccountDto();
    public record DeactivateUserAccountDto(string UserId, string DeactivatedBy, string DeactivatedReasons); //: ConfirmUserAccountDto();

}

