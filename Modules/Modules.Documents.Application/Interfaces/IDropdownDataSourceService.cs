// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Interfaces/IDropdownDataSourceService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/09/2025 7:54 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Interfaces
{
	public interface IDropdownDataSourceService
	{
        Task<List<DropdownOptionDto>> GetOptionsAsync(string dataSource);
    }
}

