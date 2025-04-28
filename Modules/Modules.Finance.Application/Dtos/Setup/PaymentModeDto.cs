// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record PaymentModeReadDto(int PaymentModeId, string? PaymentModes);
public record PaymentModeCreateDto(int PaymentModeId, string? PaymentModes, string CreatedBy);
public record PaymentModeUpdateDto(int PaymentModeId, string? PaymentModes, string Modified);
public record PaymentModeDeleteDto(int PaymentModeId);

