using System;
namespace Modules.Users.Application.Profiles
{
	public class DepartmentUnitProfile : Profile
    {
		public DepartmentUnitProfile()
		{
            CreateMap<DepartmentUnit, UnitReadDto>();

            CreateMap<DepartmentUnit, DepartmentUnitReadDto>();
            CreateMap<DepartmentUnitCreateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitUpdateDto, DepartmentUnit>();
            CreateMap<DepartmentUnitDeleteDto, DepartmentUnit>();

        }
    }
}

