// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Validations/Setup/CleanersDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Validations.Setup
{
    public class CleanersDtoValidator : AbstractValidator<CleanersCreateDto>
    {
        public CleanersDtoValidator()
        {
            RuleFor(x => x.staffID).NotEmpty().MaximumLength(10);
            RuleFor(x => x.firstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.middleName).MaximumLength(50);
            RuleFor(x => x.lastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.phoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.emailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.jobTitle).NotEmpty().MaximumLength(50);
            RuleFor(x => x.employmentStatus).NotEmpty().MaximumLength(20);
            RuleFor(x => x.hireDate).NotEmpty();
            RuleFor(x => x.profilePhoto).MaximumLength(255);
            RuleFor(x => x.assignedProperties).MaximumLength(500);
            RuleFor(x => x.images).MaximumLength(1000);
            RuleFor(x => x.createdBy).Length(36);
        }
    }

    public class CleanersUpdateDtoValidator : AbstractValidator<CleanersUpdateDto>
    {
        public CleanersUpdateDtoValidator()
        {
            RuleFor(x => x.staffID).NotEmpty().MaximumLength(10);
            RuleFor(x => x.firstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.middleName).MaximumLength(50);
            RuleFor(x => x.lastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.phoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.emailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.jobTitle).NotEmpty().MaximumLength(50);
            RuleFor(x => x.employmentStatus).NotEmpty().MaximumLength(20);
            RuleFor(x => x.hireDate).NotEmpty();
            RuleFor(x => x.profilePhoto).MaximumLength(255);
            RuleFor(x => x.assignedProperties).MaximumLength(500);
            RuleFor(x => x.images).MaximumLength(1000);
            RuleFor(x => x.modifiedBy).Length(36);
        }
    }
}