using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class TitleDtoValidator : AbstractValidator<TitleCreateDto>
    {
		public TitleDtoValidator()
		{
            RuleFor(x => x.titleId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.titles).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.titles).MaximumLength(20).WithMessage("Title cannot be more than 20 characters.");
            RuleFor(x => x.createdby).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

