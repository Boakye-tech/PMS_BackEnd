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
        [StringLength(255)]
        public string SubMenuName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public SubMenus(int menuId, int subMenuId, string subMenuName, string description)
		{
			MenuId = menuId;
			SubMenuId = subMenuId;
			SubMenuName = subMenuName;
			Description = description;
		}

        public static SubMenus CreateSubMenus(int menuId, int subMenuId, string subMenuName, string description)
        {
            if (string.IsNullOrWhiteSpace(subMenuName) || menuId < 0 || subMenuId < 0)
            {
                throw new ArgumentException("Invalid sub-menus data.");
            }

            return new SubMenus(menuId, subMenuId, subMenuName, description);
        }


    }
}

