using System;
namespace Modules.Estates.Application.DTO.Setup.Customer;

public record OwnershipTypeReadDto(int ownershipTypeId, string ownershipTypes);
public record OwnershipTypeCreateDto(int ownershipTypeId, string ownershipTypes, string createdby);
public record OwnershipTypeUpdateDto(int ownershipTypeId, string ownershipTypes, string modifiedby);
public record OwnershipTypeDeleteDto(int ownershipTypeId);

