// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record LandUseReadDto(int LandUseId, string LandUseInitial, string LandUseName);
public record LandUseCreateDto(int LandUseId, string? LandUseInitial, string? LandUseName, string CreatedBy);
public record LandUseUpdateDto(int LandUseId, string? LandUseInitial, string? LandUseName, string ModifiedBy);
public record LandUseDeleteDto(int LandUseId);
