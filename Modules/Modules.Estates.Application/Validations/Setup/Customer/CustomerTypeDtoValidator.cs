﻿using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class CustomerTypeDtoValidator : AbstractValidator<CustomerTypeCreateDto>
    {
		public CustomerTypeDtoValidator()
		{
            RuleFor(x => x.customerTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.customerTypes).NotEmpty().WithMessage("Customer type is required");
            RuleFor(x => x.customerTypes).MaximumLength(50).WithMessage("Customer type cannot be more than 50 characters.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");
        }
	}
}

