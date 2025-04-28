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

public record FloorNumberingReadDto(int floorNumberId, string floorNumber);
public record FloorNumberingCreateDto(int floorNumberId, string floorNumber, string createdby);
public record FloorNumberingUpdateDto(int floorNumberId, string floorNumber, string modified);
public record FloorNumberingDeleteDto(int floorNumberId);
