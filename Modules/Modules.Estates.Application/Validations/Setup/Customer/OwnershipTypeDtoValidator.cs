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
	public class OwnershipTypeDtoValidator : AbstractValidator<OwnershipTypeCreateDto>
    {
		public OwnershipTypeDtoValidator()
		{
            RuleFor(x => x.ownershipTypeId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.ownershipTypes).NotEmpty().WithMessage("Ownership type is required");
            RuleFor(x => x.ownershipTypes).MaximumLength(50).WithMessage("Ownership type cannot be more than 50 characters.");
            RuleFor(x => x.createdby).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

