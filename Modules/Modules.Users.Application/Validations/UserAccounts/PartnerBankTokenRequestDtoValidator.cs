// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Validations.UserAccounts
{
    public class PartnerBankTokenRequestDtoValidator : AbstractValidator<PartnerBankTokenRequestDto>
    {
        public PartnerBankTokenRequestDtoValidator()
        {
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress().Matches(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");

        }
    }
}

