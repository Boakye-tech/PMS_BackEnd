// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Modules.Finance.Domain.ValueObject;

namespace Modules.Finance.Domain.Entities.Setup
{
    public class Services : AuditableEntity
    {
        [Key]
        [Required]
        public int ServicesId { get; private set; }

        [Required]
        [StringLength(50)]
        public string ServiceName { get; private set; }

        [StringLength(100)]
        public string? Description { get; private set; }

        public bool HasFee { get; private set; }

        [Required]
        public double Amount { get; private set; }

        [Required]
        public int AccountCode { get; private set; }

        public Money GetUnitPrice() => HasFee ? new Money(Amount) : Money.Zero;

        public ICollection<InvoiceTypes> InvoiceTypes { get;  private set; } = new List<InvoiceTypes>();

        private Services()
        {
            ServiceName = string.Empty;
        }

        public Services(string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(serviceName, amount, accountCode);

            ServiceName = serviceName;
            Description = description;
            HasFee = hasFee;
            Amount = amount;
            AccountCode = accountCode;
        }

        public static Services Create(string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(serviceName, amount, accountCode);
            return new Services(serviceName, description, hasFee, amount, accountCode);
        }

        public void Update(string serviceName, string? description, bool hasFee, double amount, int accountCode)
        {
            Validate(serviceName, amount, accountCode);

            ServiceName = serviceName;
            Description = description;
            HasFee = hasFee;
            Amount = amount;
            AccountCode = accountCode;
        }

        private static void Validate(string serviceName, double amount, int accountCode)
        {

            if (string.IsNullOrWhiteSpace(serviceName) || serviceName.Length > 50)
                throw new ArgumentException("Service Name must not be empty or exceed 50 characters.");

            if (amount < 0)
                throw new ArgumentException("Amount must be greater than or equal to zero.");

            if (accountCode <= 0)
                throw new ArgumentException("Account Code must be greater than zero.");
        }
    }
}

