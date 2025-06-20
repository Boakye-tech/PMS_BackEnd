// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interface/Setup/ICurrencyExchangeRateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface ICurrencyExchangeRateService
	{
        Task<ReturnResponsesDto> CreateCurrencyExchangeRateAsync(CurrencyExchangeRateCreateDto values);
        Task<ReturnResponsesDto> UpdateCurrencyExchangeRateAsync(CurrencyExchangeRateUpdateDto values);
        Task<ReturnResponsesDto> UpdateCurrencyDetailsAsync(CurrencyDetailsUpdateDto values);
        Task<IEnumerable<CurrencyExchangeRateReadDto>> GetCurrencyExchangeRateAsync();
        Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(int value);
        Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(string value);
        Task<ReturnResponsesDto> DeleteCurrencyExchangeRateAsync(int value);
    }
}

