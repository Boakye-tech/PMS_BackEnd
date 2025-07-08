// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/DepartmentProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/07/2025 5:44 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class DepartmentProfile : Profile
    {
		public DepartmentProfile()
		{
            CreateMap<Department, DepartmentReadDto>();
            CreateMap<DepartmentCreateDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();
            CreateMap<DepartmentDeleteDto, Department>();

        }
    }
}

