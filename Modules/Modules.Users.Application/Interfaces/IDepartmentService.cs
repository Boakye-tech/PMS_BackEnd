using System;
namespace Modules.Users.Application.Interfaces
{
	public interface IDepartmentService
	{
        Task<DepartmentReadDto> AddDepartmentAsync(DepartmentCreateDto values);
        Task<DepartmentReadDto> UpdateDepartmentAsync(DepartmentUpdateDto values);
        Task<IEnumerable<DepartmentReadDto>> GetDepartmentAsync();
        Task<DepartmentReadDto> GetDepartmentAsync(int value);
        Task<DepartmentReadDto> GetDepartmentAsync(string value);
        Task<GenericResponseDto> DeleteDepartment(int departmentId);
    }
}

