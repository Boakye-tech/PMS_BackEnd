using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class PaymentMode : AuditableEntity
    {
        [Key]
        [Required]
        public int PaymentModeId { get; private set; }

        [Required]
        [StringLength(20)]
        public string? PaymentModes { get; private set; }

        public PaymentMode(int PaymentModeId, string PaymentModes)
        {
            this.PaymentModeId = PaymentModeId;
            this.PaymentModes = PaymentModes;
        }

        public static PaymentMode CreateUpdate(int paymentModeId, string paymentMode)
        {
            if (string.IsNullOrWhiteSpace(paymentMode) || paymentModeId < 0)
            {
                throw new ArgumentException("Invalid payment mode data.");
            }

            if (paymentModeId <= 0)
                throw new ArgumentException("The payment mode id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(paymentMode) || paymentMode.Length > 20)
                throw new ArgumentException("The payment mode must not be null or exceed 20 characters.");

            return new PaymentMode(paymentModeId, paymentMode);
        }
    }
}

