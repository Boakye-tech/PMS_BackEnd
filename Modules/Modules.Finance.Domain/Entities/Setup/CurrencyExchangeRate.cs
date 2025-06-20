// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/CurrencyExchangeRate.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 18/05/2025 5:05 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class CurrencyExchangeRate : AuditableEntity
    {
        [Key]
        [Required]
        public int CurrencyId { get; private set; }

        [Required]
        [StringLength(5)]
        public string? CurrencyInitial { get; private set; }

        [Required]
        [StringLength(20)]
        public string? CurrencyName { get; private set; }

        [Required]
        public decimal BuyingRate { get; private set; }

        [Required]
        public decimal SellingRate { get; private set; }

        [Required]
        public bool BaseCurrency { get; private set; }

        [Required]
        public DateTime ApplicableDate { get; private set; }

     
        // Private constructor for EF Core
        public CurrencyExchangeRate() { }

        public CurrencyExchangeRate(int currencyId, string currencyInitial, string currencyName, decimal buyingRate, decimal sellingRate, bool baseCurrency, DateTime applicableDate)
        {
            CurrencyId = currencyId;
            CurrencyInitial = currencyInitial;
            CurrencyName = currencyName;
            BuyingRate = buyingRate;
            SellingRate = sellingRate;
            BaseCurrency = baseCurrency;
            ApplicableDate = applicableDate;
        }

        public static CurrencyExchangeRate Create(int currencyId, string currencyInitial, string currencyName, decimal buyingRate, decimal sellingRate, bool baseCurrency, DateTime applicableDate)
        {
            Validate(currencyId, currencyInitial, currencyName, buyingRate, sellingRate, applicableDate);

            return new CurrencyExchangeRate(currencyId, currencyInitial, currencyName, buyingRate, sellingRate, baseCurrency, applicableDate);
        }

        public void UpdateExchangeRate(int currencyId,decimal newBuyingRate, decimal newSellingRate, DateTime newApplicableDate)
        {
            if (currencyId <= 0)
                throw new ArgumentException("The currency id must be greater than zero.");

            if (newBuyingRate <= 0)
                throw new ArgumentException("The buying rate must be greater than zero.");

            if (newSellingRate <= 0)
                throw new ArgumentException("The selling rate must be greater than zero.");

            if (newApplicableDate.Date < ApplicableDate.Date)
                throw new ArgumentException("New applicable date cannot be earlier than the current date.");

            // Archive current rates before updating
            // ArchiveCurrentRates();

            // Update current rates
            BuyingRate = newBuyingRate;
            SellingRate = newSellingRate;
            ApplicableDate = newApplicableDate;
        }

        public void UpdateCurrencyDetails(int currencyId,string currencyInitial, string currencyName, bool baseCurrency)
        {
            if (currencyId <= 0)
                throw new ArgumentException("The currency id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(currencyInitial) || currencyInitial.Length > 5)
                throw new ArgumentException("The currency initials must not be null or exceed 5 characters.");

            if (string.IsNullOrWhiteSpace(currencyName) || currencyName.Length > 20)
                throw new ArgumentException("The currency name must not be null or exceed 20 characters.");

            CurrencyInitial = currencyInitial;
            CurrencyName = currencyName;
            BaseCurrency = baseCurrency;
        }

        // private void ArchiveCurrentRates()
        // {
        //     var historicalRate = new CurrencyExchangeRateHistory(
        //         CurrencyId,
        //         BuyingRate,
        //         SellingRate,
        //         ApplicableDate,
        //         CreatedBy,
        //         CreatedOn
        //     );

        //     ExchangeRateHistory.Add(historicalRate);
        // }

        private static void Validate(int currencyId, string currencyInitial, string currencyName,decimal buyingRate, decimal sellingRate, DateTime applicableDate)
        {
            if (currencyId < 0)
                throw new ArgumentException("Currency ID must be greater than zero.");

            if (string.IsNullOrWhiteSpace(currencyInitial) || currencyInitial.Length > 5)
                throw new ArgumentException("The currency initials must not be null or exceed 5 characters.");

            if (string.IsNullOrWhiteSpace(currencyName) || currencyName.Length > 20)
                throw new ArgumentException("The currency name must not be null or exceed 20 characters.");

            if (buyingRate <= 0)
                throw new ArgumentException("The buying rate must be greater than zero.");

            if (sellingRate <= 0)
                throw new ArgumentException("The selling rate must be greater than zero.");

            if (applicableDate.Date < DateTime.Today)
                throw new ArgumentException("Applicable date cannot be in the past.");
        }
    }

   
}

