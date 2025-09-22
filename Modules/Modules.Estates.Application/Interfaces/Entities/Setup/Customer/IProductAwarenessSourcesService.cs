// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface IProductAwarenessSourcesService
{
    Task<ProductAwarenessSourcesReadDto> AddProductAwarenessSourcesAsync(ProductAwarenessSourcesCreateDto values);
    Task<ProductAwarenessSourcesReadDto> UpdateProductAwarenessSourcesAsync(ProductAwarenessSourcesUpdateDto values);
    Task<IEnumerable<ProductAwarenessSourcesReadDto>> GetProductAwarenessSourcesAsync();
    Task<ProductAwarenessSourcesReadDto> GetProductAwarenessSourcesAsync(int value);
    Task<ProductAwarenessSourcesReadDto> GetProductAwarenessSourcesAsync(string value);

    Task<ProductAwarenessSourcesReadDto> DeleteProductAwarenessSourcesAsync(int value);
}
