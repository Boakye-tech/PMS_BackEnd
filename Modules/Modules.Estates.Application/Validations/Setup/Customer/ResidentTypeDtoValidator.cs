// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using FluentValidation;

namespace Modules.Estates.Application.Validations.Setup.Customer
{
	public class ResidentTypeDtoValidator : AbstractValidator<ResidentTypeCreateDto>
    {
		public ResidentTypeDtoValidator()
		{
            RuleFor(x => x.residentTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.residentTypes).NotEmpty().WithMessage("Resident type is required");
            RuleFor(x => x.residentTypes).MaximumLength(50).WithMessage("Resident type cannot be more than 50 characters.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

