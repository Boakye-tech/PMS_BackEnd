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
	public interface IComplaintTypeService
	{
        Task<ComplaintTypeReadDto> AddComplaintTypeAsync(ComplaintTypeCreateDto values);
        Task<string> DeleteComplaintTypeAsync(int value);
        Task<IEnumerable<ComplaintTypeReadDto>> GetComplaintTypeAsync();
        Task<ComplaintTypeReadDto> UpdateComplaintTypeAsync(ComplaintTypeUpdateDto values);
    }
}

