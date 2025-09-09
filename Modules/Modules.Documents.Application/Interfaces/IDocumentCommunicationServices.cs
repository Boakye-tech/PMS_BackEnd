// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Interfaces/IDocumentCommunicationServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 09/09/2025 10:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Dtos.ModuleCommunication;

namespace Modules.Documents.Application.Interfaces
{
	public interface IDocumentCommunicationServices
	{
        Task<List<NationalityReadDto>> GetNationalityList();
        Task<List<LocalityReadDto>> GetLocalityList();
        Task<List<PlotDimensionReadDto>> GetPlotDimensionList();
        Task<List<PropertyHeightReadDto>> GetPropertyHeightList();
        Task<List<BlockNumberReadDto>> GetBlockNumberList();
        Task<List<ResidentTypeReadDto>> GetResidentTypeList();
    }
}

