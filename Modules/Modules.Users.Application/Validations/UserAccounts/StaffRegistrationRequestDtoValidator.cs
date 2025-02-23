using System;
using FluentValidation;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class StaffRegistrationRequestDtoValidator : AbstractValidator<StaffRegistrationRequestDto>
    {
		public StaffRegistrationRequestDtoValidator()
		{
            RuleFor(x => x.StaffIdentificationNumber).NotEmpty().Length(4, 7).Matches(@"^(?:\d{4}|TCA\d{4})$"); //.WithMessage("Staff identification number is required.");
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.UnitId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.FirstName).NotEmpty().Length(3, 50); //.WithMessage("Staff firstname is required");
            RuleFor(x => x.MiddleName).Length(1, 100);//.WithMessage("Staff firstname is required");
            RuleFor(x => x.LastName).NotEmpty().Length(3, 100); //.WithMessage("Staff lastName is required");



            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required"); //.EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");//.WithMessage("Invalid email address format.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required.");
            RuleFor(x => x.UserName).Equal(x => x.EmailAddress).WithMessage("Email address and username must be the same.");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(10).Matches(@"^([0]{10})$");//.WithMessage("Invalid phone number.");
            RuleFor(x => x.ChannelId).GreaterThanOrEqualTo(0).WithMessage("Channel is required.");
            //RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
            //RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password and confirmation password do not match.");
        }
	}
}

