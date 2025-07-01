// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Validations/Setup/SuppliersDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Validations.Setup
{
    public class SuppliersDtoValidator : AbstractValidator<SuppliersCreateDto>
    {
        public SuppliersDtoValidator()
        {
            RuleFor(x => x.supplierName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.phoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.emailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.companyRegistrationNumber).MaximumLength(50);
            RuleFor(x => x.tinNumber).MaximumLength(50);
            RuleFor(x => x.companyAddress).MaximumLength(200);
            RuleFor(x => x.digitalAddress).MaximumLength(50);
            RuleFor(x => x.images).MaximumLength(1000);
            RuleFor(x => x.contactPerson_FirstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.contactPerson_MiddleName).MaximumLength(50);
            RuleFor(x => x.contactPerson_LastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.contactPerson_JobTitle).MaximumLength(50);
            RuleFor(x => x.contactPerson_PhoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.contactPerson_EmailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.createdBy).Length(36);
        }
    }

    public class SuppliersUpdateDtoValidator : AbstractValidator<SuppliersUpdateDto>
    {
        public SuppliersUpdateDtoValidator()
        {
            RuleFor(x => x.supplierID).GreaterThanOrEqualTo(0);
            RuleFor(x => x.supplierName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.phoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.emailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.companyRegistrationNumber).MaximumLength(50);
            RuleFor(x => x.tinNumber).MaximumLength(50);
            RuleFor(x => x.companyAddress).MaximumLength(200);
            RuleFor(x => x.digitalAddress).MaximumLength(50);
            RuleFor(x => x.images).MaximumLength(1000);
            RuleFor(x => x.contactPerson_FirstName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.contactPerson_MiddleName).MaximumLength(50);
            RuleFor(x => x.contactPerson_LastName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.contactPerson_JobTitle).MaximumLength(50);
            RuleFor(x => x.contactPerson_PhoneNumber).NotEmpty().MaximumLength(15);
            RuleFor(x => x.contactPerson_EmailAddress).NotEmpty().MaximumLength(100).EmailAddress();
            RuleFor(x => x.modifiedBy).Length(36);
        }
    }
}