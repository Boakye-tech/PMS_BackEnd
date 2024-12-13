using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record ChartOfAccountsReadDto(int AccountCode, string AccountName);
public record ChartOfAccountsCreateDto(int AccountCode, string AccountName, string CreatedBy);
public record ChartOfAccountsUpdateDto(int AccountCode, string AccountName, string ModifiedBy);
public record ChartOfAccountsDeleteDto(int AccountCode);
