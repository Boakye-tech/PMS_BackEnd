// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/PlotsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/06/2025 11:55 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;

namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record PlotReadDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string PlotNoFrom,
        string PlotNoTo,
        string PlotDimension,
        string Acreage1,
        string Acreage2,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string Coordinate5,
        string Coordinate6,
        string SitePlan,
        string Cadastal,
        string PropertyStatus,
        string LargeScale,
        List<string> Images
    );

    public record PlotCreateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string PlotNoFrom,
        string PlotNoTo,
        string PlotDimension,
        string Acreage1,
        string Acreage2,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string Coordinate5,
        string Coordinate6,
        string SitePlan,
        string Cadastal,
        string PropertyStatus,
        string LargeScale,
        List<string> Images,
        string CreatedBy
    );

    public record PlotUpdateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string PlotNoFrom,
        string PlotNoTo,
        string PlotDimension,
        string Acreage1,
        string Acreage2,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string Coordinate5,
        string Coordinate6,
        string SitePlan,
        string Cadastal,
        string PropertyStatus,
        string LargeScale,
        List<string> Images,
        string UpdatedBy
    );

    public record PlotDeleteDto(
        string PropertyNumber
    );
}