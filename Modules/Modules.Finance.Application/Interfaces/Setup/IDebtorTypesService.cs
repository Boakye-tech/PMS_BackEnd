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
    public interface IDebtorTypesService
    {
        Task<IEnumerable<DebtorTypesReadDto>> GetDebtorTypesAsync();
        Task<DebtorTypesReadDto> GetDebtorTypesAsync(int debtorTypesId);
        Task<ReturnResponsesDto> CreateDebtorTypesAsync(DebtorTypesCreateDto values);
        Task<ReturnResponsesDto> UpdateDebtorTypesAsync(DebtorTypesUpdateDto values);
        Task<ReturnResponsesDto> DeleteDebtorTypesAsync(int debtorTypesId);
    }
}
