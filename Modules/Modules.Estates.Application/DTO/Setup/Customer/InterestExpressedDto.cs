// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Customer
{
	public record InterestExpressedReadDto(int interestExpressedId, string customerInterestExpressed);
    public record InterestExpressedCreateDto(int interestExpressedId, string customerInterestExpressed, string createdBy);
    public record InterestExpressedUpdateDto(int interestExpressedId, string customerInterestExpressed, string modifiedBy);
    public record InterestExpressedDeleteDto(int interestExpressedId, string deletedBy);

}

