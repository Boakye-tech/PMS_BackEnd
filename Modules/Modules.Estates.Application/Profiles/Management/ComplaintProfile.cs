using System;
namespace Modules.Estates.Application.Profiles.Management
{
	public class ComplaintProfile : Profile
	{
		public ComplaintProfile()
		{
			CreateMap<Complaint, ComplaintReadDto>();
            CreateMap<Complaint, ComplaintCreateDto>();
            CreateMap<ComplaintCreateDto, Complaint>();

            //CreateMap<>();
            //CreateMap<>();

        }
    }
}

