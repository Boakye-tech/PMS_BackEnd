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
	public class PayPointDtoValidator : AbstractValidator<PaypointsCreateDto>
    {
		public PayPointDtoValidator()
		{
            RuleFor(x => x.PaypointId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Paypoint).NotEmpty().Length(2, 30).WithMessage("The pay point name must not be empty, null or exceed thirty(30) characters");
        }
	}
}

