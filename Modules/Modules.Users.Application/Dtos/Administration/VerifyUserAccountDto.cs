using System;
namespace Modules.Users.Application.Dtos.Administration;

public record VerifyUserAccountDto(string verifiedBy, string Reasons) : ConfirmUserAccountDto();

