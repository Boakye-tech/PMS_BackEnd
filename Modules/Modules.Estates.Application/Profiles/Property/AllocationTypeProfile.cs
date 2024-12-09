using System;
namespace Modules.Estates.Application.Profiles.Property;

public class AllocationTypeProfile : Profile
{
	public AllocationTypeProfile()
	{
        CreateMap<AllocationType, AllocationTypeReadDto>();

        CreateMap<AllocationTypeCreateDto, AllocationType>();
        CreateMap<AllocationTypeUpdateDto, AllocationType>();
        CreateMap<AllocationTypeDeleteDto, AllocationType>();
    }
}

