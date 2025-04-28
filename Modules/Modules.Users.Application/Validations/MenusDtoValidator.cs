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
	public class MenusDtoValidator : AbstractValidator<MenusDto>
	{
		public MenusDtoValidator()
		{
            RuleFor(x => x.menuId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.menuName).NotEmpty().Length(2, 100).WithMessage("The menu name must not be empty, null or exceed 100 characters");

        }
    }
}

