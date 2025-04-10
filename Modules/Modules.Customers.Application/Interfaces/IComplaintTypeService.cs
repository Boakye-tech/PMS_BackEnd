using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface IComplaintTypeService
	{
        Task<IEnumerable<ComplaintTypeDto>> GetComplaintTypes();
        Task<ComplaintTypeDto> AddNewComplaintType(ComplaintTypeDto values);
        Task<ComplaintTypeDto> UpdateComplaintType(ComplaintTypeDto values);
        Task<GenericResponseDto> DeleteComplaintType(int complaintTypeid);

    }
}

