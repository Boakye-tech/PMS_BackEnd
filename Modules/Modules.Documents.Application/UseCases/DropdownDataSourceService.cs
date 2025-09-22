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
                "blocknumber" => (await _docComms.GetBlockNumberList())
                    ?.Select(bn => new DropdownOptionDto(bn.blockNumberId, bn.blockNumbers))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "locality" => (await _docComms.GetLocalityList())
                    ?.Select(l => new DropdownOptionDto(l.LocalityId, l.LocalityName))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "nationality" => (await _docComms.GetNationalityList())
                    ?.Select(n => new DropdownOptionDto(n.nationalityId, n.nationalities))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "plotdimensions" => (await _docComms.GetPlotDimensionList())
                    ?.Select(pd => new DropdownOptionDto(pd.PlotDimensionId, pd.PlotDimensions))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "propertyheight" => (await _docComms.GetPropertyHeightList())
                    ?.Select(ph => new DropdownOptionDto(ph.propertyHeightId, ph.propertyHeights))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "residenttypes" => (await _docComms.GetResidentTypeList())
                    ?.Select(rt => new DropdownOptionDto(rt.residentTypeId, rt.residentTypes))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),

                "productawarenesssources" => (await _docComms.GetProductAwarenessSourceList()) 
                    ?.Select(p => new DropdownOptionDto(p.productAwarenessSourcesId, p.productAwarenessSource))
                    .ToList()
                    ?? new List<DropdownOptionDto>(),


                _ => new List<DropdownOptionDto>()
            };
        }
    }
}

