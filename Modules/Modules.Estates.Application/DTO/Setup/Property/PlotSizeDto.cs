// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record PlotSizeReadDto(int PlotSizeId, string PlotSizes);
public record PlotSizeCreateDto(int PlotSizeId, string PlotSizes, string CreatedBy);
public record PlotSizeUpdateDto(int PlotSizeId, string PlotSizes, string ModifiedBy);
public record PlotSizDeleteDto(int PlotSizeId);
