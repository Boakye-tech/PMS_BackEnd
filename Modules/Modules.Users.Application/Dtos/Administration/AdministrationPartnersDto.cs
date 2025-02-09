using System;
namespace Modules.Users.Application.Dtos.Administration
{


    public record AdministrationPartnersDto
    (
        string UserId,
        string PartnerName,
        string EmailAddress,
        string PhoneNumber,
        string ContactPerson,
        string ContactPersonEmailAddress,
        string ContactPersonPhoneNumber,
        DateTime RegistrationDate,
        string Status 
    );
}

