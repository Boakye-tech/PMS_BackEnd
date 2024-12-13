using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class FormProfile : Profile
	{
		public FormProfile()
		{
            CreateMap<Forms, FormsReadDto>();
            CreateMap<FormsCreateDto, Forms>();
            CreateMap<FormsUpdateDto, Forms>();
            CreateMap<FormsDeleteDto, Forms>();

        }
    }
}

