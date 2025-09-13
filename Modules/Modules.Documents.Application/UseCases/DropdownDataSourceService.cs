// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/UseCases/DropdownDataSourceService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/09/2025 7:56 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Documents.Application.UseCases
{
	public class DropdownDataSourceService : IDropdownDataSourceService
    {
        readonly IDocumentCommunicationServices _docComms;

		public DropdownDataSourceService(IDocumentCommunicationServices docComms)
		{
            _docComms = docComms;
		}

        public async Task<List<DropdownOptionDto>> GetOptionsAsync(string dataSource)
        {
            return dataSource.ToLower() switch
            {
                "nationality" => (await _docComms.GetNationalityList())
                    ?.Select(n => new DropdownOptionDto(n.nationalityId, n.nationalities))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "locality" => (await _docComms.GetLocalityList())
                    ?.Select(l => new DropdownOptionDto(l.LocalityId, l.LocalityName))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                _ => new List<DropdownOptionDto>()
            };
        }
    }
}

