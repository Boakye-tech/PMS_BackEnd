using System;
namespace Modules.Customers.Application.Profiles
{
	public class ComplaintStatusProfile : Profile
    {
		public ComplaintStatusProfile()
		{
            CreateMap<ComplaintStatuses, ComplaintStatusesReadDto>();
            CreateMap<ComplaintStatusesCreateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesUpdateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesDeleteDto, ComplaintStatuses>();
        }
	}
}

