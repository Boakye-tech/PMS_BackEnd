// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/ReturnResponsesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 18/05/2025 6:12 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Dtos.Setup
{
    public record ReturnResponsesDto
    {
        public bool IsSuccess { get; init; }
        public SuccessResponseDto? SuccessResponse { get; init; }
        public ErrorResponseDto? ErrorResponse { get; init; }
    }

    public record ErrorResponseDto
    {
        public int Code { get; init; }
        public string? Message { get; init; }
    }

    public record SuccessResponseDto
    {
        public int Code { get; init; }
        public string? Message { get; init; }
        public object? Data { get; init; }
    }
}

