// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Validations/Setup/ItemsDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Validations.Setup
{
    public class ItemsDtoValidator : AbstractValidator<ItemsCreateDto>
    {
        public ItemsDtoValidator()
        {
            RuleFor(x => x.itemCategoryId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.itemCode).NotEmpty().MaximumLength(20);
            RuleFor(x => x.itemName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.createdBy).Length(36);
        }
    }

    public class ItemsUpdateDtoValidator : AbstractValidator<ItemsUpdateDto>
    {
        public ItemsUpdateDtoValidator()
        {
            RuleFor(x => x.itemCategoryId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.itemCode).NotEmpty().MaximumLength(20);
            RuleFor(x => x.itemName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.modifiedBy).Length(36);
        }
    }
}