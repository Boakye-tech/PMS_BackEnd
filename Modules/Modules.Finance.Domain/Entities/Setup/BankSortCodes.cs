// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class BankSortCodes: AuditableEntity
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        public string? SortCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? BankName { get; set; }

        [Required]
        [StringLength(120)]
        public string? BranchName { get; set; }


        public BankSortCodes(int id,  string sortCode, string bankName, string branchName)
        {
            Id = id;
            SortCode = sortCode;
            BankName = bankName;
            BranchName = branchName;
        }

        public static BankSortCodes CreateUpdate(int id, string sortCode, string bankName, string branchName)
        {
            if (string.IsNullOrWhiteSpace(sortCode) || string.IsNullOrWhiteSpace(bankName) || string.IsNullOrWhiteSpace(branchName))
            {
                throw new ArgumentException("Invalid Bank Sort Code Data.");
            }

            if (string.IsNullOrWhiteSpace(sortCode) || sortCode.Length > 6)
                throw new ArgumentException("The sort code must not be null or exceed 6 characters.");

            if (string.IsNullOrWhiteSpace(bankName) || bankName.Length > 50)
                throw new ArgumentException("The bank name must not be null or exceed 50 characters.");

            if (string.IsNullOrWhiteSpace(branchName) || branchName.Length > 120)
                throw new ArgumentException("The bank branch name must not be null or exceed 120 characters.");

            return new BankSortCodes(id, sortCode, bankName, branchName);
        }


    }
}

