// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface IOwnershipTypeService
	{
        Task<OwnershipTypeReadDto> AddOwnershipTypeAsync(OwnershipTypeCreateDto values);
        Task<OwnershipTypeReadDto> UpdateOwnershipTypeAsync(OwnershipTypeUpdateDto values);
        Task<IEnumerable<OwnershipTypeReadDto>> GetOwnershipTypeAsync();

        Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(int value);
        Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(string value);

        Task<string> DeleteOwnershipTypeAsync(int value);

    }
}

