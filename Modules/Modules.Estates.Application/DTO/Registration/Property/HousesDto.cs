// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/HousesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/06/2025 11:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;

namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record HouseReadDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string HouseNumberFrom,
        string HouseNumberTo,
        string HouseType,
        DateTime DateOfTenancy,
        decimal CostPrice,
        decimal SellingPrice,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images
    );

    public record HouseCreateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string HouseNumberFrom,
        string HouseNumberTo,
        string HouseType,
        DateTime DateOfTenancy,
        decimal CostPrice,
        decimal SellingPrice,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string CreatedBy
    );

    public record HouseUpdateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string HouseNumberFrom,
        string HouseNumberTo,
        string HouseType,
        DateTime DateOfTenancy,
        decimal CostPrice,
        decimal SellingPrice,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string UpdatedBy
    );

    public record HouseDeleteDto(
        string PropertyNumber
    );
}