using System;
namespace Modules.Customers.Application.Profiles
{
	public class ComplaintProfile: Profile
	{
		public ComplaintProfile()
		{
			CreateMap<Complaint, ComplaintReadDto>();
            CreateMap<Complaint, ComplaintCreateDto>();
            CreateMap<ComplaintCreateDto, Complaint>();
        }
    }
}

