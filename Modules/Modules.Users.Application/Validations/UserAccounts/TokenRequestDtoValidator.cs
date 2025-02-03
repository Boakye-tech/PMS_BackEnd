using System;
namespace Modules.Users.Application.Validations.UserAccounts
{
	public class TokenRequestDtoValidator : AbstractValidator<TokenRequestParameterDto>
    {
		public TokenRequestDtoValidator()
		{
            RuleFor(x => x.phone_OR_email).NotEmpty().WithMessage("User email address or mobile phone number is required");
        }
    }




    public class VerifyTokenRequestDtoValidator : AbstractValidator<VerifyTokenRequestDto>
    {
        public VerifyTokenRequestDtoValidator()
        {
            RuleFor(x => x.phone_OR_email).NotEmpty().WithMessage("User email address or mobile phone number is required");
            RuleFor(x => x.token)
                .Length(6).WithMessage("OTP Token cannot be less or more than 6 digits.")
                .Matches(@"^\d+$").WithMessage("OTP Token must contain only numeric digits.");
        }
    }
}

