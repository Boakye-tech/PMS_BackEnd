// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/PaymentTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record PaymentTypeReadDto(int PaymentTypeId, string PaymentTypes);
public record PaymentTypeCreateDto(int PaymentTypeId, string PaymentTypes, string CreatedBy);
public record PaymentTypeUpdateDto(int PaymentTypeId, string PaymentTypes, string ModifiedBy);
public record PaymentTypeDeleteDto(int PaymentTypeId);
