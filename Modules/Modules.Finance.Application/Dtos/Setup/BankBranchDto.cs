using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record BankBranchReadDto(string BankId, string BranchId, string BranchName) ;
public record BankBranchCreateDto(string BankId, string BranchId, string BranchName,string CreatedBy);
public record BankBranchUpdateDto(string BankId, string BranchId, string BranchName,string ModifiedBy);
public record BankBranchDeleteDto(string BankId);
