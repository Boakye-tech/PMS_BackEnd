using System;
namespace Modules.Users.Application.Profiles
{
	public class IdentificationTypeProfile : Profile
    {
        public IdentificationTypeProfile()
        {
            CreateMap<IdentificationType, IdentificationTypeDto>();
            CreateMap<IdentificationTypeDto, IdentificationType>();

            //CreateMap<IdentificationTypeUpdateDto, IdentificationType>();
            //CreateMap<IdentificationTypeDeleteDto, IdentificationType>();
        }
    }
}

