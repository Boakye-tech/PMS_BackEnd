// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ReturnResponsesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 4:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos
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


    public record FormReturnResponsesDto
    {
        public bool IsSuccess { get; init; }
        public FormsSuccessResponseDto? SuccessResponse { get; init; }
        public ErrorResponseDto? ErrorResponse { get; init; }
    }

    public record FormsSuccessResponseDto
    {
        public int Code { get; init; }
        public string? Message { get; init; }
        public object? Data { get; init; }
    }

}

