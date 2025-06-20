// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertySearchDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/05/2025 11:40 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Dtos.PropertyDetails
{
    public record PropertySearchDto
    {
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? PropertyNumber { get; set; }
    }
}

