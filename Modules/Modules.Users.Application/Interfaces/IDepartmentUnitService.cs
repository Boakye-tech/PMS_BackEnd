using System;
namespace Modules.Users.Application.Interfaces
{
	public interface IDepartmentUnitService
	{
        Task<DepartmentUnitReadDto> AddDepartmentUnitAsync(DepartmentUnitCreateDto values);
        Task<DepartmentUnitReadDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values);
        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync();
        Task<DepartmentUnitReadDto> GetDepartmentUnitAsync(int value);
        Task<DepartmentUnitReadDto> GetDepartmentUnitAsync(string value);
    }
}

