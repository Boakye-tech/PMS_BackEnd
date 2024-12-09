using System;
namespace Modules.Estates.Application.Profiles.Customer;

public class Nationality : Profile
{
	public Nationality()
	{
        CreateMap<Nationality, NationalityReadDto>();
        CreateMap<NationalityCreateDto, Nationality>();
        CreateMap<NationalityUpdateDto, Nationality>();
        CreateMap<NationalityDeleteDto, Nationality>();
    }
}

