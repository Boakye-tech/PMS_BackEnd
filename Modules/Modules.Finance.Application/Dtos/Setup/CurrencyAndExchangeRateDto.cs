using System;
namespace Modules.Finance.Application.Dtos.Setup;

public record CurrencyAndExchangeRateReadDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent);
public record CurrencyAndExchangeRateCreateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent, string CreatedBy);
public record CurrencyAndExchangeRateUpdateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, double BuyingRate, double SellingRate, bool BaseCurrency, DateTime ApplicableDate, short IsCurrent, string ModifiedBy);
public record CurrencyAndExchangeRateDeleteDto(int CurrencyId);


