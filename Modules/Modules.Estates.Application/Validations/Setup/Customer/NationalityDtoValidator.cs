using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class NationalityDtoValidator : AbstractValidator<NationalityCreateDto>
    {
		public NationalityDtoValidator()
		{
            RuleFor(x => x.nationalityId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.nationalities).NotEmpty().WithMessage("Nationality is required");
            RuleFor(x => x.nationalities).MaximumLength(50).WithMessage("Nationality cannot be more than 50 characters.");
            RuleFor(x => x.createdby).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

