// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPlotSizeService
{
    Task<PlotSizeReadDto> AddPlotSizeAsync(PlotSizeCreateDto values);
    Task<PlotSizeReadDto> UpdatePlotSizeAsync(PlotSizeUpdateDto values);
    Task<IEnumerable<PlotSizeReadDto>> GetPlotSizeAsync();
    Task<PlotSizeReadDto> GetPlotSizeAsync(int value);
    Task<PlotSizeReadDto> GetPlotSizeAsync(string value);
}

