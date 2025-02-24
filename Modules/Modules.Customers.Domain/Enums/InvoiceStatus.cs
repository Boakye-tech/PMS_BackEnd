using System;
namespace Modules.Customers.Domain.Enums
{
	public enum InvoiceStatus
	{
		Pending=0,
		PartiallyPaid=1,
		Paid=2,
		Overdue=3
	}
}

