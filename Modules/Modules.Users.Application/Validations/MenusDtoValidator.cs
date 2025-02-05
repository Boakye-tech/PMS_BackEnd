using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Validations
{
	public class MenusDtoValidator : AbstractValidator<MenusDto>
	{
		public MenusDtoValidator()
		{
            RuleFor(x => x.menuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.menuName).NotEmpty().Length(2, 100).WithMessage("The menu name must not be empty, null or exceed 100 characters");

        }
    }
}

