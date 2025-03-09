using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record PaypointsReadDto(int PaypointId, string Paypoint);
public record PaypointsCreateDto(int PaypointId, string Paypoint, string CreatedBy);
public record PaypointsUpdateDto(int PaypointId, string Paypoint, string ModifiedBy);
public record PaypointsDeleteDto(int PaypointId);

