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
	public class DepartmentUnitDtoValidator : AbstractValidator<DepartmentUnitCreateDto>
	{
		public DepartmentUnitDtoValidator()
		{
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.UnitId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.UnitName).NotEmpty().Length(2, 30).WithMessage("The department unit name must not be empty, null or exceed thirty(30) characters");

        }
    }
}

