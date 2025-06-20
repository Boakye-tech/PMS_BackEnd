// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/LeaseTypeAndPeriodProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class LeaseTypeAndPeriodProfile : Profile
	{
		public LeaseTypeAndPeriodProfile()
		{
            CreateMap<LeaseTypeAndPeriod, LeaseTypeAndPeriodReadDto>();
            CreateMap<LeaseTypeAndPeriodCreateDto, LeaseTypeAndPeriod>();
            CreateMap<LeaseTypeAndPeriodUpdateDto, LeaseTypeAndPeriod>();
            //CreateMap<LeaseTypeAndPeriodDeleteDto, LeaseTypeAndPeriod>();

        }
    }
}

