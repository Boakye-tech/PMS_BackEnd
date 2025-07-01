// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/ServicesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record ServicesReadDto(
        int serviceId,
        string? serviceName
    );

    public record ServicesCreateDto(
        string? serviceName,
        string createdBy
    );

    public record ServicesUpdateDto(
        int serviceId,
        string? serviceName,
        string modifiedBy
    );

    public record ServicesDeleteDto(int serviceId);
}