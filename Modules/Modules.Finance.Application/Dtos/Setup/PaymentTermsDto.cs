// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PaymentTermsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:40 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record PaymentTermsReadDto(int PaymentTermsId, int PaymentTerm);
public record PaymentTermsCreateDto(int PaymentTerm, string CreatedBy);
public record PaymentTermsUpdateDto(int PaymentTermsId, int PaymentTerm, string ModifiedBy);
public record PaymentTermsDeleteDto(int PaymentTermsId);
