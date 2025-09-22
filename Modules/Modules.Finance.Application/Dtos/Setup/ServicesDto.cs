// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/ServicesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Dtos.Setup;

public record ServicesReadDto(int ServicesId, string ServiceName, string? Description, bool HasFee, double Amount, int AccountCode);
public record ServicesCreateDto(string ServiceName, string? Description, bool HasFee, double Amount, int AccountCode, string CreatedBy);
public record ServicesUpdateDto(int ServicesId, string ServiceName, string? Description, bool HasFee, double Amount, int AccountCode, string ModifiedBy);
public record ServicesDeleteDto(int ServicesId);


//public record ServiceDepartment(int DepartmentId, string DepartmentInitial, string DepartmentName, List<ServiceReadDto> Services);
//public record ServiceReadDto(int RoomNumber, string ServiceName, string? Description, bool HasFee, double Amount, int AccountCode);