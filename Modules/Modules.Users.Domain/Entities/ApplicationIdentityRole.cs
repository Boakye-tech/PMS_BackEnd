using System;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Domain.Entities
{
    /// <summary>
    /// The inherited implementation of <see cref="T:Microsoft.AspNetCore.Identity.IdentityRole`1" /> which uses a string as the primary key.
    /// </summary>
    public class ApplicationIdentityRole : IdentityRole
	{
        /// <summary>
        /// Department id attached to a role
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Department Unit id attached to a role
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// Date role was created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// User who created the role
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Date role was modified
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// User who modified the role
        /// </summary>
        public string? ModifiedBy { get; set; }

        /// <summary>
        /// Date role was deleted
        /// </summary>
        public DateTime DeletedOn { get; set; }

        /// <summary>
        /// User who deleted the role
        /// </summary>
        public string? DeletedBy { get; set; }

        /// <summary>
        /// Date role was approved
        /// </summary>
        public DateTime ApprovedOn { get; set; }

        /// <summary>
        /// User who approved the role
        /// </summary>
        public string? ApprovedBy { get; set; }

        /// <summary>
        /// Status of the role record. Pending or approved status
        /// </summary>
        public short Status { get; set; }


        public ApplicationIdentityRole() : base()
		{
		}
	}
}

