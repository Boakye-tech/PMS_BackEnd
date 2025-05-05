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

public record LocalityReadDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter);
public record LocalityCreateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter, string CreatedBy);
public record LocalityUpdateDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter, string ModifiedBy);
public record LocalityDeleteDto(int LocalityId);

