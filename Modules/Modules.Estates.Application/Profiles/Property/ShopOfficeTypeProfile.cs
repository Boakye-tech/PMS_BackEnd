// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ShopOfficeTypesProfile.cs
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
	public class ShopOfficeTypesProfile : Profile
	{
		public ShopOfficeTypesProfile()
		{
            CreateMap<ShopOfficeTypes, ShopOfficeTypesReadDto>();
            CreateMap<ShopOfficeTypesCreateDto, ShopOfficeTypes>();
            CreateMap<ShopOfficeTypesUpdateDto, ShopOfficeTypes>();
            //CreateMap<ShopOfficeTypesDeleteDto, ShopOfficeTypes>();

        }
    }
}

