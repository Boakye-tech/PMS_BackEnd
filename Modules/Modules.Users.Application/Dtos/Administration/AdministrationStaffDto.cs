using System;
namespace Modules.Users.Application.Dtos.Administration
{
	//public record AdministrationStaffDto
	//{
 //      public string? UserId { get; set; }
 //      public string? IdentificationNumber { get; set; }
 //       public string? FirstName  { get; set; }
 //       public string? MiddleName { get; set; }
 //       public string? LastName { get; set; }
 //       public string? DepartmentName { get; set; }
 //       public string? UnitName { get; set; }
 //       public string? ProfilePicture { get; set; }
 //       public string? EmailAddress { get; set; }
 //       public string? PhoneNumber { get; set; }
 //       public string? Status { get; set; }
 //   }


    public record AdministrationStaffDto
    (
        string UserId,
        string IdentificationNumber,
        string FirstName,
        string MiddleName,
        string LastName,
        string DepartmentName ,
        string UnitName ,
        string ProfilePicture ,
        string EmailAddress,
        string PhoneNumber,
        string Status 
    );
}

