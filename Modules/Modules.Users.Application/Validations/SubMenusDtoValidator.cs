using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Validations
{
	public class SubMenusDtoValidator : AbstractValidator<SubMenusCreateDto>
	{
		public SubMenusDtoValidator()
		{
            RuleFor(x => x.menuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.subMenuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.subMenuName).NotEmpty().Length(2, 110).WithMessage("The sub-menu name must not be empty, null or exceed 110 characters");

        }
    }
}

