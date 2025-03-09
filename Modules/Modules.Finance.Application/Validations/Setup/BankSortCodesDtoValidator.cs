using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class BankSortCodesDtoValidator : AbstractValidator<BankSortCodesCreateDto>
    {
		public BankSortCodesDtoValidator()
		{
            RuleFor(x => x.SortCode).NotEmpty().MinimumLength(6).WithMessage("The sort code must not be empty, null or less than six(6) characters");
            RuleFor(x => x.BankName).NotEmpty().Length(2, 50).WithMessage("The bank name must not be empty, null or exceed fifty(50) characters");
            RuleFor(x => x.BranchName).NotEmpty().Length(10, 120).WithMessage("The branch name must not be empty, null or exceed one hundred and twenty(120) characters");
        }
    }
}

