using System;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Validations.UserAccounts
{
	public class RolesDtoValidator : AbstractValidator<RolesDto>
	{
		public RolesDtoValidator()
		{
			RuleFor(x => x.RoleName).NotEmpty();
        }
	}

    public class RolesUpdateDtoValidator : AbstractValidator<RolesUpdateDto>
    {
        public RolesUpdateDtoValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty();
            RuleFor(x => x.RoleName).NotEmpty();

        }
    }

    public class RolesDeleteDtoValidator : AbstractValidator<RolesDeleteDto>
    {
        public RolesDeleteDtoValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty();
        }
    }
}


