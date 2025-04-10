using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class NatureOfComplaintProfile : Profile
    {
		public NatureOfComplaintProfile()
		{
            CreateMap<NatureOfComplaint, NatureOfComplaintReadDto>();
            CreateMap<NatureOfComplaintCreateDto, NatureOfComplaint>();
            CreateMap<NatureOfComplaintUpdateDto, NatureOfComplaint>();
            CreateMap<NatureOfComplaintDeleteDto, NatureOfComplaint>();
        }
	}
}

