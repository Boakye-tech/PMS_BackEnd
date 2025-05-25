// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/RentalCategoryAndRentalTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 11:43 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class RentalCategoryAndRentalTypeService : IRentalCategoryAndRentalTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RentalCategoryAndRentalTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RentalCategoryAndRentalTypeReadDto>> GeRentalCategoryAndRentalTypeAsync()
        {

            // Get all rental categories and rental types in a single query using Include
            var rentals = await _unitOfWork.RentalCategory.GetAll(includes: new List<string> { "RentalTypes" });

            // Create a dictionary for quick lookup of rental types by rental ID
            var rentalCategoryAndTypes = rentals.Select(rental =>
            {
                var rentalTypes = _mapper.Map<List<RentalTypeReadDto>>(rental.RentalTypes);
                return new RentalCategoryAndRentalTypeReadDto(
                    new RentalCategoryReadsDto(
                    rental.RentalCategoryId,
                    rental.RentalCategories,
                    false),
                    rentalTypes
                );
            }).ToList();

            return rentalCategoryAndTypes;
        }
    }
}

