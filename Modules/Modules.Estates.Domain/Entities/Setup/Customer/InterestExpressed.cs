using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class InterestExpressed : AuditableEntity
	{
        [Key]
        [Required]
        public int InterestExpressedId { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerInterestExpressed { get; set; }

        public InterestExpressed(int interestExpressedId, string customerInterestExpressed)
		{
            InterestExpressedId = interestExpressedId;
            CustomerInterestExpressed = customerInterestExpressed;
        }

        public static InterestExpressed Create(int interestExpressedId, string customerInterestExpressed)
        {
            if (string.IsNullOrWhiteSpace(customerInterestExpressed) || interestExpressedId < 0)
            {
                throw new ArgumentException("Invalid interest expressed Data.");
            }

            if (interestExpressedId < 0)
                throw new ArgumentException("Interest expressed id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(customerInterestExpressed))
                throw new ArgumentException("Interest expressed must not be null empty.");


            return new InterestExpressed(interestExpressedId, customerInterestExpressed);
        }

    }


}

