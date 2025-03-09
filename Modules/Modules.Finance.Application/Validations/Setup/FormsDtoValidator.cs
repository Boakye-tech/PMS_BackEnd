using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class FormsDtoValidator: AbstractValidator<FormsCreateDto>
    {
		public FormsDtoValidator()
		{
            RuleFor(x => x.FormCode).NotEmpty();
            RuleFor(x => x.FormName).NotEmpty().Length(2, 30).WithMessage("The pay point name must not be empty, null or exceed thirty(30) characters");
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The amount must be greater than 0");
            RuleFor(x => x.AccountCode).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The account code must be greater than 0");
        }
    }
}

