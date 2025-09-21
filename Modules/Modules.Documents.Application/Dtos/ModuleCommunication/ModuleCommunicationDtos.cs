// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ModuleCommunication/ModuleCommunicationDtos.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 09/09/2025 11:07 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.ModuleCommunication;

public record NationalityReadDto(int nationalityId, string nationalities);
public record LocalityReadDto(int LocalityId, string LocalityName);
public record PlotDimensionReadDto(int PlotDimensionId, string PlotDimensions);
public record PropertyHeightReadDto(int propertyHeightId, string propertyHeights);
public record BlockNumberReadDto(int blockNumberId, string blockNumbers);
public record ResidentTypeReadDto(int residentTypeId, string residentTypes);
public record ProductAwarenessSourcesReadDto(int productAwarenessSourcesId, string productAwarenessSource);