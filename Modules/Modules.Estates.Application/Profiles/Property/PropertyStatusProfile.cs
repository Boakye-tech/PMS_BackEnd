// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/PropertyStatusProfile.cs
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
	public class PropertyStatusProfile : Profile
	{
		public PropertyStatusProfile()
		{
            CreateMap<PropertyStatus, PropertyStatusReadDto>();
            CreateMap<PropertyStatusCreateDto, PropertyStatus>();
            CreateMap<PropertyStatusUpdateDto, PropertyStatus>();
            //CreateMap<PropertyStatusDeleteDto, PropertyStatus>();

        }
    }
}

