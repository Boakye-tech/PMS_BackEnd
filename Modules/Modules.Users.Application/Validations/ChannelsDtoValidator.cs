using System;

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

