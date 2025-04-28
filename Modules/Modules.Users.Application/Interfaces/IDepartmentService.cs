// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

