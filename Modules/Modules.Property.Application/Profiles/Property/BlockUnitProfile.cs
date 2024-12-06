using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class BlockUnitProfile : Profile
	{
		public BlockUnitProfile()
		{
            CreateMap<BlockUnit, BlockUnitReadDto>();
            CreateMap<BlockUnitCreateDto, BlockUnit>();
            CreateMap<BlockUnitUpdateDto, BlockUnit>();
            CreateMap<BlockUnitDeleteDto, BlockUnit>();
        }
	}
}

