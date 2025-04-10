using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class ComplaintTypeProfile : Profile
    {
		public ComplaintTypeProfile()
		{
			CreateMap<ComplaintType, ComplaintTypeReadDto>();
            CreateMap<ComplaintTypeCreateDto, ComplaintType>();
            CreateMap<ComplaintTypeUpdateDto, ComplaintType>();
            CreateMap<ComplaintTypeDeleteDto, ComplaintType>();
        }
	}
}

