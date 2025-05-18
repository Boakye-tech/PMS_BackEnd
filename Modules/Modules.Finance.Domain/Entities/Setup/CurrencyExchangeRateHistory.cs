// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/CurrencyExchangeRateHistory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 18/05/2025 5:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
    // Historical record of exchange rates
    public class CurrencyExchangeRateHistory : AuditableEntity
    {
        [Key]
        public int HistoryId { get; private set; }

        [Required]
        public int CurrencyId { get; private set; }

        [Required]
        public string? CurrencyInitial { get; private set; }

        [Required]
        public string? CurrencyName { get; private set; }

        [Required]
        public decimal BuyingRate { get; private set; }

        [Required]
        public decimal SellingRate { get; private set; }

        [Required]
        public DateTime ApplicableDate { get; private set; }

       

        private CurrencyExchangeRateHistory() { }

        public CurrencyExchangeRateHistory(int currencyId, string currencyInitial, string currencyName, decimal buyingRate, decimal sellingRate, DateTime applicableDate, string actionBy, DateTime actionOn)
        {
            CurrencyId = currencyId;
            CurrencyInitial = currencyInitial;
            CurrencyName = currencyName;
            BuyingRate = buyingRate;
            SellingRate = sellingRate;
            ApplicableDate = applicableDate;
            CreatedBy = actionBy;
            CreatedOn = actionOn;
        }
    }
}

