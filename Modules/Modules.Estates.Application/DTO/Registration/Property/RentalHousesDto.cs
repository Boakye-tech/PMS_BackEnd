// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/RentalHousesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/06/2025 12:57 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;

namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record RentalHouseReadDto(
        string PropertyNumber,
        string SubCode,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string RoomNumberFrom,
        string RoomNumberTo,
        string HouseType,
        string RoomSize,
        int TotalRooms,
        int RoomsOccupied,
        DateTime DateOfTenancy,
        DateTime DateOfConstruction,
        decimal CostOfConstruction,
        decimal RentalFee,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images
    );

    public record RentalHouseCreateDto(
        string PropertyNumber,
        string SubCode,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string RoomNumberFrom,
        string RoomNumberTo,
        string HouseType,
        string RoomSize,
        int TotalRooms,
        int RoomsOccupied,
        DateTime DateOfTenancy,
        DateTime DateOfConstruction,
        decimal CostOfConstruction,
        decimal RentalFee,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string CreatedBy
    );

    public record RentalHouseUpdateDto(
        string PropertyNumber,
        string SubCode,
        string PropertyType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string BlockNumber,
        string RoomNumberFrom,
        string RoomNumberTo,
        string HouseType,
        string RoomSize,
        int TotalRooms,
        int RoomsOccupied,
        DateTime DateOfTenancy,
        DateTime DateOfConstruction,
        decimal CostOfConstruction,
        decimal RentalFee,
        string Currency,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        string UpdatedBy
    );

    public record RentalHouseDeleteDto(
        string PropertyNumber
    );
}