// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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
        string Status,
        DateTime RegistrationDate
    );



    
}

