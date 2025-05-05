// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record CurrencyAndExchangeRateReadDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent);
public record CurrencyAndExchangeRateCreateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent, string CreatedBy);
public record CurrencyAndExchangeRateUpdateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent, string ModifiedBy);
public record CurrencyAndExchangeRateDeleteDto(int CurrencyId);


