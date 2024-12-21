using System;
namespace Modules.Users.Application.Validations.UserAccounts
{
	public class PartnerBankLoginRequestDtoValidator : AbstractValidator<PartnerBankLoginRequestDto>
	{
		public PartnerBankLoginRequestDtoValidator()
		{
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);

        }
    }

}



