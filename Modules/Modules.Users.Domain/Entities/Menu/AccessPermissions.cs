using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class AccessPermissions
	{
		[Key]
		[Required]
		public int PermissionsId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string ModuleName { get; set; }

        public bool NoAccess { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete  { get; set; }
        public bool Approve  { get; set; }

        

        public AccessPermissions(int permissionsId, string roleId, string moduleName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
		{
            PermissionsId = permissionsId;
			RoleId = roleId;
            ModuleName= moduleName;
            NoAccess = noAccess;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Approve = approve;
		}

        public static AccessPermissions CreatePermissions(int permissionsId, string roleId, string moduleName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
        {
            if (string.IsNullOrWhiteSpace(roleId) || string.IsNullOrWhiteSpace(moduleName))
            {
                throw new ArgumentException("Invalid permissions data.");
            }

            return new AccessPermissions(permissionsId, roleId, moduleName, noAccess, create, read,  update,  delete,  approve);
        }
    }
}

