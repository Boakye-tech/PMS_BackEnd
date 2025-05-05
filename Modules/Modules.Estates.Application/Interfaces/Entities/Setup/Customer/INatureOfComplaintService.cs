// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface INatureOfComplaintService
	{
        Task<NatureOfComplaintReadDto> AddNatureOfComplaintAsync(NatureOfComplaintCreateDto values);
        Task<NatureOfComplaintReadDto> UpdateNatureOfComplaintAsync(NatureOfComplaintUpdateDto values);
        Task<string> DeleteNatureOfComplaintAsync(int value);
        Task<IEnumerable<NatureOfComplaintReadDto>> GetNatureOfComplaintAsync();
        Task<IEnumerable<NatureOfComplaintReadDto>> GetNatureOfComplaintAsync(int complaintTypeId);
    }
}

