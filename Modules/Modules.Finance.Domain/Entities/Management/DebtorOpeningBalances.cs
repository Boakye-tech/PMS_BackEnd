// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/DebtorOpeningBalances.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/06/2025 11:40 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Domain.Entities.Management
{
	public class DebtorOpeningBalances
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string PropertyNumber { get; private set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; private set; }

        [Required]
        public int AccountCode { get; private set; }

        [Required]
        public decimal OpeningBalance { get; private set; }

        [Required]
        public int Years { get; private set; }


        public DebtorOpeningBalances()
		{
		}
	}
}

