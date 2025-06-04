// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PlotDimensionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record PlotDimensionReadDto(int PlotDimensionId, string PlotDimensions);
public record PlotDimensionCreateDto(string PlotDimensions, string CreatedBy);
public record PlotDimensionUpdateDto(int PlotDimensionId, string PlotDimensions, string ModifiedBy);
public record PlotSizDeleteDto(int PlotDimensionId);
