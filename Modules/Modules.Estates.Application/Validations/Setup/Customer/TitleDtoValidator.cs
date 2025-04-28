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
	public class TitleDtoValidator : AbstractValidator<TitleCreateDto>
    {
		public TitleDtoValidator()
		{
            RuleFor(x => x.titleId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.titles).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.titles).MaximumLength(20).WithMessage("Title cannot be more than 20 characters.");
            RuleFor(x => x.createdby).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }
}

