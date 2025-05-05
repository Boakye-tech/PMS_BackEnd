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

namespace Modules.Finance.Domain.Entities.Management
{
	public class DebitNote
	{
        [Key]
        public int DebitNoteId { get; set; }

        [Required]
        public int AccountCode { get; set; }

        [Required]
        [StringLength(25)]
        public string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        [Required]
        [StringLength(15)]
        public string DebitNoteNumber { get; set; }

        [Required]
        public int ContraAccountCode { get; set; }

        [Required]
        [StringLength(25)]
        public string ContraPropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string ContraCustomerCode { get; set; }

        [Required]
        [StringLength(15)]
        public string ContraDebitNoteNumber { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [StringLength(25)]
        public string SiteCode { get; set; }

        [StringLength(5)]
        public string CurrencyInitial { get; set; }


        public double BaseAmount { get; set; }

        public double Amount { get; set; }

        public double ForexRate { get; set; }

        [Required]
        [StringLength(120)]
        public string Narration { get; set; }


        [Required]
        [StringLength(2)]
        public string TransactionType { get; set; }

        [Required]
        [StringLength(100)]
        public string SourceDocument { get; set; }

        public short IsCancelled { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DebitNote()
		{
		}
	}
}

