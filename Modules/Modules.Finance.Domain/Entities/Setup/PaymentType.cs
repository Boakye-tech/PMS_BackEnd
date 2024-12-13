using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class PaymentType : AuditableEntity
    {
        [Key]
        [Required]
        public int PaymentTypeId { get; private set; }

        [Required]
        [StringLength(20)]
        public string PaymentTypes { get; private set; }


        public PaymentType(int PaymentTypeId, string PaymentTypes)
        {
            this.PaymentTypeId = PaymentTypeId;
            this.PaymentTypes = PaymentTypes;
        }

        public static PaymentType CreateUpdate(int paymentTypeId, string paymentType)
        {
            if (string.IsNullOrWhiteSpace(paymentType) || paymentTypeId < 0)
            {
                throw new ArgumentException("Invalid Payment Type Data.");
            }

            if (paymentTypeId <= -1)
                throw new ArgumentException("The payment type id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(paymentType) || paymentType.Length > 20)
                throw new ArgumentException("The payment type must not be null or exceed 20 characters.");

            return new PaymentType(paymentTypeId, paymentType);
        }
    }
}

