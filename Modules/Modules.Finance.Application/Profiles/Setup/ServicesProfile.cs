// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/ServicesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 10:17 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class ServicesProfile : Profile
	{
		public ServicesProfile()
		{
            CreateMap<Services, ServicesReadDto>();
            CreateMap<ServicesCreateDto, Services>();
            CreateMap<ServicesUpdateDto, Services>();
            CreateMap<ServicesDeleteDto, Services>();

        }
    }
}

