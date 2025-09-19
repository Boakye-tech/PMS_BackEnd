// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/DebtorGroups.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 2:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
namespace Modules.Finance.Domain.Entities.Setup
{
	public class DebtorGroups : AuditableEntity
	{
        [Required]
        public int DebtorTypesId { get; private set; }

        // Navigation property for Bank
        public virtual DebtorTypes? DebtorType { get; private set; }

        [Key]
		[Required]
		public int DebtorGroupsId { get; private set; }

		[Required]
		[StringLength(50)]
		public string GroupName { get; private set; }

		[StringLength(100)]
		public string? Description { get; private set; }

		private DebtorGroups()
		{
			GroupName = string.Empty;
		}

		public DebtorGroups(int debtorTypesId, int debtorGroupsId, string groupName, string? description)
		{
			Validate(debtorTypesId, debtorGroupsId, groupName, description);

			DebtorTypesId = debtorTypesId;
			DebtorGroupsId = debtorGroupsId;
			GroupName = groupName;
			Description = description;
		}

		public static DebtorGroups Create(int debtorTypesId, int debtorGroupsId, string groupName, string? description)
		{
			Validate(debtorTypesId, debtorGroupsId, groupName, description);
			return new DebtorGroups(debtorTypesId,debtorGroupsId, groupName, description);
		}

		public void Update(int debtorTypesId, int debtorGroupsId, string groupName, string? description)
		{
			Validate(debtorTypesId,debtorGroupsId, groupName, description);

            DebtorTypesId = debtorTypesId;
            DebtorGroupsId = debtorGroupsId;
			GroupName = groupName;
			Description = description;
		}

		private static void Validate(int debtorTypesId, int debtorGroupsId, string groupName, string? description)
		{
            if (debtorTypesId <= 0)
                throw new ArgumentException("Debtor Types Id must be greater than zero.");

            if (debtorGroupsId < 0)
				throw new ArgumentException("Debtor Groups Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(groupName) || groupName.Length > 50)
				throw new ArgumentException("Group Name must not be empty or exceed 50 characters.");

			if (!string.IsNullOrEmpty(description) && description.Length > 100)
				throw new ArgumentException("Description cannot exceed 100 characters.");
		}
	}
}

