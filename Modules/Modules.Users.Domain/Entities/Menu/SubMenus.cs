using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class SubMenus
	{
		public int MenuId { get; set; }

        [Key]
        [Required]
        public int SubMenuId { get; set; }

        [Required]
        [StringLength(110)]
        public string SubMenuName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public bool IsOpen { get; set; }

        public SubMenus(int menuId, int subMenuId, string subMenuName, string description, bool isOpen)
		{
			MenuId = menuId;
			SubMenuId = subMenuId;
			SubMenuName = subMenuName;
			Description = description;
            IsOpen = isOpen;
		}

        public static SubMenus CreateSubMenus(int menuId, int subMenuId, string subMenuName, string description, bool isOpen)
        {
            if (string.IsNullOrWhiteSpace(subMenuName) || menuId < 0 || subMenuId < 0)
            {
                throw new ArgumentException("Invalid sub-menus data.");
            }

            return new SubMenus(menuId, subMenuId, subMenuName, description, isOpen);
        }


    }
}

