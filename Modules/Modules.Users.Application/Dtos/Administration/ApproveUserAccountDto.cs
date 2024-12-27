using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ApproveUserAccountDto(string ApprovedBy) : ConfirmUserAccountDto();
    public record DisapprovedUserAccountDto(string DisapprovedBy, string DisapprovedReasons) : ConfirmUserAccountDto();

}

