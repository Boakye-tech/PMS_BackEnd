using System;
namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record ApproveCustomerDto
	{
		public string? customerCode { get; set; }
		public string? approvedBy { get; set; }
	}
}

