using System;
namespace Modules.Users.Application.Dtos.UserAccounts
{
    public record UpdateAccountDetailsResponseDto
    {
        public GenericResponseDto? error { get; set; }
        public UserInformationDto? success { get; set; }
    };

}

