using System;
namespace Modules.Users.Application.Dtos.Entities
{
	public record DepartmentReadDto(int DepartmentId, string DepartmentName);
    public record DepartmentCreateDto(int DepartmentId, string DepartmentName, string CreatedBy);
    public record DepartmentUpdateDto(int DepartmentId, string DepartmentName, string ModifiedBy);
    public record DepartmentDeleteDto(int DepartmentId);

}

