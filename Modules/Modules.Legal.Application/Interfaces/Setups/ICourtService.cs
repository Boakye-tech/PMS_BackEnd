// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Interfaces/Setups/ICourtService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Application.Dtos;
using Modules.Legal.Application.Dtos.Setups;

namespace Modules.Legal.Application.Interfaces.Setups
{
    public interface ICourtService
    {
        Task<ReturnResponsesDto> CreateCourtAsync(CourtCreateDto values);
        Task<ReturnResponsesDto> UpdateCourtAsync(CourtUpdateDto values);
        Task<ReturnResponsesDto> DeleteCourt(int courtId);
        Task<IEnumerable<CourtReadDto>> GetCourtAsync();
        Task<IEnumerable<CourtReadDto>> GetCourtAsync(int courtId);

        Task<List<CourtAndDivisionsReadDto>> GetCourtsAndDivisons();

    }
}



