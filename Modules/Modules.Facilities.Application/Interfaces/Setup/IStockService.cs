// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Interfaces/Setup/IStockService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:30 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Facilities.Application.Interfaces.Setup
{
    public interface IStockService
    {
        Task<ReturnResponsesDto> CreateStockAsync(StockCreateDto values);
        Task<ReturnResponsesDto> UpdateStockAsync(StockUpdateDto values);
        Task<IEnumerable<StockReadDto>> GetStockAsync();
        Task<ReturnResponsesDto> DeleteStockAsync(int stockId);
    }
}