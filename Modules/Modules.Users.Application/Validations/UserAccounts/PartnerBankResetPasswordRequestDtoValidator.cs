using System;
using FluentValidation;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class PartnerBankResetPasswordRequestDtoValidator : AbstractValidator<PartnerBankResetPasswordRequestDto>
    {
		public PartnerBankResetPasswordRequestDtoValidator()
		{
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress();
            RuleFor(x => x.Token).NotEmpty().GreaterThan(0);
            RuleFor(x => x.NewPassword).NotEmpty().MinimumLength(8);
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Equal(x => x.NewPassword).WithMessage("New password and confirmation password do not match.");
        }
	}
}

