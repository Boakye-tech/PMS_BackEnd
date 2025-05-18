// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/PaypointsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record PaypointsReadDto(int PaypointId, string Paypoint);
public record PaypointsCreateDto(int PaypointId, string Paypoint, string CreatedBy);
public record PaypointsUpdateDto(int PaypointId, string Paypoint, string ModifiedBy);
public record PaypointsDeleteDto(int PaypointId);

