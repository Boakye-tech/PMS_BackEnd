// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/BankAccountNumbers.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 21/09/2025 7:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Domain.Entities.Setup
{ 
    public class BankAccountNumbers : AuditableEntity
    {
        [Key]
        public int BankAccountNumbersId { get; private set; }

        [Required]
        [StringLength(30)]
        public string? AccountNumber { get; private set; }

        [Required]
        [StringLength(10)]
        public string? BankId { get; private set; }

        [Required]
        [StringLength(10)]
        public string? BranchId { get; private set; }

        [Required]
        public int CurrencyId { get; private set; }

        [StringLength(100)]
        public string? Description { get; private set; }

        // Navigation properties
        public virtual Bank? Bank { get; private set; }
        public virtual BankBranch? Branch { get; private set; }
        public virtual CurrencyExchangeRate? Currency { get; private set; }

        // Private constructor for EF Core
        private BankAccountNumbers() { }

        public BankAccountNumbers(string accountNumber, string bankId, string branchId, int currencyId, string description)
        {
            Validate(accountNumber, bankId, branchId, currencyId, description);

            AccountNumber = accountNumber;
            BankId = bankId;
            BranchId = branchId;
            CurrencyId = currencyId;
            Description = description;
        }

        public static BankAccountNumbers Create(string accountNumber, string bankId, string branchId, int currencyId, string description)
        {
            Validate(accountNumber, bankId, branchId, currencyId, description);
            return new BankAccountNumbers(accountNumber, bankId, branchId, currencyId, description);
        }

        public void Update(string accountNumber, string bankId, string branchId, int currencyId, string description)
        {
            Validate(accountNumber, bankId, branchId, currencyId, description);

            AccountNumber = accountNumber;
            BankId = bankId;
            BranchId = branchId;
            CurrencyId = currencyId;
            Description = description;
        }

        private static void Validate(string accountNumber, string bankId, string branchId, int currencyId, string description)
        {
            if (string.IsNullOrWhiteSpace(accountNumber) || accountNumber.Length > 30)
                throw new ArgumentException("Account number must not be null or exceed 30 characters.");

            if (string.IsNullOrWhiteSpace(bankId) || bankId.Length > 6)
                throw new ArgumentException("Bank ID must not be null or exceed 6 characters.");

            if (string.IsNullOrWhiteSpace(branchId) || branchId.Length > 6)
                throw new ArgumentException("Branch ID must not be null or exceed 6 characters.");

            if (currencyId <= 0)
                throw new ArgumentException("Currency ID must be greater than zero.");

            if (!string.IsNullOrWhiteSpace(description) && description.Length > 100)
                throw new ArgumentException("Description must not exceed 100 characters.");
        }

        // Helper method to check if account belongs to specific bank and branch
        public bool BelongsToBankAndBranch(string bankId, string branchId)
        {
            return BankId == bankId && BranchId == branchId;
        }

        // Helper method to check if account is in specific currency
        public bool IsInCurrency(int currencyId)
        {
            return CurrencyId == currencyId;
        }
    }
}