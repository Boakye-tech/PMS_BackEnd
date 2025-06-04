// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockUnitProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

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

