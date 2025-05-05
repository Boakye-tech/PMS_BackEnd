// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Validations
{
	public class ChannelsDtoValidator : AbstractValidator<ChannelCreateDto>
    {
		public ChannelsDtoValidator()
		{
            RuleFor(x => x.ChannelId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.ChannelName).NotEmpty().Length(2, 50).WithMessage("The channel name must not be empty, null or exceed twenty(20) characters");

        }
    }
}

