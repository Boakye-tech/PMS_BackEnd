// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Services
	{
        [Key]
        [Required]
        [StringLength(5)]
        public required string ServiceCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string ServiceName { get; set; }

        [Required]
        public required double Amount { get; set; }

        [Required]
        public required int AccountCode { get; set; }
    }
}

