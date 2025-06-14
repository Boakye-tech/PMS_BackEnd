// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/Property/IPropertyMasterService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 10/05/2025 10:54 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Modules.Estates.Application.DTO.Registration.Property;

namespace Modules.Estates.Application.Interfaces.Management.Property
{
    public interface IPropertyMasterService
    {
        Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values);
        //Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
        Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);



        Task<ReturnResponsesDto> CreateApartment(ApartmentTypeCreateDto values);

        //Task<ReturnResponsesDto> CreatePlot(PlotCreateDto values);

        //Task<ReturnResponsesDto> CreateShopsOffice(ShopsOfficesDto values);

        //Task<ReturnResponsesDto> CreateHouse(HouseCreateDto values);

        //Task<ReturnResponsesDto> CreateRentalHouse(RentalHouseCreateDto values);
    }
}

