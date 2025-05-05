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

public record LandUseTypeReadDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName);
public record LandUseTypeCreateDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string CreatedBy);
public record LandUseTypeUpdateDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string ModifiedBy);
public record LandUseTypeDeleteDto(int LandUseId);


