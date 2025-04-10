using System;
namespace Modules.Users.Application.Dtos.Entities.Menu;

public record MenusDto(int menuId, string menuName, string description, string createdBy, bool IsOpen);
public record MenusDeleteDto(int menuId);



//public record MenusDto(int menuId, string menuName, string description, bool IsOpen);