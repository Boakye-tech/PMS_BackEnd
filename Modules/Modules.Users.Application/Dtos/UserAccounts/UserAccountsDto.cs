﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Modules.Users.Application.Dtos.UserAccounts
{
    public record LoginResponseDto
    {
        public bool LoginStatus { get; set; }
        public LoginSucessResponseDto? successResponse { get; set; }
        public LoginErrorResponseDto? errorResponse { get; set; }
    }

    public record LoginSucessResponseDto() : LoginResponse;
  
    public record LoginErrorResponseDto() : BaseResponse;

    public record ChangePasswordRequestDto() : ChangePasswordRequest;

    public record ResetPasswordRequestDto() : PasswordResetRequest;
    

}

