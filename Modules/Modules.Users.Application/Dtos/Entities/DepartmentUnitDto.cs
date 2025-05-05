// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Entities
{
	public record DepartmentUnitReadDto(int DepartmentId, int UnitId, string UnitName);
    public record DepartmentUnitCreateDto(int DepartmentId, int UnitId, string UnitName, string CreatedBy);
    public record DepartmentUnitUpdateDto(int DepartmentId, int UnitId, string UnitName, string ModifiedBy);
    public record DepartmentUnitDeleteDto(int UnitId);


    public record UnitReadDto(int UnitId, string UnitName);

}

