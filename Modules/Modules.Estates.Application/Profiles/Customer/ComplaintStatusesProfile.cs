using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class ComplaintStatusesProfile : Profile
	{
		public ComplaintStatusesProfile()
		{
            CreateMap<ComplaintStatuses, ComplaintStatusesReadDto>();
            CreateMap<ComplaintStatusesCreateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesUpdateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesDeleteDto, ComplaintStatuses>();
        }
    }
}

