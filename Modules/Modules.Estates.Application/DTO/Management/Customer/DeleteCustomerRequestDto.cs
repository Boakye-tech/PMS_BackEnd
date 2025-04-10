using System;
namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record DeleteCustomerRequestDto(string customerCode, string deletedBy);
}

