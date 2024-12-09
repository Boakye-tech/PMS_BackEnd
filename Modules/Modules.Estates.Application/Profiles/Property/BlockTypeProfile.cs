using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class BlockTypeProfile : Profile
    {
		public BlockTypeProfile()
		{
            CreateMap<BlockTypes, BlockTypeReadDto>();
            CreateMap<BlockTypeCreateDto, BlockTypes>();
            CreateMap<BlockTypeUpdateDto, BlockTypes>();
            CreateMap<BlockTypeDeleteDto, BlockTypes>();
        }
	}
}

