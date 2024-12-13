using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record PaymentModeReadDto(int PaymentModeId, string? PaymentModes);
public record PaymentModeCreateDto(int PaymentModeId, string? PaymentModes, string CreatedBy);
public record PaymentModeUpdateDto(int PaymentModeId, string? PaymentModes, string Modified);
public record PaymentModeDeleteDto(int PaymentModeId);

