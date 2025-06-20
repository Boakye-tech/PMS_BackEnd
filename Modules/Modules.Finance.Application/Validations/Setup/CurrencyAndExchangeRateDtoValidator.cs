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
	public class CurrencyExchangeRateDtoValidator : AbstractValidator<CurrencyExchangeRateCreateDto>
    {
		public CurrencyExchangeRateDtoValidator()
		{
            //RuleFor(x => x.CurrencyId).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(x => x.CurrencyInitial).NotEmpty().Length(1, 5).WithMessage("The currency initials must not be empty, null or exceed five(5) characters");
            RuleFor(x => x.CurrencyName).NotEmpty().Length(2, 20).WithMessage("The currency name must not be empty, null or exceed twenty(20) characters");
            RuleFor(x => x.BuyingRate).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The buying rate must be greater than 0");
            RuleFor(x => x.SellingRate).NotEmpty().GreaterThanOrEqualTo(0).WithMessage("The selling rate must be greater than 0");

        }
    }
}

