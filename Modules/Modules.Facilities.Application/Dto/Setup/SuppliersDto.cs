// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/SuppliersDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record SuppliersReadDto(
        int supplierID,
        string? supplierName,
        string? phoneNumber,
        string? emailAddress,
        string? companyRegistrationNumber,
        string? tinNumber,
        string? companyAddress,
        string? digitalAddress,
        string? images,
        string? contactPerson_FirstName,
        string? contactPerson_MiddleName,
        string? contactPerson_LastName,
        string? contactPerson_JobTitle,
        string? contactPerson_PhoneNumber,
        string? contactPerson_EmailAddress
    );

    public record SuppliersCreateDto(
        string? supplierName,
        string? phoneNumber,
        string? emailAddress,
        string? companyRegistrationNumber,
        string? tinNumber,
        string? companyAddress,
        string? digitalAddress,
        string? images,
        string? contactPerson_FirstName,
        string? contactPerson_MiddleName,
        string? contactPerson_LastName,
        string? contactPerson_JobTitle,
        string? contactPerson_PhoneNumber,
        string? contactPerson_EmailAddress,
        string createdBy
    );

    public record SuppliersUpdateDto(
        int supplierID,
        string? supplierName,
        string? phoneNumber,
        string? emailAddress,
        string? companyRegistrationNumber,
        string? tinNumber,
        string? companyAddress,
        string? digitalAddress,
        string? images,
        string? contactPerson_FirstName,
        string? contactPerson_MiddleName,
        string? contactPerson_LastName,
        string? contactPerson_JobTitle,
        string? contactPerson_PhoneNumber,
        string? contactPerson_EmailAddress,
        string modifiedBy
    );

    public record SuppliersDeleteDto(int supplierID);
}