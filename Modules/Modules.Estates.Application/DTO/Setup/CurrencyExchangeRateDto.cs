// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/CurrencyExchangeRateDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/05/2025 2:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Setup
{
    public record CurrencyExchangeRateReadDto(int CurrencyId, string CurrencyInitial, string CurrencyName, decimal BuyingRate, decimal SellingRate, bool BaseCurrency, DateTime ApplicableDate);
    public record CurrencyExchangeRateCreateDto(string CurrencyInitial, string CurrencyName, decimal BuyingRate, decimal SellingRate, bool BaseCurrency, DateTime ApplicableDate, string CreatedBy);
    public record CurrencyExchangeRateUpdateDto(int CurrencyId, string CurrencyInitial, string CurrencyName, decimal BuyingRate, decimal SellingRate, DateTime ApplicableDate, bool BaseCurrency, string ModifiedBy);
    public record CurrencyExchangeRateDeleteDto(int CurrencyId);
}

