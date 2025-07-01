// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/CleanersDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record CleanersReadDto(
        string staffID,
        string? profilePhoto,
        string? firstName,
        string? middleName,
        string? lastName,
        string? phoneNumber,
        string? emailAddress,
        string? jobTitle,
        string? employmentStatus,
        DateTime hireDate,
        string? assignedProperties,
        string? images
    );

    public record CleanersCreateDto(
        string staffID,
        string? profilePhoto,
        string? firstName,
        string? middleName,
        string? lastName,
        string? phoneNumber,
        string? emailAddress,
        string? jobTitle,
        string? employmentStatus,
        DateTime hireDate,
        string? assignedProperties,
        string? images,
        string createdBy
    );

    public record CleanersUpdateDto(
        string staffID,
        string? profilePhoto,
        string? firstName,
        string? middleName,
        string? lastName,
        string? phoneNumber,
        string? emailAddress,
        string? jobTitle,
        string? employmentStatus,
        DateTime hireDate,
        string? assignedProperties,
        string? images,
        string modifiedBy
    );

    public record CleanersDeleteDto(string staffID);
}