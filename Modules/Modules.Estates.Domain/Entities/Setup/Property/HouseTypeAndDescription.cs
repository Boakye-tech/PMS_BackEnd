// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/HouseTypeAndDescription.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class HouseTypeAndDescription : AuditableEntity
	{
        [Key]
        [Required]
        public int HouseTypeId { get; set; }

        [Required]
        [StringLength(10)]
        public string TypeName { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public HouseTypeAndDescription()
		{
		}
	}
}

