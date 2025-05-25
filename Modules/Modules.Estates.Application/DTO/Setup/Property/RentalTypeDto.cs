// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/RentalTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 2:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record RentalTypeReadDto(int RentalCategoryId, int RentalTypeId, string RentalTypes);
    public record RentalTypeCreateDto(int RentalCategoryId, string RentalTypes, string CreatedBy);
    public record RentalTypeUpdateDto(int RentalCategoryId, int RentalTypeId, string RentalTypes, string ModifiedBy);
    public record RentalTypeDeleteDto(int RentalTypeId,  string DeletedBy);



    public record RentalCategoryReadsDto(int RentalCategoryId, string RentalCategory, bool IsOpen);
    public record RentalCategoryAndRentalTypeReadDto(RentalCategoryReadsDto RentalCategory, List<RentalTypeReadDto> RentalTypes);


}

