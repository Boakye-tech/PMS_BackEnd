using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record PaymentTypeReadDto(int PaymentTypeId, string PaymentTypes);
public record PaymentTypeCreateDto(int PaymentTypeId, string PaymentTypes, string CreatedBy);
public record PaymentTypeUpdateDto(int PaymentTypeId, string PaymentTypes, string ModifiedBy);
public record PaymentTypeDeleteDto(int PaymentTypeId);
