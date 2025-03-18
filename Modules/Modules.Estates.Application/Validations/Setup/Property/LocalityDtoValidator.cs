﻿using System;
using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Property;

public class LocalityDtoValidator : AbstractValidator<LocalityCreateDto>
{
    public LocalityDtoValidator()
    {
        RuleFor(x => x.LocalityId).GreaterThanOrEqualTo(0);
        RuleFor(x => x.LocalityInitial).NotEmpty().MaximumLength(3).WithMessage("Locality initial cannot be less or more than 3 characters");
        RuleFor(x => x.LocalityName).NotEmpty().MaximumLength(50).WithMessage("Locality name cannot be more than 50 characters.");
        RuleFor(x => x.CreatedBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");
    }
}

