﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class Menus : AuditableEntity
	{
		[Key]
		[Required]
		public int MenuId { get; set; }

        [Required]
        [StringLength(100)]
        public string MenuName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public bool IsOpen { get; set; }

        public Menus(int menuId, string menuName, string description, bool isOpen)
		{
			MenuId = menuId;
			MenuName = menuName;
            Description = description;
            IsOpen = isOpen;
		}

        public static Menus CreateMenus(int menuId, string menuName, string description, bool isOpen)
        {
            if (string.IsNullOrWhiteSpace(menuName) || menuId < 0)
            {
                throw new ArgumentException("Invalid menus data.");
            }

            return new Menus(menuId, menuName, description, isOpen);
        }
    }
}

