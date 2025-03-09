using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
    public record BaseResponse
    {
        public required int StatusCode { get; set; }

        public required string StatusMessage { get; set; }
    }

}

