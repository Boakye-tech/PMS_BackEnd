// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/ReturnResponsesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 3:11 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup
{
    public record ReturnResponsesDto
    {
        public bool IsSuccess { get; init; }
        public SuccessResponseDto? SuccessResponse { get; init; }
        public ErrorResponseDto? ErrorResponse { get; init; }
    }

    public record SuccessResponseDto
    {
        public int Code { get; init; }
        public string? Message { get; init; }
    }

    public record ErrorResponseDto
    {
        public int Code { get; init; }
        public string? Message { get; init; }
    }

    //public record SuccessResponseDto
    //{
    //    public int Code { get; init; }
    //    public string? Message { get; init; }
    //    public object? Data { get; init; }
    //}
}

