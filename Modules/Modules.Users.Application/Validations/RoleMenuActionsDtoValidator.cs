using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Validations
{
	public class RoleMenuActionsDtoValidator : AbstractValidator<RoleMenuActionsDto>
	{
		public RoleMenuActionsDtoValidator()
		{
            RuleFor(x => x.roleMenuActionId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.roleId).NotEmpty().Length(2, 50).WithMessage("The menu name must not be empty, null or exceed fifty(50) characters");
            RuleFor(x => x.menuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.actionId).GreaterThanOrEqualTo(0);

        }
    }
}

