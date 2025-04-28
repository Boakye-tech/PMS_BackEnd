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
    public class ChangePasswordRequestDtoValidator : AbstractValidator<ChangePasswordRequestDto>
    {
        public ChangePasswordRequestDtoValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User Id is required");
            RuleFor(x => x.UserId).Length(36).WithMessage("User Id cannot be less or more than 36 characters.");

            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Old password is required"); //cannot be less than 8 characters
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("New password is required");

            RuleFor(x => x.ConfirmNewPassword).NotEmpty().WithMessage("The confirmNewPassword field is required.");

            RuleFor(x => x.OldPassword).MinimumLength(8);
            RuleFor(x => x.NewPassword).MinimumLength(8);
            RuleFor(x => x.ConfirmNewPassword).MinimumLength(8);


            RuleFor(x => x.NewPassword).NotEmpty().NotEqual(x => x.OldPassword).WithMessage("New password cannot be the same as the old password.");
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Equal(x => x.NewPassword).WithMessage("Password and confirmation password do not match.");

        }


       
    }
}

