using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class PaymentModeDtoValidator : AbstractValidator<PaymentModeCreateDto>
    {
		public PaymentModeDtoValidator()
		{
            RuleFor(x => x.PaymentModeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.PaymentModes).NotEmpty().Length(2, 20).WithMessage("The payment mode must not be empty, null or exceed twenty(20) characters");
        }
	}
}

