// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/SitesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 10:06 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class SitesProfile : Profile
	{
		public SitesProfile()
		{
            CreateMap<Sites, SitesReadDto>();
            CreateMap<SitesCreateDto, Sites>();
            CreateMap<SitesUpdateDto, Sites>();
            CreateMap<SitesDeleteDto, Sites>();

        }
    }
}

