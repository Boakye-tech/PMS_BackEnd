﻿using System;
using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class InvoiceTypesDtoValidator: AbstractValidator<InvoiceTypesCreateDto>
    {
		public InvoiceTypesDtoValidator()
		{
            RuleFor(x => x.InvoiceInitials).NotEmpty().Length(3, 5).WithMessage("The invoice initials must not be empty, null or less than three(3) characters or exceed five(5) characters");
            RuleFor(x => x.InvoiceAmount).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The invoice amount must be greater than 0");
            RuleFor(x => x.InvoiceDescriptions).NotEmpty().Length(3, 75).WithMessage("The invoice initials must not be empty, null or exceed seventy-five(75) characters");

        }
    }
}

