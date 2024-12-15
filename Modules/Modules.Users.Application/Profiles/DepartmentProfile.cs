using System;

namespace Modules.Users.Application.Profiles
{
	public class DepartmentProfile : Profile
    {
		public DepartmentProfile()
		{
			CreateMap<Department, DepartmentReadDto>();
            CreateMap<DepartmentUnitCreateDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();
            CreateMap<DepartmentDeleteDto, Department>();

        }
    }
}

