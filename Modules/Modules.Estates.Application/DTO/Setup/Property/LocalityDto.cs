namespace Modules.Estates.Application.DTO.Setup.Property;

public record LocalityReadDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode);
public record LocalityCreateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, string CreatedBy);
public record LocalityUpdateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, string ModifiedBy);
public record LocalityDeleteDto(int LocalityId);

