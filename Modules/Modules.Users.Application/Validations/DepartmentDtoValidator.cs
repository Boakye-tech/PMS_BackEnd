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
	public class DepartmentDtoValidator : AbstractValidator<DepartmentCreateDto>
    {
		public DepartmentDtoValidator()
		{
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.DepartmentName).NotEmpty().Length(2, 50).WithMessage("The department name must not be empty, null or exceed fifty(50) characters");

        }
    }
}

