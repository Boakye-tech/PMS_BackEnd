using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class BankDtoValidator : AbstractValidator<BankCreateDto>
	{
		public BankDtoValidator()
		{
            RuleFor(x => x.BankId).NotEmpty().MinimumLength(10).WithMessage("The bank id must not be empty, null or less than ten(10) characters");
            RuleFor(x => x.BankName).NotEmpty().Length(2, 50).WithMessage("The bank name must not be empty, null or exceed fifty(50) characters");

        }
    }
}

