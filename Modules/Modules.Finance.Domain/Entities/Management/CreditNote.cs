// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/CreditNote.cs
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Domain.Entities.Management
{
	public class CreditNote
	{
		[Key]
		public int CreditNoteId { get; private set; }

		[Required]
		public int AccountCode { get; private set; }

		[Required]
		[StringLength(75)]
		public string PropertyNumber { get; private set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; private set; }

        [Required]
        [StringLength(15)]
        public string CreditNoteNumber { get; private set; }

        [Required]
        public int ContraAccountCode { get; private set; }

        [Required]
        [StringLength(75)]
        public string ContraPropertyNumber { get; private set; }

        [Required]
        [StringLength(10)]
        public string ContraCustomerCode { get; private set; }

        [Required]
        [StringLength(15)]
        public string ContraCreditNoteNumber { get; private set; }

        [Required]
        public DateTime TransactionDate { get; private set; }

        [StringLength(25)]
        public string SiteCode { get; private set; }

        [StringLength(5)]
        public string CurrencyInitial { get; private set; }


        public double BaseAmount { get; private set; }

        public double Amount { get; private set; }

        public double ForexRate { get; private set; }

        [Required]
        [StringLength(120)]
        public string Narration { get; private set; }


        [Required]
        [StringLength(2)]
        public string TransactionType { get; private set; }

        [Required]
        [StringLength(100)]
        public string SourceDocument { get; private set; }

        public short IsCancelled { get; private set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; private set; }


        public CreditNote()
		{
		}
	}
}

