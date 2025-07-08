// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/DepartmentUnitProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/07/2025 5:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class DepartmentUnitProfile : Profile
    {
		public DepartmentUnitProfile()
		{
            CreateMap<DepartmentUnit, DepartmentUnitReadDto>();
            CreateMap<DepartmentUnitCreateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitUpdateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitDeleteDto, DepartmentUnit>();

        }
    }
}

