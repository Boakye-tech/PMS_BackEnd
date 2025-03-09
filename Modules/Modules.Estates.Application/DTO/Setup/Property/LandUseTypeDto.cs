namespace Modules.Estates.Application.DTO.Setup.Property;

public record LandUseTypeReadDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName);
public record LandUseTypeCreateDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string CreatedBy);
public record LandUseTypeUpdateDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string ModifiedBy);
public record LandUseTypeDeleteDto(int LandUseId);


