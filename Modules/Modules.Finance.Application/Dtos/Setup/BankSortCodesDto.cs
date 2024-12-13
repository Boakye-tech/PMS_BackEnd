using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record BankSortCodesReadDto(int Id, string SortCode, string BankName, string BranchName);
public record BankSortCodesCreateDto(int Id, string SortCode, string BankName, string BranchName, string CreatedBy);
public record BankSortCodesUpdateDto(int Id, string SortCode, string BankName, string BranchName, string ModifiedBy);
public record BankSortCodesDeleteDto(int Id);
