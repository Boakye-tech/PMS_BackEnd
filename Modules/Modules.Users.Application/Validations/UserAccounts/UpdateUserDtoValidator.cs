using System;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Validations.UserAccounts
{
    public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
    {
        public UpdateUserDtoValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User Id is required");
            RuleFor(x => x.UserId).Length(36).WithMessage("User Id cannot be less or more than 36 characters.");

           
        }
    }
}

