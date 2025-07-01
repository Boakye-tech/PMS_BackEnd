// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/ResponsesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 9:59 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto
{
    public record BaseResponseDto
    {
        public required int StatusCode { get; set; }

        public required string StatusMessage { get; set; }
    }

    public record ReturnResponsesDto
    {
        public bool IsSuccess { get; init; }
        public BaseResponseDto? SuccessResponse { get; init; }
        public BaseResponseDto? ErrorResponse { get; init; }
    }

    //public record SuccessResponseDto
    //{
    //    public int Code { get; init; }
    //    public string? Message { get; init; }
    //}

    //public record ErrorResponseDto
    //{
    //    public int Code { get; init; }
    //    public string? Message { get; init; }
    //}
}

