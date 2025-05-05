// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Users.Application.Validations.UserAccounts
{
	public class CustomerRegistrationRequestDtoValidator : AbstractValidator<CustomerRegistrationRequestDto>
    {
		public CustomerRegistrationRequestDtoValidator()
		{
            RuleFor(x => x.CustomerCode).NotEmpty().Length(6, 7).Matches(@"^[1-9][A-Z]{1,2}\d{3,4}$").WithMessage("Invalid Customer Code. Please provide a valid code.");
            RuleFor(x => x.FirstName).NotEmpty().Length(2, 50).WithMessage("Customer firstname is required");
            RuleFor(x => x.LastName).NotEmpty().Length(2, 100).WithMessage("Customer lastName is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(9, 12).Matches("^([0-9]{10})$").WithMessage("Invalid Phone Number.");
            //RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required").EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$"); //.WithMessage("Invalid email address format.");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required"); //.EmailAddress().Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); //.WithMessage("Invalid email address format.");


            RuleFor(x => x.LastReceiptNumber).NotEmpty().MinimumLength(11).WithMessage("The last receipt number is required and cannot be less than eleven(11) characters.");
            RuleFor(x => x.LastReceiptImage).NotEmpty().WithMessage("Image of receipt required.");
            RuleFor(x => x.IdentificationTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.IdentificationUniqueNumber).NotEmpty().WithMessage("The unique identification number is required.");
            RuleFor(x => x.IdentificationImage).NotEmpty().WithMessage("Image of identification type required.");

            RuleFor(x => x.IdentificationImage).NotEmpty().WithMessage("Image of identification type required.");
            RuleFor(x => x.ChannelId).GreaterThanOrEqualTo(0).WithMessage("The channel is required.");

            RuleFor(x => x.SelfieImage).Must(value => value is string).WithMessage("Invalid selfie image."); 

            //RuleFor(x => x.RegistrationDate).NotEmpty().WithMessage("Registration date is required.").GreaterThan(DateTime.Now).WithMessage("");
            //RuleFor(x => x.Status).GreaterThanOrEqualTo(0);


            //RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
            //RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password and confirmation password do not match.");

        }
    }
}

