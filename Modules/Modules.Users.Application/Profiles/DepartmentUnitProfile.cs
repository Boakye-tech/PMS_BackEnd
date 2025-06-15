// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Profiles
{
	public class DepartmentUnitProfile : Profile
    {
		public DepartmentUnitProfile()
		{
            CreateMap<DepartmentUnit, UnitReadDto>();
            CreateMap<DepartmentUnit, DepartmentsUnitsReadDto>();
            

            CreateMap<DepartmentUnit, DepartmentUnitReadDto>();
            CreateMap<DepartmentUnitCreateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitUpdateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitDeleteDto, DepartmentUnit>();

        }
    }
}

