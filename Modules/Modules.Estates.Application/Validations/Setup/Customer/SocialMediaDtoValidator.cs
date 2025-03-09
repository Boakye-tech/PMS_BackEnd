﻿using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class SocialMediaDtoValidator : AbstractValidator<SocialMediaCreateDto>
    {
		public SocialMediaDtoValidator()
		{
            RuleFor(x => x.SocialMediaId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.SocialMediaPlatform).NotEmpty().WithMessage("Social media is required");
            RuleFor(x => x.SocialMediaPlatform).MaximumLength(10).WithMessage("Social media cannot be more than 10 characters.");
            RuleFor(x => x.CreatedBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

