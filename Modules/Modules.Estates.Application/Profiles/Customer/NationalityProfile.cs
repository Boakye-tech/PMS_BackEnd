using System;
namespace Modules.Estates.Application.Profiles.Customer;

public class NationalityProfile : Profile
{
	public NationalityProfile()
	{
        CreateMap<Nationality, NationalityReadDto>();
        CreateMap<NationalityCreateDto, Nationality>();
        CreateMap<NationalityUpdateDto, Nationality>();
        CreateMap<NationalityDeleteDto, Nationality>();
    }
}

