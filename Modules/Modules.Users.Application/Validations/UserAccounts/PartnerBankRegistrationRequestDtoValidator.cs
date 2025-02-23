using System;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class PartnerBankRegistrationRequestDtoValidator : AbstractValidator<PartnerBankRegistrationRequestDto>
	{
		public PartnerBankRegistrationRequestDtoValidator()
		{
            RuleFor(x => x.PartnerName).NotEmpty().Length(2, 50).WithMessage("Partner name is required");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required");//.EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");//.WithMessage("invalid email address format");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(9, 12).Matches("^([0-9]{10})$").WithMessage("Invalid phone number.");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password and confirmation password do not match.");
            //RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required").EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$").WithMessage("Invalid email address format.");

            RuleFor(x => x.ContactPerson_FullName).NotEmpty().Length(2, 200).WithMessage("Partner contact person full name is required");
            RuleFor(x => x.ContactPerson_EmailAddress).NotEmpty().WithMessage("Contact person email address is required").EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
            RuleFor(x => x.ContactPerson_PhoneNumber).NotEmpty().Length(9, 12).Matches("^([0-9]{10})$").WithMessage("Invalid contact person phone number.");
        }
	}
}

