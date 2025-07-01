// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Validations/Setup/CategoryDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:19 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Facilities.Application.Validations.Setup
{
	public class CategoryDtoValidator : AbstractValidator<CategoryCreateDto>
    {
		public CategoryDtoValidator()
		{
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Category is required");
            RuleFor(x => x.categoryName).MaximumLength(75).WithMessage("Category cannot be more than 75 characters.");
            RuleFor(x => x.createdBy).Length(36).WithMessage("Created by cannot be less or more than 36 characters.");

        }
    }

    public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(x => x.categoryId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Category is required");
            RuleFor(x => x.categoryName).MaximumLength(75).WithMessage("Category cannot be more than 75 characters.");
            RuleFor(x => x.modifiedBy).Length(36).WithMessage("Modified by cannot be less or more than 36 characters.");

        }
    }
}

