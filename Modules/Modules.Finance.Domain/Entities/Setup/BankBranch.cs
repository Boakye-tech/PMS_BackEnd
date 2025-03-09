using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class BankBranch : AuditableEntity
    {
        [Required]
        [StringLength(10)]
        public string BankId { get; set; }

        [Key]
        [Required]
        [StringLength(10)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(120)]
        public string BranchName { get; set; }

        public BankBranch(string bankId, string branchId, string branchName)
        {
            BankId = bankId;
            BranchId = branchId;
            BranchName = branchName;
        }

        public static BankBranch CreateUpdate(string bankId, string branchId, string branchName)
        {
            if (string.IsNullOrWhiteSpace(bankId) || string.IsNullOrWhiteSpace(branchId) || string.IsNullOrWhiteSpace(branchName))
            {
                throw new ArgumentException("Invalid bank branch data.");
            }

            if (string.IsNullOrWhiteSpace(bankId) || bankId.Length < 10)
                throw new ArgumentException("The bank id must be more than 10 characters.");

            if (string.IsNullOrWhiteSpace(branchId) || branchId.Length < 10)
                throw new ArgumentException("The bank branch id must be more than 10 characters.");

            if (string.IsNullOrWhiteSpace(branchName) || branchName.Length > 120)
                throw new ArgumentException("The bank branch name must not be null or exceed 120 characters.");

            return new BankBranch(bankId, branchId, branchName);
        }

    }
}

