// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Domain.Entities.Management
{
	public class StopDebit : AuditableEntity
	{
        [Key]
        public int StopDebitId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [StringLength(75)]
        public string? PropertyNumber { get; set; }

        public int PreviousGroupNumber { get; set; }

        public int GroupNumber { get; set; }

        public string? Reasons { get; set; }


        public StopDebit()
        {
        }

        public StopDebit(int stopDebitId, string propertyNumber, string customerCode, int previousStatus, int debtorStatus, string reasons)
        {
            StopDebitId = stopDebitId;
            PropertyNumber = propertyNumber;
            CustomerCode = customerCode;
            PreviousGroupNumber = previousStatus;
            GroupNumber = debtorStatus;
            Reasons = reasons;
        }


        public static Result<StopDebit> CreateStopDebit(string propertyNumber, string customerCode, int previousStatus, int debtorStatus, string reasons)
        {
            Validate( propertyNumber,  customerCode,  previousStatus,  debtorStatus,  reasons);

            var stopdebit = new StopDebit
            {
                StopDebitId = 0,
                PropertyNumber = propertyNumber,
                CustomerCode = customerCode,
                PreviousGroupNumber = previousStatus,
                GroupNumber = debtorStatus,
                Reasons = reasons
            };

            return Result<StopDebit>.Success(stopdebit);
        }

        public Result<StopDebit> UpdateStopDebit(string propertyNumber, string customerCode, int previousStatus, int debtorStatus, string reasons)
        {
            Validate(propertyNumber, customerCode, previousStatus, debtorStatus, reasons);

            PropertyNumber = propertyNumber;
            CustomerCode = customerCode;
            PreviousGroupNumber = previousStatus;
            GroupNumber = debtorStatus;
            Reasons = reasons;

            return Result<StopDebit>.Success(this);
        }

        private static Result<StopDebit> Validate(string propertyNumber, string customerCode, int previousStatus, int debtorStatus, string reasons)
        {
            string errMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(propertyNumber) || propertyNumber.Length > 75)
                errMsg = "Property number cannot be empty or exceed 75 characters.";

            if (string.IsNullOrWhiteSpace(customerCode) || customerCode.Length > 10)
                errMsg = "Customer code cannot be empty or exceed 10 characters.";

            if (previousStatus < 0)
                errMsg = "Previous status cannot be less than zero.";

            if (debtorStatus <= 0)
                errMsg = "Debit status cannot be zero.";

            if (string.IsNullOrWhiteSpace(reasons))
                errMsg = "Reasons cannot be empty, kindly provide reasons for starting and stopping debit.";

            return Result<StopDebit>.Failure(errMsg);
        }



    }

}

