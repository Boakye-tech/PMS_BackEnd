﻿using System;
namespace Modules.Users.Application.Validations.UserAccounts
{
    public class ResetPasswordRequestDtoValidator : AbstractValidator<ResetPasswordRequestDto>
    {
        public ResetPasswordRequestDtoValidator()
        {
            RuleFor(x => x.Phone_OR_Email).NotEmpty().WithMessage("User email address or mobile phone number is required");
            RuleFor(x => x.Token)
                .Length(6).WithMessage("OTP Token cannot be less or more than 6 digits.")
                .Matches(@"^\d+$").WithMessage("OTP Token must contain only numeric digits.");

            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("New password is required");
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Equal(x => x.NewPassword).WithMessage("Password and confirmation password do not match.");

        }
    }
}

