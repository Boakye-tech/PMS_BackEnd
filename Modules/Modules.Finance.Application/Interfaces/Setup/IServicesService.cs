// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 5:00 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;


namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IServicesService
    {
        Task<IEnumerable<ServicesReadDto>> GetServicesAsync();
        Task<ServicesReadDto> GetServicesAsync(int servicesId);
        Task<ReturnResponsesDto> CreateServicesAsync(ServicesCreateDto values);
        Task<ReturnResponsesDto> UpdateServicesAsync(ServicesUpdateDto values);
        Task<ReturnResponsesDto> DeleteServicesAsync(int servicesId);
    }
}
