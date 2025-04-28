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
	public interface IDepartmentUnitService
	{
        Task<DepartmentUnitReadDto> AddDepartmentUnitAsync(DepartmentUnitCreateDto values);
        Task<DepartmentUnitReadDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values);
        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync();

        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync(int value);
        Task<DepartmentUnitReadDto> GetDepartmentUnitAsync(string value);


        Task<IEnumerable<UnitReadDto>> GetUnitAsync(int value);

        Task<GenericResponseDto> DeleteDepartmentUnit(int unitId);
    }
}

