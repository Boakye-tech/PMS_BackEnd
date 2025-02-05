using System;
namespace Modules.Users.Application.Dtos.Administration
{
    public record RolesPermissionsResponseDto
    {
        public string? RoleName { get; set; }
        public IEnumerable<RolesWithMenusResponseDto>? AssignedPermissions { get; set; }
    }

    public record RolesWithMenusResponseDto(string MenuName, string SubMenuName, string SubMenItemName ,bool NoAccess, bool Create, bool Read, bool Update, bool Delete, bool Approve);

}

