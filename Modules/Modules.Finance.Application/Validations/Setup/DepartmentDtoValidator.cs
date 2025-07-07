// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
    public class DepartmentDtoValidator : AbstractValidator<DepartmentCreateDto>
    {
        public DepartmentDtoValidator()
        {
            RuleFor(x => x.DepartmentId).GreaterThanOrEqualTo(0).WithMessage("The department id must be greater than or equal to zero");
            RuleFor(x => x.DepartmentName).NotEmpty().Length(2, 50).WithMessage("The department name must not be empty, null or exceed fifty(50) characters");
            RuleFor(x => x.CreatedBy).NotEmpty().WithMessage("The created by field must not be empty or null");
        }
    }
}