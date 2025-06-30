// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Suppliers.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:58 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Facilities.Domain.Entities.Setups;

public class Suppliers : AuditableEntity
{
	[Key]
	[Required]
	public int SupplierID { get; private set; }

	[Required]
	[StringLength(100)]
	public string? SupplierName { get; private set; }

	[Required]
	[StringLength(15)]
	public string? PhoneNumber { get; private set; }

	[Required]
	[StringLength(100)]
	[EmailAddress]
	public string? EmailAddress { get; private set; }

	[StringLength(50)]
	public string? CompanyRegistrationNumber { get; private set; }

	[StringLength(50)]
	public string? TINNumber { get; private set; }

	[StringLength(200)]
	public string? CompanyAddress { get; private set; }

	[StringLength(50)]
	public string? DigitalAddress { get; private set; }

	[StringLength(1000)]
	public string? Images { get; private set; }

	[Required]
	[StringLength(50)]
	public string? ContactPerson_FirstName { get; private set; }

	[StringLength(50)]
	public string? ContactPerson_MiddleName { get; private set; }

	[Required]
	[StringLength(50)]
	public string? ContactPerson_LastName { get; private set; }

	[StringLength(50)]
	public string? ContactPerson_JobTitle { get; private set; }

	[Required]
	[StringLength(15)]
	public string? ContactPerson_PhoneNumber { get; private set; }

	[Required]
	[StringLength(100)]
	[EmailAddress]
	public string? ContactPerson_EmailAddress { get; private set; }

	public Suppliers(int supplierID, string? supplierName, string? phoneNumber, string? emailAddress,
					string? companyRegistrationNumber, string? tinNumber, string? companyAddress,
					string? digitalAddress, string? images, string? contactPerson_FirstName,
					string? contactPerson_MiddleName, string? contactPerson_LastName, string? contactPerson_JobTitle,
					string? contactPerson_PhoneNumber, string? contactPerson_EmailAddress)
	{
		SupplierID = supplierID;
		SupplierName = supplierName;
		PhoneNumber = phoneNumber;
		EmailAddress = emailAddress;
		CompanyRegistrationNumber = companyRegistrationNumber;
		TINNumber = tinNumber;
		CompanyAddress = companyAddress;
		DigitalAddress = digitalAddress;
		Images = images;
		ContactPerson_FirstName = contactPerson_FirstName;
		ContactPerson_MiddleName = contactPerson_MiddleName;
		ContactPerson_LastName = contactPerson_LastName;
		ContactPerson_JobTitle = contactPerson_JobTitle;
		ContactPerson_PhoneNumber = contactPerson_PhoneNumber;
		ContactPerson_EmailAddress = contactPerson_EmailAddress;
	}

	public static Suppliers Create(int supplierID, string? supplierName, string? phoneNumber, string? emailAddress,
								 string? companyRegistrationNumber, string? tinNumber, string? companyAddress,
								 string? digitalAddress, string? images, string? contactPerson_FirstName,
								 string? contactPerson_MiddleName, string? contactPerson_LastName, string? contactPerson_JobTitle,
								 string? contactPerson_PhoneNumber, string? contactPerson_EmailAddress)
	{
		Validate(supplierID, supplierName, phoneNumber, emailAddress, contactPerson_FirstName, contactPerson_MiddleName,
				contactPerson_LastName, contactPerson_PhoneNumber, contactPerson_EmailAddress);
		return new Suppliers(supplierID, supplierName, phoneNumber, emailAddress, companyRegistrationNumber,
						   tinNumber, companyAddress, digitalAddress, images, contactPerson_FirstName,
						   contactPerson_MiddleName, contactPerson_LastName, contactPerson_JobTitle,
						   contactPerson_PhoneNumber, contactPerson_EmailAddress);
	}

	public void Update(int supplierID, string? supplierName, string? phoneNumber, string? emailAddress,
					  string? companyRegistrationNumber, string? tinNumber, string? companyAddress,
					  string? digitalAddress, string? images, string? contactPerson_FirstName,
					  string? contactPerson_MiddleName, string? contactPerson_LastName, string? contactPerson_JobTitle,
					  string? contactPerson_PhoneNumber, string? contactPerson_EmailAddress)
	{
		Validate(supplierID, supplierName, phoneNumber, emailAddress, contactPerson_FirstName, contactPerson_MiddleName,
				contactPerson_LastName, contactPerson_PhoneNumber, contactPerson_EmailAddress);

		SupplierID = supplierID;
		SupplierName = supplierName;
		PhoneNumber = phoneNumber;
		EmailAddress = emailAddress;
		CompanyRegistrationNumber = companyRegistrationNumber;
		TINNumber = tinNumber;
		CompanyAddress = companyAddress;
		DigitalAddress = digitalAddress;
		Images = images;
		ContactPerson_FirstName = contactPerson_FirstName;
		ContactPerson_MiddleName = contactPerson_MiddleName;
		ContactPerson_LastName = contactPerson_LastName;
		ContactPerson_JobTitle = contactPerson_JobTitle;
		ContactPerson_PhoneNumber = contactPerson_PhoneNumber;
		ContactPerson_EmailAddress = contactPerson_EmailAddress;
	}

	private static void Validate(int supplierID, string? supplierName, string? phoneNumber, string? emailAddress,
								string? contactPerson_FirstName, string? contactPerson_MiddleName, string? contactPerson_LastName,
								string? contactPerson_PhoneNumber, string? contactPerson_EmailAddress)
	{
		if (supplierID < 0 || string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(phoneNumber) ||
			string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(contactPerson_FirstName) ||
			string.IsNullOrWhiteSpace(contactPerson_LastName) || string.IsNullOrWhiteSpace(contactPerson_PhoneNumber) ||
			string.IsNullOrWhiteSpace(contactPerson_EmailAddress))
		{
			throw new ArgumentException("Supplier data is invalid.");
		}

		if (supplierID < 0)
			throw new ArgumentException("Supplier ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(supplierName) || supplierName.Length > 100)
			throw new ArgumentException("Supplier name cannot be empty or exceed 100 characters.");

		if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length > 15)
			throw new ArgumentException("Phone number cannot be empty or exceed 15 characters.");

		if (string.IsNullOrWhiteSpace(emailAddress) || emailAddress.Length > 100)
			throw new ArgumentException("Email address cannot be empty or exceed 100 characters.");

		if (string.IsNullOrWhiteSpace(contactPerson_FirstName) || contactPerson_FirstName.Length > 50)
			throw new ArgumentException("Contact person first name cannot be empty or exceed 50 characters.");

		if (contactPerson_MiddleName != null && contactPerson_MiddleName.Length > 50)
			throw new ArgumentException("Contact person middle name cannot exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(contactPerson_LastName) || contactPerson_LastName.Length > 50)
			throw new ArgumentException("Contact person last name cannot be empty or exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(contactPerson_PhoneNumber) || contactPerson_PhoneNumber.Length > 15)
			throw new ArgumentException("Contact person phone number cannot be empty or exceed 15 characters.");

		if (string.IsNullOrWhiteSpace(contactPerson_EmailAddress) || contactPerson_EmailAddress.Length > 100)
			throw new ArgumentException("Contact person email address cannot be empty or exceed 100 characters.");
	}
}

