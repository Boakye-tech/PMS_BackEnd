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
	public class IdentificationTypeDtoValidator : AbstractValidator<IdentificationTypeCreateDto>
    {
		public IdentificationTypeDtoValidator()
		{
            RuleFor(x => x.identificationTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.identificationTypes).NotEmpty().WithMessage("Identification type is required");
            RuleFor(x => x.identificationTypes).MaximumLength(20).WithMessage("Identification type cannot be more than 20 characters.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

