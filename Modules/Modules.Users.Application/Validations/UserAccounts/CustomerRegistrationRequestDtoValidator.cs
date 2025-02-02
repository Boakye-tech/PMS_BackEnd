using System;
using FluentValidation;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class CustomerRegistrationRequestDtoValidator : AbstractValidator<CustomerRegistrationRequestDto>
    {
		public CustomerRegistrationRequestDtoValidator()
		{
            RuleFor(x => x.CustomerCode).NotEmpty().Length(5, 8).WithMessage("Staff identification number is required");
            RuleFor(x => x.FirstName).NotEmpty().Length(2, 50).WithMessage("Staff firstname is required");
            RuleFor(x => x.LastName).NotEmpty().Length(2, 100).WithMessage("Staff lastName is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(9, 12).Matches("^([0-9]{10})$").WithMessage("Invalid Phone Number.");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required").EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$").WithMessage("Invalid email address format.");

            RuleFor(x => x.LastReceiptNumber).NotEmpty().MinimumLength(11).WithMessage("The last receipt number is required and cannot be less than eleven(11) characters.");
            RuleFor(x => x.LastReceiptImage).NotEmpty().WithMessage("Image of receipt required.");
            RuleFor(x => x.IdentificationTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.IdentificationUniqueNumber).NotEmpty().WithMessage("The unique identification number is required.");
            RuleFor(x => x.IdentificationImage).NotEmpty().WithMessage("Image of identification type required.");

            RuleFor(x => x.IdentificationImage).NotEmpty().WithMessage("Image of identification type required.");
            RuleFor(x => x.ChannelId).GreaterThanOrEqualTo(0).WithMessage("The channel is required.");
            //RuleFor(x => x.RegistrationDate).NotEmpty().WithMessage("Registration date is required.").GreaterThan(DateTime.Now).WithMessage("");
            //RuleFor(x => x.Status).GreaterThanOrEqualTo(0);


            //RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
            //RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password and confirmation password do not match.");

        }
    }
}

