using System;

namespace Modules.Users.Application.Profiles
{
	public class ApplicationModulesProfile : Profile
    {
		public ApplicationModulesProfile()
		{
			CreateMap<ApplicationModules, ApplicationModulesDto>();
            CreateMap<ApplicationModulesDto, ApplicationModules>();

        }
    }
}

