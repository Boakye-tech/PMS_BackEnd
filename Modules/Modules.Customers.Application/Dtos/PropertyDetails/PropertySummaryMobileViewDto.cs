using System;
namespace Modules.Customers.Application.Dtos.PropertyDetails
{
	public record PropertySummaryMobileViewDto
	{
        public string? Image { get; set; }
        public string? LandUse { get; set; }
		public string? PropertyNumber { get; set; }
		public double Balance { get; set; }

	}
}

