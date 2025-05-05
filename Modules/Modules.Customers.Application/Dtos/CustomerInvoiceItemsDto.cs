// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceItemsDto
	{
        public required string Description { get; set; }
        public required double Amount { get; set; }
        public double AmountPaid { get; set; }
        public double BalanceDue { get; set; }
        public string? Status { get; set; }
    }
}

