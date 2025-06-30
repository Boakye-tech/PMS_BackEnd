// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Cleaners.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:53 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class Cleaners : AuditableEntity
{
	[Key]
	[Required]
	public int StaffID { get; private set; }

	[StringLength(255)]
	public string? ProfilePhoto { get; private set; }

	[Required]
	[StringLength(50)]
	public string? FirstName { get; private set; }

	[StringLength(50)]
	public string? MiddleName { get; private set; }

	[Required]
	[StringLength(50)]
	public string? LastName { get; private set; }

	[Required]
	[StringLength(15)]
	public string? PhoneNumber { get; private set; }

	[Required]
	[StringLength(100)]
	[EmailAddress]
	public string? EmailAddress { get; private set; }

	[Required]
	[StringLength(50)]
	public string? JobTitle { get; private set; }

	[Required]
	[StringLength(20)]
	public string? EmploymentStatus { get; private set; }

	[Required]
	public DateTime HireDate { get; private set; }

	[StringLength(500)]
	public string? AssignedProperties { get; private set; }

	[StringLength(1000)]
	public string? Images { get; private set; }

	public Cleaners(int staffID, string? profilePhoto, string? firstName, string? middleName, string? lastName,
				   string? phoneNumber, string? emailAddress, string? jobTitle, string? employmentStatus,
				   DateTime hireDate, string? assignedProperties, string? images)
	{
		StaffID = staffID;
		ProfilePhoto = profilePhoto;
		FirstName = firstName;
		MiddleName = middleName;
		LastName = lastName;
		PhoneNumber = phoneNumber;
		EmailAddress = emailAddress;
		JobTitle = jobTitle;
		EmploymentStatus = employmentStatus;
		HireDate = hireDate;
		AssignedProperties = assignedProperties;
		Images = images;
	}

	public static Cleaners Create(int staffID, string? profilePhoto, string? firstName, string? middleName,
								 string? lastName, string? phoneNumber, string? emailAddress, string? jobTitle,
								 string? employmentStatus, DateTime hireDate, string? assignedProperties, string? images)
	{
		Validate(staffID, firstName, middleName, lastName, phoneNumber, emailAddress, jobTitle, employmentStatus, hireDate);
		return new Cleaners(staffID, profilePhoto, firstName, middleName, lastName, phoneNumber, emailAddress,
						   jobTitle, employmentStatus, hireDate, assignedProperties, images);
	}

	public void Update(int staffID, string? profilePhoto, string? firstName, string? middleName,
					  string? lastName, string? phoneNumber, string? emailAddress, string? jobTitle,
					  string? employmentStatus, DateTime hireDate, string? assignedProperties, string? images)
	{
		Validate(staffID, firstName, middleName, lastName, phoneNumber, emailAddress, jobTitle, employmentStatus, hireDate);

		StaffID = staffID;
		ProfilePhoto = profilePhoto;
		FirstName = firstName;
		MiddleName = middleName;
		LastName = lastName;
		PhoneNumber = phoneNumber;
		EmailAddress = emailAddress;
		JobTitle = jobTitle;
		EmploymentStatus = employmentStatus;
		HireDate = hireDate;
		AssignedProperties = assignedProperties;
		Images = images;
	}

	private static void Validate(int staffID, string? firstName, string? middleName, string? lastName, string? phoneNumber,
								string? emailAddress, string? jobTitle, string? employmentStatus, DateTime hireDate)
	{
		if (staffID < 0 || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
			string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(emailAddress) ||
			string.IsNullOrWhiteSpace(jobTitle) || string.IsNullOrWhiteSpace(employmentStatus))
		{
			throw new ArgumentException("Cleaner data is invalid.");
		}

		if (staffID < 0)
			throw new ArgumentException("Staff ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(firstName) || firstName.Length > 50)
			throw new ArgumentException("First name cannot be empty or exceed 50 characters.");

		if (firstName != null && firstName.Length > 50)
			throw new ArgumentException("First name cannot exceed 50 characters.");

		if (middleName != null && middleName.Length > 50)
			throw new ArgumentException("Middle name cannot exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(lastName) || lastName.Length > 50)
			throw new ArgumentException("Last name cannot be empty or exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length > 15)
			throw new ArgumentException("Phone number cannot be empty or exceed 15 characters.");

		if (string.IsNullOrWhiteSpace(emailAddress) || emailAddress.Length > 100)
			throw new ArgumentException("Email address cannot be empty or exceed 100 characters.");

		if (string.IsNullOrWhiteSpace(jobTitle) || jobTitle.Length > 50)
			throw new ArgumentException("Job title cannot be empty or exceed 50 characters.");

		if (string.IsNullOrWhiteSpace(employmentStatus) || employmentStatus.Length > 20)
			throw new ArgumentException("Employment status cannot be empty or exceed 20 characters.");

		if (hireDate == default(DateTime))
			throw new ArgumentException("Hire date must be a valid date.");
	}
}

