﻿using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class BankBranchDtoValidator : AbstractValidator<BankBranchCreateDto>
    {
		public BankBranchDtoValidator()
		{
            RuleFor(x => x.BankId).NotEmpty().MinimumLength(10).WithMessage("The bank id must not be emppty, null or less than ten(0) characters");
            RuleFor(x => x.BranchId).NotEmpty().MinimumLength(10).WithMessage("The branch id must not be emppty, null or less than ten(0) characters");
            RuleFor(x => x.BranchName).NotEmpty().Length(10, 120).WithMessage("The branch name must not be empty, null or exceed one hundred and twenty(120) characters");

        }
    }
}
