// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record PartnerBankRegistrationRequestDto(
        string PartnerName,
        [EmailAddress]
        string EmailAddress,
        [Phone]
        string PhoneNumber,
        string Password,
        string ConfirmPassword,
        string ContactPerson_FullName,
        string ContactPerson_EmailAddress,
        string ContactPerson_PhoneNumber,
        string ContactPerson_Position
        );


    public record PartnerBankTokenRequestDto
    {
        [EmailAddress]
        public string? EmailAddress { get; set; }
    };

    public record PartnerBankLoginResponseDto(string token);

}

