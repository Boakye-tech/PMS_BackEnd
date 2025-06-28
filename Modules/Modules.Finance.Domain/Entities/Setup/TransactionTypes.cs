// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/TransactionTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/06/2025 4:17 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Finance.Domain.Entities.Management;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class TransactionTypes
	{
        [Key]
		public int TransactionTypesId { get; set; }

        [Required]
        [StringLength(3)]
		public string TransactionTypeInitial { get; set; }

        public string TransactionTypeName { get; set; }

        // Navigation property for VoucherTypes
        public virtual ICollection<VoucherTypes> VoucherTypes { get; private set; }


        public TransactionTypes()
		{

            VoucherTypes = new List<VoucherTypes>();

        }
    }
}

