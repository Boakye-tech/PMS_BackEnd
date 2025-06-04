// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/LandUseTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record LandUseTypeReadDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string LandUseTypeDescription);
public record LandUseTypeCreateDto(int LandUseId, string LandUseTypeInitial, string LandUseTypeName, string LandUseTypeDescription, string CreatedBy);
public record LandUseTypeUpdateDto(int LandUseId, int LandUseTypeId, string LandUseTypeInitial, string LandUseTypeName, string LandUseTypeDescription, string ModifiedBy);
public record LandUseTypeDeleteDto(int LandUseTypeId);


public record LandUsesReadDto(int LandUseId, string LandUseInitial, string LandUseName, bool IsOpen);
public record LandUseAndLandUseTypeReadDto(LandUsesReadDto LandUse, List<LandUseTypeReadDto> LandUseTypes);
