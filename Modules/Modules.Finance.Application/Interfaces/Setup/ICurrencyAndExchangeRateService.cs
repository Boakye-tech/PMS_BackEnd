using System;
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

