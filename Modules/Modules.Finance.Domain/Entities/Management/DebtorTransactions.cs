// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/DebtorTransactions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/06/2025 9:25 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Finance.Domain.Enums;

namespace Modules.Finance.Domain.Entities.Management
{
	public class DebtorTransactions
	{
        [Key]
        public int DebtorTransactionId { get; set; }

        [Required]
        [StringLength(75)]
        public string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(25)]
        public string TransactionNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string ReferenceNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string ChequeNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Narration { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int AccountCode { get; set; }

        [Required]
        public required EntryTypeEnum EntryType { get; set; }

        [Required]
        [StringLength(3)]
        public required string TransactionType { get; set; }


        public DebtorTransactions()
		{
		}
	}
}

