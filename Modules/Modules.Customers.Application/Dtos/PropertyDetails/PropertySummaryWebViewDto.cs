using System;
namespace Modules.Customers.Application.Dtos.PropertyDetails
{
	public record PropertySummaryWebViewDto
	{
        public string? LandUse { get; set; }
        public string? PropertyNumber { get; set; }
        public string? Address { get; set; }

    }
}

