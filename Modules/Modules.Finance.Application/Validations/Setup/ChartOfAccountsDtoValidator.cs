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
	public class ChartOfAccountsDtoValidator: AbstractValidator<ChartOfAccountsCreateDto>
    {
		public ChartOfAccountsDtoValidator()
		{
            RuleFor(x => x.AccountCode).NotEmpty().LessThanOrEqualTo(0).WithMessage("The chart of account code must be greater than 0");
            RuleFor(x => x.AccountName).NotEmpty().Length(2, 50).WithMessage("The chart of account name must not be empty, null or exceed fifty(50) characters");

        }
    }
}

