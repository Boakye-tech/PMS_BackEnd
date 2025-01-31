using System;

namespace Modules.Users.Application.Profiles
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

