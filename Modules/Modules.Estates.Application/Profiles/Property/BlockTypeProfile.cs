// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockTypeProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

