using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesDto(string RoleId, string RoleName, int DepartmentId, string Department, int UnitId, string Unit, string CreatedBy, DateTime CreatedOn, string ApprovedBy, DateTime ApprovedOn, string Status);
    public record RolesCreateDto(string RoleName, int DepartmentId, int UnitId, string CreatedBy);
    public record RolesUpdateDto(string RoleId, int DepartmentId, int UnitId, string RoleName, string ModifiedBy);
    public record RolesDeleteDto(string RoleId, string DeletedBy);

    public record RolesApprovalDto(string RoleId, string ApprovedBy);


}

