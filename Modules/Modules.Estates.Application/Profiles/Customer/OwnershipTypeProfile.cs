using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class OwnershipTypeProfile : Profile
	{
		public OwnershipTypeProfile()
		{
            CreateMap<OwnershipType, OwnershipTypeReadDto>();
            CreateMap<OwnershipTypeCreateDto, OwnershipType>();
            CreateMap<OwnershipTypeUpdateDto, OwnershipType>();
            CreateMap<OwnershipTypeDeleteDto, OwnershipType>();
        }
	}
}

