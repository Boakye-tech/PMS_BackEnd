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

public record BankBranchReadDto(string BankId, string BranchId, string BranchName) ;
public record BankBranchCreateDto(string BankId, string BranchId, string BranchName,string CreatedBy);
public record BankBranchUpdateDto(string BankId, string BranchId, string BranchName,string ModifiedBy);
public record BankBranchDeleteDto(string BankId);
