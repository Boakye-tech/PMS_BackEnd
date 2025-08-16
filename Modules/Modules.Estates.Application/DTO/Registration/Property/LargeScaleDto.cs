// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/LargeScaleDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/07/2025 3:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record largeScaleCreateDto(
        string MotherPropertyNumber,
        int PropertyTypeId,
        int LandUseId,
        int LandUseTypeId,
        int LocalityId,
        int SiteId,
        int AllocationTypeId,
        int BlockNumberId,
        string PlotNumberFrom,
        string PlotNumberTo,
        int PlotDimensionId,
        int PlotTypeId,
        int PropertyHeightId,
        decimal Acreage1,
        decimal Acreage2,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string Coordinate5,
        string Coordinate6,
        string SitePlan,
        string Cadastal,
        int PropertyStatusId,
        List<string> Images,
        string CreatedBy
    );


    public record largeScaleListDto(string PropertyNumber, string CustomerCode, string CustomerName, decimal Acreage);
}

