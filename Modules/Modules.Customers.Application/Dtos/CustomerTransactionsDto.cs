// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos
{
	public record CustomerTransactionsDto
	{
        [StringLength(50)]
        public required string TransactionNumber { get; set; }

        [StringLength(50)]
        public required string PropertyNumber { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [Required]
        public required DateTime TransactionDate { get; set; }

        [StringLength(50)]
        public string? ReferenceNumber { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

        [StringLength(255)]
        public required string Narration { get; set; }

        public required decimal Amount { get; set; }

        public required int AccountCode { get; set; }

        //[StringLength(2)]
        public required EntryTypeEnum EntryType { get; set; }

        [StringLength(3)]
        public required string TransactionType { get; set; }
    }


    public record CustomerTransactionsReadDto
    {
        [StringLength(50)]
        public required string TransactionNumber { get; set; }

        [StringLength(50)]
        public required string PropertyNumber { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [Required]
        public required DateTime TransactionDate { get; set; }

        [StringLength(50)]
        public string? ReferenceNumber { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

        [StringLength(255)]
        public required string Narration { get; set; }

        public required decimal Amount { get; set; }

        public string? PaymentMethod { get; set; }

        [StringLength(2)]
        public required EntryTypeEnum EntryType { get; set; }

        [StringLength(3)]
        public required string TransactionType { get; set; }
    }


    
}

