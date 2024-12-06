using System;
namespace Modules.Estates.Application.Profiles.Customer;

public class GenderProfile : Profile
{
	public GenderProfile()
	{
        CreateMap<Gender, GenderReadDto>();
        CreateMap<GenderCreateDto, Gender>();
        CreateMap<GenderUpdateDto, Gender>();
        CreateMap<GenderDeleteDto, Gender>();
    }
}

