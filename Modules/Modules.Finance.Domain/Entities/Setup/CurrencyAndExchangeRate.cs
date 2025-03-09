using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class CurrencyAndExchangeRate : AuditableEntity
    {
        [Key]
        [Required]
        public int CurrencyId { get; set; }

        [Required]
        [StringLength(5)]
        public string CurrencyInitial { get; set; }

        [Required]
        [StringLength(20)]
        public string CurrencyName { get; set; }

        [Required]
        public double BuyingRate { get; set; }

        [Required]
        public double SellingRate { get; set; }

        [Required]
        public bool BaseCurrency { get; set; }

        [Required]
        public DateTime ApplicableDate { get; set; }

        [Required]
        public short IsCurrent { get; set; }


        public CurrencyAndExchangeRate(int currencyId, string currencyInitial, string currencyName, double buyingRate, double sellingRate, bool baseCurrency, DateTime applicableDate, short isCurrent)
        {
            CurrencyId = currencyId;
            CurrencyInitial = currencyInitial;
            CurrencyName = currencyName;
            BuyingRate = buyingRate;
            SellingRate = sellingRate;
            BaseCurrency = baseCurrency;
            ApplicableDate = applicableDate;
            IsCurrent = isCurrent;
        }


        public static CurrencyAndExchangeRate CreateUpdate(int currencyId, string currencyInitial, string currencyName, double buyingRate, double sellingRate, bool baseCurrency, DateTime applicableDate, short isCurrent)
        {
            if (currencyId < 0 || string.IsNullOrWhiteSpace(currencyInitial) || string.IsNullOrWhiteSpace(currencyName) || buyingRate < 0 || sellingRate < 0)
            {
                throw new ArgumentException("Invalid currencies and exchange Data.");
            }

            if (string.IsNullOrWhiteSpace(currencyInitial) || currencyInitial.Length > 5)
                throw new ArgumentException("The currency initials must not be null or exceed 5 characters.");

            if (string.IsNullOrWhiteSpace(currencyName) || currencyName.Length > 20)
                throw new ArgumentException("The currency name must not be null or exceed 20 characters.");

            if (buyingRate <= 0)
                throw new ArgumentException("The buying rate must be greater than zero.");

            if (sellingRate <= 0)
                throw new ArgumentException("The selling rate must be greater than zero.");


            return new CurrencyAndExchangeRate(currencyId,  currencyInitial,  currencyName,  buyingRate,  sellingRate,  baseCurrency,  applicableDate, isCurrent);
        }

    }
}

