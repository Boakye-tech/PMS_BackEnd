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
	public class FormsDtoValidator: AbstractValidator<FormsCreateDto>
    {
		public FormsDtoValidator()
		{
            RuleFor(x => x.FormCode).NotEmpty();
            RuleFor(x => x.FormName).NotEmpty().Length(2, 30).WithMessage("The pay point name must not be empty, null or exceed thirty(30) characters");
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The amount must be greater than 0");
            RuleFor(x => x.AccountCode).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The account code must be greater than 0");
        }
    }
}

