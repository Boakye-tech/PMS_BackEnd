// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Dtos/Setups/CourtDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Application.Dtos.Setups
{
    public record CourtReadDto(int courtId, string courtType);
    public record CourtCreateDto(string courtType, string createdBy);
    public record CourtUpdateDto(int courtId, string courtType, string modifiedBy);
    public record CourtDeleteDto(int courtId);

    public record CourtAndDivisionsReadDto(CourtReadDto courts, List<DivisionsReadDto> courtDevisions);
    public record DivisionsReadDto(int courtDivisionId, string courtDivision);

}


