// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/RentalCategoryProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using AutoMapper;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Application.Profiles.Property
{
    public class RentalCategoryProfile : Profile
    {
        public RentalCategoryProfile()
        {
            CreateMap<RentalCategory, RentalCategoryReadDto>();
            CreateMap<RentalCategoryCreateDto, RentalCategory>();
            CreateMap<RentalCategoryUpdateDto, RentalCategory>();

        }
    }
}