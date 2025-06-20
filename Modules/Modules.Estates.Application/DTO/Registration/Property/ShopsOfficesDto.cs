// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/ShopsOfficesDto.cs
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
    public record ShopOfficeReadDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string ShopOfficeNumberFrom,
        string ShopOfficeNumberTo,
        string RentalCategory,
        string RentalType,
        string ShopOfficeType,
        DateTime DateOfTenancy,
        decimal RentalFee,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images
    );

    public record ShopOfficeCreateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string ShopOfficeNumberFrom,
        string ShopOfficeNumberTo,
        string RentalCategory,
        string RentalType,
        string ShopOfficeType,
        DateTime DateOfTenancy,
        decimal RentalFee,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string CreatedBy
    );

    public record ShopOfficeUpdateDto(
        string PropertyNumber,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string ShopOfficeNumberFrom,
        string ShopOfficeNumberTo,
        string RentalCategory,
        string RentalType,
        string ShopOfficeType,
        DateTime DateOfTenancy,
        decimal RentalFee,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string UpdatedBy
    );

    public record ShopOfficeDeleteDto(
        string PropertyNumber
    );
}