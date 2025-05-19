// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/ICurrencyExchangeRateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/05/2025 2:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup
{
	public interface ICurrencyExchangeRateService
	{
        Task<ReturnResponsesDto> CreateCurrencyExchangeRateAsync(CurrencyExchangeRateCreateDto values);
        Task<ReturnResponsesDto> UpdateCurrencyExchangeRateAsync(CurrencyExchangeRateUpdateDto values);
        Task<IEnumerable<CurrencyExchangeRateReadDto>> GetCurrencyExchangeRateAsync();
        Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(int value);
        Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(string value);
        Task<ReturnResponsesDto> DeleteCurrencyExchangeRateAsync(int value);

    }
}

