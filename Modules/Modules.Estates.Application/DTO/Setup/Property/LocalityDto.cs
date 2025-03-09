namespace Modules.Estates.Application.DTO.Setup.Property;

public record LocalityReadDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter);
public record LocalityCreateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter, string CreatedBy);
public record LocalityUpdateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter, string ModifiedBy);
public record LocalityDeleteDto(int LocalityId);

