using System;
namespace Modules.Customers.Application.Dtos.PropertyDetails
{
	public record AvailablePropertySummaryViewDto
	{
        public string? LandUse { get; set; }
        public string? PropertyNumber { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }
    }
}

