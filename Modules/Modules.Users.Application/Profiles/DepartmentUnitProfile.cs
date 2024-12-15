using System;
namespace Modules.Users.Application.Profiles
{
	public class DepartmentUnitProfile : Profile
    {
		public DepartmentUnitProfile()
		{
            CreateMap<DepartmentUnit, DepartmentUnitReadDto>();
            CreateMap<DepartmentCreateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitUpdateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitDeleteDto, DepartmentUnit>();

        }
    }
}

