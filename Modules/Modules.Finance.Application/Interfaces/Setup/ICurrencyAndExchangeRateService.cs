// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface ICurrencyAndExchangeRateService
	{
        Task<CurrencyAndExchangeRateReadDto> AddCurrencyAndExchangeRateAsync(CurrencyAndExchangeRateCreateDto values);
        Task<CurrencyAndExchangeRateReadDto> UpdateCurrencyAndExchangeRateAsync(CurrencyAndExchangeRateUpdateDto values);
        Task<IEnumerable<CurrencyAndExchangeRateReadDto>> GetCurrencyAndExchangeRateAsync();
        Task<CurrencyAndExchangeRateReadDto> GetCurrencyAndExchangeRateAsync(int value);
        Task<CurrencyAndExchangeRateReadDto> GetCurrencyAndExchangeRateAsync(string value);
    }
}

