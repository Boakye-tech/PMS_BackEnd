// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/CaseTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
	public class CaseType : AuditableEntity
	{
		[Key]
		[Required]
		public int CaseTypeId { get; private set; }

		[Required]
		[StringLength(50)]
		public string CaseTypes { get; private set; }

		// Private constructor for EF Core
		private CaseType()
		{
			CaseTypes = string.Empty;
		}

		public CaseType(int caseTypeId, string caseTypes)
		{
			Validate(caseTypeId, caseTypes);

			CaseTypeId = caseTypeId;
			CaseTypes = caseTypes ?? throw new ArgumentNullException(nameof(caseTypes));
		}

		// Domain methods
		public void UpdateCaseType(int caseTypeId, string caseTypes)
		{
            Validate(caseTypeId, caseTypes);

            CaseTypeId = caseTypeId;
			CaseTypes = caseTypes ?? throw new ArgumentNullException(nameof(caseTypes));
		}

		private static void Validate(int caseTypeId, string caseTypes)
		{
			if((caseTypeId < 0 || string.IsNullOrWhiteSpace(caseTypes)))
			{
				throw new ArgumentException("Invalid Case Type Data.");
			}

			if (caseTypeId < 0)
				throw new ArgumentException("Case Type Id must be greater than or equal to zero.");

			if(string.IsNullOrWhiteSpace(caseTypes) || caseTypes.Length > 50)
                throw new ArgumentException("Case Type cannot be empty or exceed 50 characters.");
        }

	}
}

