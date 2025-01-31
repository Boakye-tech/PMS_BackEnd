using System;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class PartnerBankLoginRequestDtoValidator : AbstractValidator<LoginRequestDto>
	{
		public PartnerBankLoginRequestDtoValidator()
		{
            RuleFor(x => x.Phone_OR_Email)
                .NotEmpty().WithMessage("Email Address is required")
                .EmailAddress().WithMessage("Invalid email format")
                .Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$").WithMessage("Email must end with .com, .net, .org, or .gov");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);

        }
    }

}



