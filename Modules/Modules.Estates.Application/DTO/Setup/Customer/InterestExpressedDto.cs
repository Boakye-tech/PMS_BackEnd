using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
	public record InterestExpressedReadDto(int interestExpressedId, string customerInterestExpressed);
    public record InterestExpressedCreateDto(int interestExpressedId, string customerInterestExpressed, string createdBy);
    public record InterestExpressedUpdateDto(int interestExpressedId, string customerInterestExpressed, string modifiedBy);
    public record InterestExpressedDeleteDto(int interestExpressedId, string deletedBy);

}

