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
	[StringLength(100)]
	public string? InvoiceName { get; private set; }

	[Required]
	[StringLength(200)]
	public string? InvoiceDescriptions { get; private set; }

    [Required]
    public int DepartmentId { get; private set; }

    // Navigation property for Department
    public virtual Department? Department { get; private set; }

    public int DepartmentUnitId { get; private set; }

    [Required]
    public int RoomNumber { get; private set; }

    [Required]
	public int PaymentTermsId { get; private set; }


	//Navigation property for Services
	public virtual ICollection<Services> Services { get; private set; } = new List<Services>();


    public InvoiceTypes(string invoiceName, string invoiceDescriptions, int departmentId, int departmentUnitId, int roomNumber,  int paymentTermsId)
	{
        InvoiceName = invoiceName;
		InvoiceDescriptions = invoiceDescriptions;
		DepartmentId = departmentId;
		DepartmentUnitId = departmentUnitId;
		RoomNumber = roomNumber;
        PaymentTermsId = paymentTermsId;
	}

	public static InvoiceTypes Create(string invoiceName, string invoiceDescriptions, int departmentId, int departmentUnitId, int roomNumber, int paymentTermsId)
	{
		Validate(0, invoiceName, invoiceDescriptions, departmentId, departmentUnitId, roomNumber, paymentTermsId);
		return new InvoiceTypes(invoiceName, invoiceDescriptions, departmentId, departmentUnitId, roomNumber, paymentTermsId);
	}

	public void Update(int invoiceTypesId, string invoiceName, string invoiceDescriptions, int departmentId, int departmentUnitId, int roomNumber, int paymentTermsId)
	{
		Validate(invoiceTypesId, invoiceName, invoiceDescriptions, departmentId, departmentUnitId, roomNumber, paymentTermsId);
        InvoiceName = invoiceName;
		InvoiceDescriptions = invoiceDescriptions;
		DepartmentId = departmentId;
		DepartmentUnitId = departmentUnitId;
		RoomNumber = roomNumber;
        PaymentTermsId = paymentTermsId;
	}

	private static void Validate(int invoiceTypesId, string invoiceName, string invoiceDescriptions, int departmentId, int departmentUnitId, int roomNumber, int paymentTermsId)
	{
		if (invoiceTypesId < 0)
			throw new ArgumentException("Invoice type ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(invoiceName) || invoiceName.Length > 50)
			throw new ArgumentException("Invoice type name must not be null or exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(invoiceDescriptions) || invoiceDescriptions.Length > 75)
			throw new ArgumentException("Invoice type description must not be null or exceed 75 characters.");

		if (departmentId <= 0)
			throw new ArgumentException("Invoice type department id must be greater than zero.");

        if (departmentUnitId < 0)
            throw new ArgumentException("Invoice type department unit id must be greater than zero.");

        if (roomNumber <= 0)
            throw new ArgumentException("Invoice type room number must be greater than zero.");

        if (paymentTermsId <= 0)
            throw new ArgumentException("Invoice type payment terms must be greater than zero.");
    }
}

