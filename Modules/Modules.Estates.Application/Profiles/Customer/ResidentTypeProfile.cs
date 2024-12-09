using System;
namespace Modules.Estates.Application.Profiles.Customer;

public class ResidentTypeProfile : Profile
{
	public ResidentTypeProfile()
	{
        CreateMap<ResidentType, ResidentTypeReadDto>();
        CreateMap<ResidentTypeCreateDto, ResidentType>();
        CreateMap<ResidentTypeUpdateDto, ResidentType>();
        CreateMap<ResidentTypeDeleteDto, ResidentType>();
    }
}

