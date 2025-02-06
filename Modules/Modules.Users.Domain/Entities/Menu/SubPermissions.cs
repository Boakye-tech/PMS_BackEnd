using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class SubPermissions
    {
        [Required]
        public int PermissionsId { get; set; }

        [Key]
		[Required]
		public int SubPermissionsId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string SectionName { get; set; }

        public bool NoAccess { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete  { get; set; }
        public bool Approve  { get; set; }

        

        public SubPermissions(int permissionsId, int subPermissionsId, string roleId, string sectionName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
		{
            PermissionsId = permissionsId;
            SubPermissionsId = subPermissionsId;
			RoleId = roleId;
            SectionName = sectionName;
            NoAccess = noAccess;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Approve = approve;
		}

        public static SubPermissions CreateSubPermissions(int permissionsId, int subPermissionsId, string roleId, string sectionName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
        {
            if (string.IsNullOrWhiteSpace(roleId) || string.IsNullOrWhiteSpace(sectionName))
            {
                throw new ArgumentException("Invalid sub-permissions data.");
            }

            return new SubPermissions(permissionsId, subPermissionsId, roleId, sectionName, noAccess, create, read,  update,  delete,  approve);
        }
    }
}

