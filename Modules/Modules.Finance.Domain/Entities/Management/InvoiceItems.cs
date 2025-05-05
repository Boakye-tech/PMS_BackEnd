// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
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
        public int InvoiceItemsId { get; set; }

        public string InvoiceNumber { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public int Status { get; set; }

        public InvoiceItems()
		{
		}
	}
}



