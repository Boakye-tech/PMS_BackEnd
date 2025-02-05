using System;
namespace Modules.Users.Application.Interfaces
{
	public interface IDepartmentUnitService
	{
        Task<DepartmentUnitReadDto> AddDepartmentUnitAsync(DepartmentUnitCreateDto values);
        Task<DepartmentUnitReadDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values);
        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync();

        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync(int value);
        Task<DepartmentUnitReadDto> GetDepartmentUnitAsync(string value);


        Task<IEnumerable<UnitReadDto>> GetUnitAsync(int value);
    }
}

