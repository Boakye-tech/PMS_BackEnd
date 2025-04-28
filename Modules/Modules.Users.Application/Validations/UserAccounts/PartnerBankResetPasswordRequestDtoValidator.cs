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
	public class PartnerBankResetPasswordRequestDtoValidator : AbstractValidator<ResetPasswordRequestDto>
    {
		public PartnerBankResetPasswordRequestDtoValidator()
		{
            RuleFor(x => x.Phone_OR_Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Token).NotEmpty();
            RuleFor(x => x.NewPassword).NotEmpty().MinimumLength(8);
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Equal(x => x.NewPassword).WithMessage("New password and confirmation password do not match.");
        }
	}
}

