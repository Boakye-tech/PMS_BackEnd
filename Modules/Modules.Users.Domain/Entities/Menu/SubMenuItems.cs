﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class SubMenuItems
	{
		public int MenuId { get; set; }


        public int SubMenuId { get; set; }

        [Key]
        [Required]
        public int SubMenuItemId { get; set; }

        [Required]
        [StringLength(110)]
        public string SubMenuItemName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public bool IsOpen { get; set; }

        public SubMenuItems(int menuId, int subMenuId, int subMenuItemId, string subMenuItemName, string description, bool isOpen)
		{
			MenuId = menuId;
			SubMenuId = subMenuId;
            SubMenuItemId = subMenuItemId;
            SubMenuItemName = subMenuItemName;
			Description = description;
            IsOpen = isOpen;
		}

        public static SubMenuItems CreateSubMenuItems(int menuId, int subMenuId, int subMenuItemId, string subMenuItemName, string description, bool isOpen)
        {
            if (string.IsNullOrWhiteSpace(subMenuItemName) || menuId < 0 || subMenuId < 0)
            {
                throw new ArgumentException("Invalid sub-menu items data.");
            }

            return new SubMenuItems(menuId, subMenuId, subMenuItemId, subMenuItemName, description, isOpen);
        }


    }
}

