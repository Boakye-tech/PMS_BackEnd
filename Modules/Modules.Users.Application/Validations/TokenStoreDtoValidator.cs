// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Validations
{
	public class TokenStoreDtoValidator :  AbstractValidator<TokenStoreCreateDto>
	{
		public TokenStoreDtoValidator()
		{
            //RuleFor(x => x.PaypointId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Token).NotEmpty().Length(2, 10).WithMessage("The token must not be empty, null or exceed ten(10) characters");
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
            RuleFor(x => x.MobilePhoneNumber).NotEmpty().Length(9, 12).Matches("^([0-9]{10})$").WithMessage("Invalid mobile phone number.");

        }
    }
}

