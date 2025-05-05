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
    public class ApproveUserAccountDtoValidator : AbstractValidator<ApproveUserAccountDto>
    {
        public ApproveUserAccountDtoValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User Id is required");
            RuleFor(x => x.UserId).Length(36).WithMessage("User Id cannot be less or more than 36 characters.");
            RuleFor(x => x.RoleId).NotEmpty().WithMessage("Role Id is required");
            RuleFor(x => x.ApprovedBy).NotEmpty().WithMessage("Approved by is required");
            RuleFor(x => x.ApprovedBy).Length(36).WithMessage("Approved by cannot be less or more than 36 characters.");

        }
    }
}

