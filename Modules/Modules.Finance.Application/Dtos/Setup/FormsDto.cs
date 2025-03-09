using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record FormsReadDto(string FormCode, string FormName, double Amount, int AccountCode);
public record FormsCreateDto(string? FormCode, string FormName, double Amount, int AccountCode, string CreatedBy);
public record FormsUpdateDto(string FormCode, string FormName, double Amount, int AccountCode, string ModifiedBy);
public record FormsDeleteDto(string FormCode);
