using System;// /**************************************************
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

