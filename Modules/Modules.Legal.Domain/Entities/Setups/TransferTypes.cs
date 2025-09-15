// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/TransferTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
	public class TransferTypes : AuditableEntity
	{
		[Key]
		[Required]
		public int TransferTypesId { get; private set; }

		[Required]
		[StringLength(50)]
		public string TransferType { get; private set; }

		// Private constructor for EF Core
		private TransferTypes()
		{
			TransferType = string.Empty;
		}

		public TransferTypes(int transferTypesId, string transferType)
		{
			Validate(transferTypesId, transferType);

			TransferTypesId = transferTypesId;
			TransferType = transferType ?? throw new ArgumentNullException(nameof(transferType));
		}

		// Convenience overload to preserve existing callers
		public TransferTypes(string transferType) : this(0, transferType) { }

		// Domain methods
		public void UpdateTransferType(int transferTypesId, string transferType)
		{
			Validate(transferTypesId, transferType);

			TransferTypesId = transferTypesId;
			TransferType = transferType ?? throw new ArgumentNullException(nameof(transferType));
		}

		private static void Validate(int transferTypesId, string transferType)
		{
			if ((transferTypesId < 0 || string.IsNullOrWhiteSpace(transferType)))
			{
				throw new ArgumentException("Invalid Transfer Type Data.");
			}

			if (transferTypesId < 0)
				throw new ArgumentException("Transfer Type Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(transferType) || transferType.Length > 50)
				throw new ArgumentException("Transfer Type cannot be empty or exceed 50 characters.");
		}
	}
}

