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

public record BlockSideReadDto(int sideId, string side);
public record BlockSideCreateDto(int sideId, string side, string createdby);
public record BlockSideUpdateDto(int sideId, string side, string modifiedby);
public record BlockSideDeleteDto(int sideId);
