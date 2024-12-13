using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record BankReadDto(string BankId, string BankName) ;
public record BankCreateDto(string BankId, string BankName, string CreatedBy);
public record BankUpdateDto(string BankId, string BankName, string ModifiedBy);
public record BankDeleteDto(string BankId);

