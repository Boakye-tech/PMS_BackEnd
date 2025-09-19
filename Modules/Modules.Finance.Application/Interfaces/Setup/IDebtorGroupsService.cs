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
    public interface IDebtorGroupsService
    {
        Task<IEnumerable<DebtorGroupsReadDto>> GetDebtorGroupsAsync();
        Task<DebtorGroupsReadDto> GetDebtorGroupsAsync(int debtorGroupsId);
        Task<ReturnResponsesDto> CreateDebtorGroupsAsync(DebtorGroupsCreateDto values);
        Task<ReturnResponsesDto> UpdateDebtorGroupsAsync(DebtorGroupsUpdateDto values);
        Task<ReturnResponsesDto> DeleteDebtorGroupsAsync(int debtorGroupsId);
    }
}
