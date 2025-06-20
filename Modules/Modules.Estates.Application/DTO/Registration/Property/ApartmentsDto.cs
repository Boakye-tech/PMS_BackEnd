// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/ApartmentsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/06/2025 11:49 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;

namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record ApartmentReadDto(
        string PropertyNumber,
        string PropertyType,
        string SchemeType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string ApartmentType,
        string BlockType,
        string BlockSide,
        string BlockUnit,
        string BlockNumber,
        string RoomNoFrom,
        string RoomNoTo,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images,
        DateTime CreatedAt,
        DateTime? UpdatedAt
    );

    public record ApartmentCreateDto(
        string PropertyNumber,
        string PropertyType,
        string SchemeType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string ApartmentType,
        string BlockType,
        string BlockSide,
        string BlockUnit,
        string BlockNumber,
        string RoomNoFrom,
        string RoomNoTo,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images
    );

    public record ApartmentUpdateDto(
        string PropertyNumber,
        string PropertyType,
        string SchemeType,
        string LandUse,
        string LandUseType,
        string Locality,
        string Site,
        string AllocationType,
        string ApartmentType,
        string BlockType,
        string BlockSide,
        string BlockUnit,
        string BlockNumber,
        string RoomNoFrom,
        string RoomNoTo,
        string Coordinate1,
        string Coordinate2,
        string Coordinate3,
        string Coordinate4,
        string PropertyStatus,
        List<string> Images
    );

    public record ApartmentDeleteDto(
       string PropertyNumber
    );
}