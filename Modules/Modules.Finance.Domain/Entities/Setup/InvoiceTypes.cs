// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/InvoiceTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class InvoiceTypes : AuditableEntity
{
	[Key]
	[Required]
	public int InvoiceTypesId { get; private set; }

	[Required]
	[StringLength(5)]
	public string? InvoiceInitials { get; private set; }

	[Required]
	[StringLength(75)]
	public string? InvoiceDescriptions { get; private set; }

	[Required]
	public double InvoiceAmount { get; private set; }

	public InvoiceTypes(int invoiceTypesId, string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
	{
		InvoiceTypesId = invoiceTypesId;
		InvoiceInitials = invoiceInitials;
		InvoiceDescriptions = invoiceDescriptions;
		InvoiceAmount = invoiceAmount;
	}

	public static InvoiceTypes Create(int invoiceTypesId, string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
	{
		Validate(invoiceTypesId, invoiceInitials, invoiceDescriptions, invoiceAmount);
		return new InvoiceTypes(invoiceTypesId, invoiceInitials, invoiceDescriptions, invoiceAmount);
	}

	public void Update(int invoiceTypesId, string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
	{
		Validate(invoiceTypesId, invoiceInitials, invoiceDescriptions, invoiceAmount);
		InvoiceInitials = invoiceInitials;
		InvoiceDescriptions = invoiceDescriptions;
		InvoiceAmount = invoiceAmount;
	}

	private static void Validate(int invoiceTypesId, string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
	{
		if (invoiceTypesId <= 0)
			throw new ArgumentException("Invoice type ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(invoiceInitials) || invoiceInitials.Length > 5)
			throw new ArgumentException("Invoice type initials must not be null or exceed 5 characters.");

		if (string.IsNullOrWhiteSpace(invoiceDescriptions) || invoiceDescriptions.Length > 75)
			throw new ArgumentException("Invoice type description must not be null or exceed 75 characters.");

		if (invoiceAmount <= 0)
			throw new ArgumentException("Invoice type amount must be greater than zero.");
	}
}

