using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class Menus
	{
		[Key]
		[Required]
		public int MenuId { get; set; }

        [Required]
        [StringLength(255)]
        public string MenuName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public Menus(int menuId, string menuName, string description)
		{
			MenuId = menuId;
			MenuName = menuName;
            Description = description;
		}

        public static Menus CreateMenus(int menuId, string menuName, string description)
        {
            if (string.IsNullOrWhiteSpace(menuName) || menuId < 0)
            {
                throw new ArgumentException("Invalid menus data.");
            }

            return new Menus(menuId, menuName, description);
        }
    }
}

