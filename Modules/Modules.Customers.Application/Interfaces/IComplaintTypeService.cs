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
	public interface IComplaintTypeService
	{
        Task<IEnumerable<ComplaintTypeDto>> GetComplaintTypes();
        Task<ComplaintTypeDto> AddNewComplaintType(ComplaintTypeDto values);
        Task<ComplaintTypeDto> UpdateComplaintType(ComplaintTypeDto values);
        Task<GenericResponseDto> DeleteComplaintType(int complaintTypeid);

    }
}

