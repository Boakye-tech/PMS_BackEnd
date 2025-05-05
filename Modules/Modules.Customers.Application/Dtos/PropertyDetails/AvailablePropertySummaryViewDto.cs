// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Dtos.PropertyDetails
{
	public record AvailablePropertySummaryViewDto
	{
        public string? LandUse { get; set; }
        public string? PropertyNumber { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }
        public string? Currency { get; set; }
        public double SellingPrice { get; set; }
    }
}

