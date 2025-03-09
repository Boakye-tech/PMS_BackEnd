using System;
namespace Modules.Users.Application.Shared;

public record PermissionsActionsDto(bool NoAccess, bool Create, bool Read, bool Update, bool Delete, bool Approve);
