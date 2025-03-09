using System;
namespace Modules.Estates.Application.Profiles.Customer;

public class IdentificationTypeProfile : Profile
{
	public IdentificationTypeProfile()
	{
        CreateMap<IdentificationType, IdentificationTypeReadDto>();
        CreateMap<IdentificationTypeCreateDto, IdentificationType>();
        CreateMap<IdentificationTypeUpdateDto, IdentificationType>();
        CreateMap<IdentificationTypeDeleteDto, IdentificationType>();
    }
}

