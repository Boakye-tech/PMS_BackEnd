// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyLeaseDetailsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:17 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
	public record PropertyLeaseDetailsCreateDto
	{
        public string? PropertyNumber { get; set; }
        public string? CustomerCode { get; set; }
        public int LeaseTypePeriodId { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTerm { get; set; }
        //public DateTime LeaseExpiryDate { get; set; }
        public int RenewableTerm { get; set; }
        public int MaximumRenewalCount { get; set; }
        //public int CurrentRenewalCount { get; set; }
        //public DateTime LastRenewalStartDate { get; set; }
        public LeaseStatusEnum LeaseStatusId { get; set; }
        public RenewalStatusEnum RenewalStatusId { get; set; }
        public string? CreatedBy { get; set; }

    }

    public record PropertyLeaseDetailsUpdateDto
    {
        public int PropertyLeaseDetailsId { get; set; }
        //public string? PropertyNumber { get; set; }
        //public string? CustomerCode { get; set; }
        public int LeaseTypePeriodId { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTerm { get; set; }
        public int RenewableTerm { get; set; }
        public int MaximumRenewalCount { get; set; }
        //public int CurrentRenewalCount { get; set; }
        //public DateTime LastRenewalStartDate { get; set; }
        public LeaseStatusEnum LeaseStatusId { get; set; }
        public RenewalStatusEnum RenewalStatusId { get; set; }
        public string? ModifiedBy { get; set; }

    }

    public record PropertyLeaseDetailsRenewDto
    {
        public int PropertyLeaseDetailsId { get; set; }
        //public string? PropertyNumber { get; set; }
        //public string? CustomerCode { get; set; }
        public int RenewableTerm { get; set; }
        public DateTime LastRenewalStartDate { get; set; }
        public LeaseStatusEnum LeaseStatusId { get; set; }
        public RenewalStatusEnum RenewalStatusId { get; set; }
        public string? ModifiedBy { get; set; }
    }


    public class PropertyLeaseDetailsReadDto
    {
        public int PropertyLeaseDetailsId { get; set; }
        public string? PropertyNumber { get; set; }
        public string? CustomerCode { get; set; }
        public string? LeaseTypePeriod { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTerm { get; set; }
        public DateTime LeaseExpiryDate { get; set; }
        public int RenewableTerm { get; set; }
        public int MaxRenewalCount { get; set; }
        public int CurrentRenewalCount { get; set; }
        public DateTime LastRenewalStartDate { get; set; }
        public DateTime LastRenewalExpiryDate { get; set; }
        public LeaseStatusEnum LeaseStatus { get; set; }
        public LeaseStatusEnum RenewalStatus { get; set; }
    }


}

