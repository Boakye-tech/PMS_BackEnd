using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface INatureOfComplaintService
	{
        Task<IEnumerable<NatureOfComplaintDto>> GetNatureOfComplaints();
        Task<IEnumerable<NatureOfComplaintDto>> GetNatureOfComplaints(int complaintTypeId);

        Task<NatureOfComplaintDto> AddNewNatureOfComplaint(NatureOfComplaintDto values);
        Task<NatureOfComplaintDto> UpdateNatureOfComplaint(NatureOfComplaintDto values);
        Task<GenericResponseDto> DeleteNatureOfComplaint(int natureOfComplaintId);

    }
}

