using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class BlockNumberProfile : Profile
    {
		public BlockNumberProfile()
		{
            CreateMap<BlockNumber, BlockNumberReadDto>();
            CreateMap<BlockNumberCreateDto, BlockNumber>();
            CreateMap<BlockNumberUpdateDto, BlockNumber>();
            CreateMap<BlockNumberDeleteDto, BlockNumber>();
        }
	}
}

