﻿using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record MenusDto(int menuId, string menuName, string description);
    public record MenusDeleteDto(int menuId);

    
}
