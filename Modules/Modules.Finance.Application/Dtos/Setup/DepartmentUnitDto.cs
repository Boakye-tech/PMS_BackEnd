// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/DepartmentUnitDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Dtos.Setup;

public record DepartmentUnitReadDto(int DepartmentId, int UnitId, string UnitName);
public record DepartmentUnitCreateDto(int DepartmentId, int UnitId, string UnitName, string CreatedBy);
public record DepartmentUnitUpdateDto(int DepartmentId, int UnitId, string UnitName, string ModifiedBy);
public record DepartmentUnitDeleteDto(int UnitId);