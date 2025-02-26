using System;
namespace Modules.Users.Application.Dtos.Entities
{
	public record DepartmentUnitReadDto(int DepartmentId, int UnitId, string UnitName);
    public record DepartmentUnitCreateDto(int DepartmentId, int UnitId, string UnitName, string CreatedBy);
    public record DepartmentUnitUpdateDto(int DepartmentId, int UnitId, string UnitName, string ModifiedBy);
    public record DepartmentUnitDeleteDto(int UnitId);


    public record UnitReadDto(int UnitId, string UnitName);

}

