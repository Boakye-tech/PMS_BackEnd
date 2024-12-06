namespace Modules.Estates.Application.DTO.Setup.Property;

public record AllocationTypeReadDto(int AllocationTypeId, string AllocationTypeInitial, string AllocationTypes);
public record AllocationTypeCreateDto(int AllocationTypeId, string AllocationTypeInitial, string AllocationTypes, string CreatedBy);
public record AllocationTypeUpdateDto(int AllocationTypeId, string AllocationTypeInitial, string AllocationTypes, string ModifiedBy);
public record AllocationTypeDeleteDto(int AllocationTypeId);
