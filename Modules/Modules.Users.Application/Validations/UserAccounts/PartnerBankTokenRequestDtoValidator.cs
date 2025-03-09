using System;
namespace Modules.Users.Application.Validations.UserAccounts
{
    public class PartnerBankTokenRequestDtoValidator : AbstractValidator<PartnerBankTokenRequestDto>
    {
        public PartnerBankTokenRequestDtoValidator()
        {
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");

        }
    }
}

