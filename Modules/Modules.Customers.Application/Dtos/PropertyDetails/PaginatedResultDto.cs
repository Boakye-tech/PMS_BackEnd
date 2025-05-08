// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PaginatedResultDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/05/2025 12:16 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Dtos.PropertyDetails
{
	public record PaginatedResultDto<T>
    {
        public List<T> SearchList { get; set; } = new List<T>();
        public int TotalRecords { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);
    }
}

