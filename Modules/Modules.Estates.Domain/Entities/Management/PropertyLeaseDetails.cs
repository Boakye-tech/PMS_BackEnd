// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Management/PropertyLeaseDetails.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 3:53 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Domain.Entities.Management
{
	public class PropertyLeaseDetails : AuditableEntity
	{
        [Key]
        public int PropertyLeaseDetailsId { get; set; }

        [Required]
        [StringLength(75)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        public int LeaseTypePeriodId { get; set; }

        [Required]
        public DateTime LeaseStartDate { get; set; }

        [Required]
        public int LeaseTerm { get; set; }

        public int RenewableTerm { get; set; }

        public int MaxRenewalCount { get; set; }

        public int CurrentRenewalCount { get; set; }

        public DateTime LastRenewalStartDate { get; set; }

        public LeaseStatusEnum LeaseStatusId { get; set; }

        public RenewalStatusEnum RenewalStatusId { get; set; }

        public PropertyLeaseDetails()
		{
		}

        public PropertyLeaseDetails(int propertyLeaseDetailsId, string propertyNumber, string customerCode, int leaseTypePeriodId, DateTime leaseStartDate, int leaseTerm,
                                    int renewableTerm, int maxRenewalCount, DateTime lastRenewalStartDate, LeaseStatusEnum leaseStatusId, RenewalStatusEnum renewalStatusId)
        {
        }

        public static Result<PropertyLeaseDetails> CreateLeaseDetails(string propertyNumber, string customerCode, int leaseTypePeriodId, DateTime leaseStartDate, int leaseTerm,
                                                           int renewableTerm, int maxRenewalCount, DateTime lastRenewalStartDate, LeaseStatusEnum leaseStatusId, RenewalStatusEnum renewalStatusId)
        {
            Validate(propertyNumber, customerCode, leaseTypePeriodId, leaseStartDate, leaseTerm,renewableTerm, maxRenewalCount, lastRenewalStartDate, leaseStatusId, renewalStatusId);

            var leasedetails = new PropertyLeaseDetails
            {
                PropertyNumber = propertyNumber,
                CustomerCode = customerCode,
                LeaseTypePeriodId = leaseTypePeriodId,
                LeaseStartDate = leaseStartDate,
                LeaseTerm = leaseTerm,
                RenewableTerm = renewableTerm,
                MaxRenewalCount = maxRenewalCount,
                LastRenewalStartDate = lastRenewalStartDate,
                LeaseStatusId = leaseStatusId,
                RenewalStatusId = renewalStatusId
            };

            return Result<PropertyLeaseDetails>.Success(leasedetails);

        }

        public Result<PropertyLeaseDetails> UpdateLeaseDetails(string propertyNumber, string customerCode, int leaseTypePeriodId, DateTime leaseStartDate, int leaseTerm,
                                                   int renewableTerm, int maxRenewalCount, DateTime lastRenewalStartDate, LeaseStatusEnum leaseStatusId, RenewalStatusEnum renewalStatusId)
        {
            Validate(propertyNumber, customerCode, leaseTypePeriodId, leaseStartDate, leaseTerm, renewableTerm, maxRenewalCount, lastRenewalStartDate, leaseStatusId, renewalStatusId);

            PropertyNumber = propertyNumber;
            CustomerCode = customerCode;
            LeaseTypePeriodId = leaseTypePeriodId;
            LeaseStartDate = leaseStartDate;
            LeaseTerm = leaseTerm;
            RenewableTerm = renewableTerm;
            MaxRenewalCount = maxRenewalCount;
            LastRenewalStartDate = lastRenewalStartDate;
            LeaseStatusId = leaseStatusId;
            RenewalStatusId = renewalStatusId;

            return Result<PropertyLeaseDetails>.Success(this);
        }


        public Result<PropertyLeaseDetails> RenewLease(string propertyNumber, string customerCode,int renewableTerm, DateTime lastRenewalStartDate, LeaseStatusEnum leaseStatusId, RenewalStatusEnum renewalStatusId)
        {
            //Validate(propertyNumber, customerCode, leaseTypePeriodId, leaseStartDate, leaseTerm, renewableTerm, maxRenewalCount, lastRenewalStartDate, leaseStatusId, renewalStatusId);

            PropertyNumber = propertyNumber;
            CustomerCode = customerCode;
            RenewableTerm = renewableTerm;
            LastRenewalStartDate = lastRenewalStartDate;
            LeaseStatusId = leaseStatusId;
            RenewalStatusId = renewalStatusId;

            return Result<PropertyLeaseDetails>.Success(this);
        }

        private static Result<PropertyLeaseDetails> Validate(string propertyNumber, string customerCode, int leaseTypePeriodId, DateTime leaseStartDate, int leaseTerm,
                                                      int renewableTerm, int maxRenewalCount, DateTime lastRenewalStartDate, LeaseStatusEnum leaseStatusId, RenewalStatusEnum renewalStatusId)
        {
            string errMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(propertyNumber) || propertyNumber.Length > 75)
                errMsg = "Property number cannot be empty or exceed 75 characters.";

            if (string.IsNullOrWhiteSpace(customerCode) || customerCode.Length > 10)
                errMsg = "Customer code cannot be empty or exceed 10 characters.";

            if (leaseTypePeriodId <= 0)
                errMsg = "The Lease type and period id cannot be less than or equal zero.";

            if (leaseTerm <= 0)
                errMsg = "The Lease term cannot be less than or equal zero.";

            if (renewableTerm < 0)
                errMsg = "The renewable term cannot be less than zero.";

            if (maxRenewalCount < 0)
                errMsg = "The maximum renewal count cannot be less than zero.";

            if (leaseStatusId <= 0)
                errMsg = "The lease status id cannot be less than or equal zero.";

            if (renewalStatusId < 0)
                errMsg = "The renewal status id cannot be less than zero.";


            return Result<PropertyLeaseDetails>.Failure(errMsg);

        }

    }
}

 