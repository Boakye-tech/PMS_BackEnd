using System;
using Modules.Users.Application.Dtos.Administration;

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

