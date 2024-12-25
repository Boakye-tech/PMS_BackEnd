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
      
        [Required]
        [StringLength(150)]
        public int MenuId { get; set; }

        [Required]
        [StringLength(255)]
        public int SubMenuId { get; set; }

        [StringLength(255)]
        public string NoAccess { get; set; }

        [StringLength(255)]
        public string Create { get; set; }

        [StringLength(255)]
        public string Read { get; set; }

        [StringLength(255)]
        public string Update { get; set; }

        [StringLength(255)]
        public string Delete { get; set; }

        [StringLength(255)]
        public string Approve { get; set; }


        public RoleMenuActions(string roleId, int menuId, int subMenuId, string noAccess, string create, string read, string update, string delete, string approve)
		{
			//RoleMenuActionId = 0;
            RoleId = roleId;
			MenuId = menuId;
			SubMenuId = subMenuId;
            NoAccess = noAccess;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Approve = approve;

        }

        public static RoleMenuActions AssignToRoles( string roleId, int menuId, int subMenuId, string noAccess, string create, string read, string update, string delete, string approve)
        {
            if (string.IsNullOrWhiteSpace(roleId) || menuId < 0 || subMenuId < 0)
            {
                throw new ArgumentException("Invalid role and menus data.");
            }

            return new RoleMenuActions(roleId, menuId, subMenuId, noAccess, create, read, update, delete, approve);
        }
    }
}

