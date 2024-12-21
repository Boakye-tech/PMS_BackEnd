using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ApproveUserAccountDto(string ApprovedBy, DateTime ApprovedDate, string Reasons) : ConfirmUserAccountDto();
}

