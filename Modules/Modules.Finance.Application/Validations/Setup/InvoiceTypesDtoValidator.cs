// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using FluentValidation;

namespace Modules.Finance.Application.Validations.Setup
{
	public class InvoiceTypesDtoValidator: AbstractValidator<InvoiceTypesCreateDto>
    {
		public InvoiceTypesDtoValidator()
		{
            RuleFor(x => x.InvoiceName).NotEmpty().Length(20, 100).WithMessage("The invoice name must not be empty, null or less than twenty(20) characters or exceed one hundred(100) characters");
            //RuleFor(x => x.InvoiceDescriptions).NotEmpty().Length(3, 75).WithMessage("The invoice initials must not be empty, null or exceed seventy-five(75) characters");


            RuleFor(x => x.DepartmentId).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The invoice department must be greater than 0");
            RuleFor(x => x.RoomNumber).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The invoice room number must be greater than 0");
            RuleFor(x => x.PaymentTermsId).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The invoice payment terms must be greater than 0");
        }
    }
}

