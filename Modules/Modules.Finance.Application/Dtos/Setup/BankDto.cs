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

public record BankReadDto(string BankId, string BankName) ;
public record BankCreateDto(string BankId, string BankName, string CreatedBy);
public record BankUpdateDto(string BankId, string BankName, string ModifiedBy);
public record BankDeleteDto(string BankId);

