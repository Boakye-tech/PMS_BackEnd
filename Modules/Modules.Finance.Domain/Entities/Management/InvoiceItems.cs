// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/InvoiceItems.cs
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Domain.Entities.Management
{
	public class InvoiceItems
	{
        [Key]
        public int InvoiceItemsId { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int Status { get; set; }

        // Navigation property for Invoice
        public virtual Invoice? Invoice { get; private set; }


        public InvoiceItems()
		{
		}
	}
}



