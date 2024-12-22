using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class RoleMenuActions
	{
        [Key]
        [Required]
        public int RoleMenuActionId { get; set; }

        [Required]
        public string RoleId { get; set; }
      
        [Required]
        public int MenuId { get; set; }

        public int SubMenuId { get; set; }
        
        [Required]
        public int ActionId { get; set; }

		public RoleMenuActions(int roleMenuActionId, string roleId, int menuId, int subMenuId, int actionId)
		{
			RoleMenuActionId = roleMenuActionId;
			RoleId = roleId;
			MenuId = menuId;
			SubMenuId = subMenuId;
			ActionId = actionId;
		}

        public static RoleMenuActions AssignToRoles(int roleMenuActionId, string roleId, int menuId, int subMenuId, int actionId)
        {
            if (string.IsNullOrWhiteSpace(roleId) || menuId < 0 || actionId < 0)
            {
                throw new ArgumentException("Invalid role and menus data.");
            }

            return new RoleMenuActions(roleMenuActionId, roleId, menuId, subMenuId, actionId);
        }
    }
}

