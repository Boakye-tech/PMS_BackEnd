using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class InterestExpressedDtoValidator : AbstractValidator<InterestExpressedCreateDto>
	{
		public InterestExpressedDtoValidator()
		{
            RuleFor(x => x.interestExpressedId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.customerInterestExpressed).NotEmpty().WithMessage("Customer interest expressed is required.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

