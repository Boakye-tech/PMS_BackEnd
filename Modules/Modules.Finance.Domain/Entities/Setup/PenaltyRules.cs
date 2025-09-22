// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PenaltyRule.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 2:19 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Finance.Domain.Enums;

namespace Modules.Finance.Domain.Entities.Setup
{
    public class PenaltyRule : AuditableEntity
    {
        public int PenaltyRuleId { get; private set; }
        public int PenaltyTypeId { get; private set; }
        public PenaltyCalculationMethod CalculationMethod { get; private set; }
        public decimal Rate { get; private set; }
        public int GracePeriodDays { get; private set; }
        public decimal? CapAmount { get; private set; }
        public DateTime EffectiveDate { get; private set; }
        public DateTime? ExpiryDate { get; private set; }

        // Navigation properties
        public virtual PenaltyType PenaltyType { get; private set; } = null!;

        // Private constructor for EF Core
        private PenaltyRule() { }

        public PenaltyRule(int penaltyTypeId, PenaltyCalculationMethod calculationMethod, decimal rate,
                          int gracePeriodDays, decimal? capAmount, DateTime effectiveDate, DateTime? expiryDate)
        {
            Validate(penaltyTypeId, calculationMethod, rate, gracePeriodDays, capAmount, effectiveDate, expiryDate);

            PenaltyTypeId = penaltyTypeId;
            CalculationMethod = calculationMethod;
            Rate = rate;
            GracePeriodDays = gracePeriodDays;
            CapAmount = capAmount;
            EffectiveDate = effectiveDate;
            ExpiryDate = expiryDate;
        }

        public static PenaltyRule Create(int penaltyTypeId, PenaltyCalculationMethod calculationMethod, decimal rate,
                                        int gracePeriodDays, decimal? capAmount, DateTime effectiveDate, DateTime? expiryDate)
        {
            Validate(penaltyTypeId, calculationMethod, rate, gracePeriodDays, capAmount, effectiveDate, expiryDate);
            return new PenaltyRule(penaltyTypeId, calculationMethod, rate, gracePeriodDays, capAmount, effectiveDate, expiryDate);
        }

        public void Update(PenaltyCalculationMethod calculationMethod, decimal rate, int gracePeriodDays,
                          decimal? capAmount, DateTime effectiveDate, DateTime? expiryDate)
        {
            Validate(PenaltyTypeId, calculationMethod, rate, gracePeriodDays, capAmount, effectiveDate, expiryDate);

            CalculationMethod = calculationMethod;
            Rate = rate;
            GracePeriodDays = gracePeriodDays;
            CapAmount = capAmount;
            EffectiveDate = effectiveDate;
            ExpiryDate = expiryDate;
        }

        public bool IsActive()
        {
            var now = DateTime.Now;
            return EffectiveDate <= now && (ExpiryDate == null || now <= ExpiryDate);
        }

        public decimal CalculatePenalty(decimal principalAmount, int daysLate)
        {
            if (daysLate <= GracePeriodDays) return 0;

            var penaltyPeriods = CalculatePenaltyPeriods(daysLate);
            decimal penalty = Rate * penaltyPeriods;

            if (CapAmount.HasValue && penalty > CapAmount.Value)
            {
                penalty = CapAmount.Value;
            }

            return penalty;
        }

        public decimal CalculatePenalty(DateTime dueDate, DateTime paymentDate)
        {
            if (dueDate > paymentDate) return 0; // Payment is early or on time

            var daysLate = (paymentDate - dueDate).Days;
            return CalculatePenalty(0, daysLate); // Principal amount not needed for non-percentage methods
        }

        public decimal CalculatePenalty(decimal principalAmount, DateTime dueDate, DateTime paymentDate)
        {
            if (dueDate > paymentDate) return 0; // Payment is early or on time

            var daysLate = (paymentDate - dueDate).Days;
            return CalculatePenalty(principalAmount, daysLate);
        }

        private decimal CalculatePenaltyPeriods(int daysLate)
        {
            var effectiveDays = daysLate - GracePeriodDays;

            return CalculationMethod switch
            {
                PenaltyCalculationMethod.Percentage =>
                    throw new InvalidOperationException("Percentage method requires principal amount. Use CalculatePenalty(decimal principalAmount, int daysLate) instead."),

                PenaltyCalculationMethod.FlatRate => 1, // Flat rate is applied once regardless of days

                PenaltyCalculationMethod.DailyRate => effectiveDays, // Number of days

                PenaltyCalculationMethod.MonthlyRate => Math.Ceiling(effectiveDays / 30.0m), // Number of months (30 days per month)

                PenaltyCalculationMethod.YearlyRate => Math.Ceiling(effectiveDays / 365.0m), // Number of years (365 days per year)

                _ => throw new ArgumentException("Invalid calculation method")
            };
        }

        public int GetPenaltyPeriods(int daysLate)
        {
            if (daysLate <= GracePeriodDays) return 0;

            var effectiveDays = daysLate - GracePeriodDays;

            return CalculationMethod switch
            {
                PenaltyCalculationMethod.FlatRate => 1,
                PenaltyCalculationMethod.DailyRate => effectiveDays,
                PenaltyCalculationMethod.MonthlyRate => (int)Math.Ceiling(effectiveDays / 30.0m),
                PenaltyCalculationMethod.YearlyRate => (int)Math.Ceiling(effectiveDays / 365.0m),
                _ => 0
            };
        }

        // Helper method to calculate penalty with custom period definitions
        public decimal CalculatePenaltyWithCustomPeriods(int daysLate, int? daysPerMonth = 30, int? daysPerYear = 365)
        {
            if (daysLate <= GracePeriodDays) return 0;

            var effectiveDays = daysLate - GracePeriodDays;
            decimal penaltyPeriods = CalculationMethod switch
            {
                PenaltyCalculationMethod.FlatRate => 1,
                PenaltyCalculationMethod.DailyRate => effectiveDays,
                PenaltyCalculationMethod.MonthlyRate => Math.Ceiling(effectiveDays / (decimal)(daysPerMonth ?? 30)),
                PenaltyCalculationMethod.YearlyRate => Math.Ceiling(effectiveDays / (decimal)(daysPerYear ?? 365)),
                _ => throw new InvalidOperationException("Percentage method not supported for this calculation")
            };

            decimal penalty = Rate * penaltyPeriods;

            if (CapAmount.HasValue && penalty > CapAmount.Value)
            {
                penalty = CapAmount.Value;
            }

            return penalty;
        }

        // Method to get the calculation method description
        public string GetCalculationMethodDescription()
        {
            return CalculationMethod switch
            {
                PenaltyCalculationMethod.Percentage => $"{Rate}% of principal amount",
                PenaltyCalculationMethod.FlatRate => $"{Rate:C} flat fee",
                PenaltyCalculationMethod.DailyRate => $"{Rate:C} per day",
                PenaltyCalculationMethod.MonthlyRate => $"{Rate:C} per month",
                PenaltyCalculationMethod.YearlyRate => $"{Rate:C} per year",
                _ => "Unknown calculation method"
            };
        }

        // Method to get detailed penalty breakdown
        public (int Periods, string PeriodUnit, decimal BaseAmount, decimal TotalPenalty) GetPenaltyBreakdown(int daysLate)
        {
            if (daysLate <= GracePeriodDays)
                return (0, "days", 0, 0);

            var effectiveDays = daysLate - GracePeriodDays;
            int periods = 0;
            string periodUnit = "";

            switch (CalculationMethod)
            {
                case PenaltyCalculationMethod.FlatRate:
                    periods = 1;
                    periodUnit = "fee";
                    break;
                case PenaltyCalculationMethod.DailyRate:
                    periods = effectiveDays;
                    periodUnit = "days";
                    break;
                case PenaltyCalculationMethod.MonthlyRate:
                    periods = (int)Math.Ceiling(effectiveDays / 30.0m);
                    periodUnit = "months";
                    break;
                case PenaltyCalculationMethod.YearlyRate:
                    periods = (int)Math.Ceiling(effectiveDays / 365.0m);
                    periodUnit = "years";
                    break;
                default:
                    periods = 0;
                    periodUnit = "N/A";
                    break;
            }

            decimal baseAmount = Rate;
            decimal totalPenalty = CalculatePenalty(0, daysLate); // Using 0 principal for non-percentage methods

            return (periods, periodUnit, baseAmount, totalPenalty);
        }

        // Example usage helper
        public string GetPenaltyExample()
        {
            return CalculationMethod switch
            {
                PenaltyCalculationMethod.FlatRate => $"Example: {Rate:C} regardless of delay duration",
                PenaltyCalculationMethod.DailyRate => $"Example: 10 days late = {Rate * 10:C} (10 × {Rate:C})",
                PenaltyCalculationMethod.MonthlyRate => $"Example: 45 days late = {Rate * 2:C} (2 months × {Rate:C})",
                PenaltyCalculationMethod.YearlyRate => $"Example: 400 days late = {Rate * 2:C} (2 years × {Rate:C})",
                _ => "Example not available"
            };
        }

        private static void Validate(int penaltyTypeId, PenaltyCalculationMethod calculationMethod, decimal rate,
                                    int gracePeriodDays, decimal? capAmount, DateTime effectiveDate, DateTime? expiryDate)
        {
            if (penaltyTypeId <= 0)
                throw new ArgumentException("Penalty Type ID must be greater than zero.");

            if (!Enum.IsDefined(typeof(PenaltyCalculationMethod), calculationMethod))
                throw new ArgumentException("Invalid calculation method.");

            if (rate <= 0)
                throw new ArgumentException("Rate must be greater than zero.");

            if (gracePeriodDays < 0)
                throw new ArgumentException("Grace period days cannot be negative.");

            if (capAmount.HasValue && capAmount <= 0)
                throw new ArgumentException("Cap amount must be greater than zero.");

            if (expiryDate.HasValue && expiryDate <= effectiveDate)
                throw new ArgumentException("Expiry date must be after effective date.");
        }
    }

}

