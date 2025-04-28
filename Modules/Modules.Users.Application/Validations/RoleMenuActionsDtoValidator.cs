// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

