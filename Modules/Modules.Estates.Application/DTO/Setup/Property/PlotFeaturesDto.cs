// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PlotFeaturesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 1:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{

    public record PlotFeatureReadDto(int featureId, string featureName);
    public record PlotFeaturesReadDto(int plotTypeId, string plotTypeName, List<PlotFeatureReadDto> features);

    public record PlotFeaturesCreateDto(int plotTypeId, int[] features, string createdBy);
    public record PlotFeaturesUpdateDto(int plotTypeId, int[] features, string modifiedBy);
    public record PlotFeaturesDeleteDto(int plotTypeId, int featureId, string deletedBy);
}

