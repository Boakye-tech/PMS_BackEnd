using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class PayPointDtoValidator : AbstractValidator<PaypointsCreateDto>
    {
		public PayPointDtoValidator()
		{
            RuleFor(x => x.PaypointId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Paypoint).NotEmpty().Length(2, 30).WithMessage("The pay point name must not be empty, null or exceed thirty(30) characters");
        }
	}
}

