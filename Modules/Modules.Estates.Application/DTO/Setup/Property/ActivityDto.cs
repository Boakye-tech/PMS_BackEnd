// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record ActivityReadDto(int ActivityId, string ActivityName, string ActivityDescription);
    public record ActivityCreateDto(int ActivityId, string ActivityName, string ActivityDescription, string CreatedBy);
    public record ActivityUpdateDto(int ActivityId, string ActivityName, string ActivityDescription, string ModifiedBy);
    public record ActivityDeleteDto(int ActivityId);

}

