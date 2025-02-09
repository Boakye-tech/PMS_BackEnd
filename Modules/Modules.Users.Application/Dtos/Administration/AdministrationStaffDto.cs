using System;
namespace Modules.Users.Application.Dtos.Administration
{

    public record AdministrationStaffDto
    (
        string? UserId,
        string? IdentificationNumber,
        string? FirstName,
        string? MiddleName,
        string? LastName,
        string? DepartmentName ,
        string? UnitName ,
        //string ProfilePicture ,
        string? EmailAddress,
        string? PhoneNumber,
        string? RoleName,
        string Status 
    );



    
}

