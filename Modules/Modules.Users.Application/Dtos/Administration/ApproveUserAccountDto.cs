using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record ApproveUserAccountDto(string RoleId, string UserId, string ApprovedBy); 
    public record DisapprovedUserAccountDto(string UserId, string DisapprovedBy, string DisapprovedReasons); 

}

