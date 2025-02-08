using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class SubPermissionsItems
	{
        [Required]
        public int PermissionsId { get; set; }


        [Required]
        public int SubPermissionsId { get; set; }

        [Key]
		[Required]
		public int SubPermissionsItemsId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        public bool NoAccess { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete  { get; set; }
        public bool Approve  { get; set; }

        

        public SubPermissionsItems(int permissionsId, int subPermissionsId, string roleId, string itemName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
		{
            PermissionsId = permissionsId;
            SubPermissionsId = subPermissionsId;
			RoleId = roleId;
            ItemName= itemName;
            NoAccess = noAccess;
            Create = create;
            Read = read;
            Update = update;
            Delete = delete;
            Approve = approve;
		}

        public static SubPermissionsItems CreateSubPermissionsItems(int permissionsId, int subPermissionsId, string roleId, string itemName, bool noAccess, bool create, bool read, bool update, bool delete, bool approve)
        {
            if (string.IsNullOrWhiteSpace(roleId) || string.IsNullOrWhiteSpace(itemName))
            {
                throw new ArgumentException("Invalid sub-permissions items data.");
            }

            return new SubPermissionsItems(permissionsId, subPermissionsId, roleId, itemName, noAccess, create, read,  update,  delete,  approve);
        }
    }
}

