using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Validations
{
	public class SubMenuItemsDtoValidator : AbstractValidator<SubMenuItemsCreateDto>
	{
		public SubMenuItemsDtoValidator()
		{
            RuleFor(x => x.menuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.subMenuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.subMenuItemsId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.subMenuItemName).NotEmpty().Length(2, 130).WithMessage("The sub-menu item name must not be empty, null or exceed 130 characters");

        }
    }
}

