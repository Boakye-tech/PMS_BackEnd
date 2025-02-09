using System;
namespace Modules.Users.Application.Dtos.Administration
{

    public record AdministrationCustomerDto
    (
        string UserId,
        string IdentificationNumber,
        string CustomerName,
        string EmailAddress,
        string PhoneNumber,
        DateTime RegistrationDate,
        string Channel,
        //string FirstName,
        //string MiddleName,
        //string LastName,
        string Status 
    );
}

