// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Dtos/ReturnResponsesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:27 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Application.Dtos
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

