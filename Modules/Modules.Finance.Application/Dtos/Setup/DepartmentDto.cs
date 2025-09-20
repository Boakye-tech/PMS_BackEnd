// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/DepartmentDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Dtos.Setup;

public record DepartmentReadDto(int DepartmentId, string DepartmentInitial, string DepartmentName);
public record DepartmentCreateDto(int DepartmentId, string DepartmentInitial, string DepartmentName, string CreatedBy);
public record DepartmentUpdateDto(int DepartmentId, string DepartmentInitial, string DepartmentName, string ModifiedBy);
public record DepartmentDeleteDto(int DepartmentId);