// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/CurrencyExchangeRateDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup;

public record CurrencyExchangeRateReadDto(int CurrencyId, string CurrencyInitial, string CurrencyName, decimal BuyingRate, decimal SellingRate, bool BaseCurrency, DateTime ApplicableDate);
public record CurrencyExchangeRateCreateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, decimal BuyingRate, decimal SellingRate, bool BaseCurrency, DateTime ApplicableDate, string CreatedBy);
public record CurrencyDetailsUpdateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, bool BaseCurrency, string ModifiedBy);
public record CurrencyExchangeRateUpdateDto(int CurrencyId, decimal BuyingRate, decimal SellingRate, DateTime ApplicableDate, string ModifiedBy);
public record CurrencyExchangeRateDeleteDto(int CurrencyId);


public record CurrencyUpdateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, bool BaseCurrency, decimal BuyingRate, decimal SellingRate, DateTime ApplicableDate, string ModifiedBy);
