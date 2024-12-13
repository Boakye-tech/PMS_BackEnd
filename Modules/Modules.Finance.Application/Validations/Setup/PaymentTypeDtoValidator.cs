using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class PaymentTypeDtoValidator : AbstractValidator<PaymentTypeCreateDto>
    {
		public PaymentTypeDtoValidator()
		{
            RuleFor(x => x.PaymentTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.PaymentTypes).NotEmpty().Length(2, 20).WithMessage("The payment type must not be empty, null or exceed twenty(20) characters");

        }
    }
}

