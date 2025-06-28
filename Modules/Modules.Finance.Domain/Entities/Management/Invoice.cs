// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/Invoice.cs
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Management
{
	public class Invoice
	{
        [Key]
        public int InvoiceId { get; private set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; private set; }

        [Required]
        public DateTime InvoiceDate { get; private set; }

        [Required]
        [StringLength(75)]
        public string PropertyNumber { get; private set; }

        [Required]
        public double Acreage { get; private set; }

        [StringLength(75)]
        public string TransactionCode { get; private set; }

        [StringLength(75)]
        public string TransactionNumber { get; private set; }

        public DateTime ExpirationDate { get; private set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; private set; }

        [Required]
        [StringLength(150)]
        public string CustomerName { get; private set; }

        [Required]
        [StringLength(200)]
        public string CustomerAddress { get; private set; }

        [Required]
        [StringLength(50)]
        public string CustomerEmailAddress { get; private set; }

        [Required]
        [StringLength(15)]
        public string CustomerPhoneNumber { get; private set; }

        [Required]
        public decimal InvoiceAmount { get; private set; }

        [Required]
        public int Status { get; private set; }

        [Required]
        public string CreatedBy { get; private set; }

        // Navigation property for InvoiceItems
        public virtual ICollection<InvoiceItems> InvoiceItems { get;  private set; }

        public Invoice()
		{
		}
	}



}

