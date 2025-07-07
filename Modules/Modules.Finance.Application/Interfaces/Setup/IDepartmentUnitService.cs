// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;

namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IDepartmentUnitService
    {
        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync();
        Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitByDepartmentAsync(int departmentId);
        Task<ReturnResponsesDto> CreateDepartmentUnitAsync(DepartmentUnitCreateDto values);
        Task<ReturnResponsesDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values);
        Task<ReturnResponsesDto> DeleteDepartmentUnitAsync(int unitId);
    }
}