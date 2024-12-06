using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class BlockSideProfile : Profile
    {
		public BlockSideProfile()
		{
            CreateMap<BlockSides, BlockSideReadDto>();
            CreateMap<BlockSideCreateDto, BlockSides>();
            CreateMap<BlockSideUpdateDto, BlockSides>();
            CreateMap<BlockSideDeleteDto, BlockSides>();
        }
	}
}

