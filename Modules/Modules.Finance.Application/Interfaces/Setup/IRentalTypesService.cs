// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:40 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;


namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IRentalTypesService
    {
        Task<IEnumerable<RentalTypesReadDto>> GetRentalTypesAsync();
        Task<RentalTypesReadDto> GetRentalTypesAsync(int rentalTypesId);
        Task<ReturnResponsesDto> CreateRentalTypesAsync(RentalTypesCreateDto values);
        Task<ReturnResponsesDto> UpdateRentalTypesAsync(RentalTypesUpdateDto values);
        Task<ReturnResponsesDto> DeleteRentalTypesAsync(int rentalTypesId);


        Task<List<RentalAndDebtorTypesDto>> GetRentalAndDebtorTypesAsync();
    }
}
