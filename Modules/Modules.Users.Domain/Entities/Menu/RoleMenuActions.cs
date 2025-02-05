using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class RoleMenuActions
	{
        [Key]
        //[Required]
        public int RoleMenuActionId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleId { get; set; }
      
        public int MenuId { get; set; }

        public int SubMenuId { get; set; }

        public int SubMenuItemsId { get; set; }

        public bool NoAccess { get; set; }

        public bool Create { get; set; }

        public bool Read { get; set; }

        public bool Update { get; set; }

        public bool Delete { get; set; }

        public bool Approve { get; set; }


        public RoleMenuActions(string roleId, int menuId, int subMenuId, int subMenuItemsId, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
		{
			//RoleMenuActionId = 0;
            RoleId = roleId;
			MenuId = menuId;
			SubMenuId = subMenuId;
            SubMenuItemsId = subMenuItemsId;
            NoAccess = noAccess;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Approve = approve;

        }

        public static RoleMenuActions AssignToRoles( string roleId, int menuId, int subMenuId, int subMenuItemsId, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
        {
            if (string.IsNullOrWhiteSpace(roleId) || menuId < 0 || subMenuId < 0)
            {
                throw new ArgumentException("Invalid role and menus data.");
            }

            return new RoleMenuActions(roleId, menuId, subMenuId, subMenuItemsId, noAccess, create, read, update, delete, approve);
        }
    }
}

