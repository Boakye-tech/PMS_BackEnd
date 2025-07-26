// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/AssignCustomertoProperty.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:14 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Customer
{
	public class AssignCustomertoProperty
	{
        public string CustomerCode { get; set; }
        public string PropertyNumber { get; set; }
        public string ActionBy { get; set; }

        public AssignCustomertoProperty()
		{
		}
	}
}

