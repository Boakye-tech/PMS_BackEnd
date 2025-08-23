// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Management/PropertyLeaseDetailsProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/07/2025 11:17 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Profiles.Management
{
	public class PropertyLeaseDetailsProfile : Profile
	{
		public PropertyLeaseDetailsProfile()
		{
			CreateMap<PropertyLeaseDetails, PropertyLeaseDetailsReadDto>();
            CreateMap<PropertyLeaseDetailsCreateDto, PropertyLeaseDetails>();
            CreateMap<PropertyLeaseDetailsUpdateDto, PropertyLeaseDetails>();
        }

	}
}

