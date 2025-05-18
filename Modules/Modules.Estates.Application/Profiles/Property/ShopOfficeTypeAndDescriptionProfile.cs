// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ShopOfficeTypeAndDescriptionProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:49 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class ShopOfficeTypeAndDescriptionProfile : Profile
	{
		public ShopOfficeTypeAndDescriptionProfile()
		{
            CreateMap<ShopOfficeTypeAndDescription, ShopOfficeTypeAndDescriptionReadDto>();
            CreateMap<ShopOfficeTypeAndDescriptionCreateDto, ShopOfficeTypeAndDescription>();
            CreateMap<ShopOfficeTypeAndDescriptionUpdateDto, ShopOfficeTypeAndDescription>();
            //CreateMap<ShopOfficeTypeAndDescriptionDeleteDto, ShopOfficeTypeAndDescription>();

        }
    }
}

