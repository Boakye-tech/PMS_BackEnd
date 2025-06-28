// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/VoucherTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/06/2025 4:27 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.Entities.Setup
{
	public class VoucherTypes
	{

        [Key]
        public int VoucherTypesId { get; set; }

        [Required]
        [StringLength(3)]
        public string TransactionTypeInitial { get; set; }


        [Required]
        [StringLength(3)]
        public string VoucherTypeInitial { get; set; }

        public string VoucherTypeName { get; set; }


        // Navigation property for TransactionType
        public virtual TransactionTypes? TransactionType { get; private set; }

        public VoucherTypes()
		{
		}
	}
}

