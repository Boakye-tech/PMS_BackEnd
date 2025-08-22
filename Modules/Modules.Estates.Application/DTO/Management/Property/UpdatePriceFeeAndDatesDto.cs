// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/UpdatePriceFeeAndDates.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 21/08/2025 3:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
	public record UpdatePriceFeeAndDatesDto
	{
        public required string PropertyNumber { get; set; }

        public double? CostPrice { get; set; }
        public double? SellingPrice { get; set; }
        public double? RentalFee { get; set; }
        public int? CurrencyId { get; set; }

        public DateTime? RightOfEntry { get; set; }
        public DateTime? DateOfConstruction { get; set; }
        public DateTime? DateOfTenancy { get; set; }
        public DateTime? DateTransferedToHos { get; set; }
    }
}

