// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

