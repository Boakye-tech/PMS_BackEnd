using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class IdentificationTypeDtoValidator : AbstractValidator<IdentificationTypeCreateDto>
    {
		public IdentificationTypeDtoValidator()
		{
            RuleFor(x => x.identificationTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.identificationTypes).NotEmpty().WithMessage("Identification type is required");
            RuleFor(x => x.identificationTypes).MaximumLength(20).WithMessage("Identification type cannot be more than 20 characters.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

