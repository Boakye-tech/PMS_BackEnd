// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LandUseAndLandUseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 10:33 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class LandUseAndLandUseTypeService : ILandUseAndLandUseTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LandUseAndLandUseTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync()
        {
            // Get all land uses and land use types in a single query using Include
            var landuses = await _unitOfWork.LandUse.GetAll(includes: new List<string> { "LandUseTypes" });

            // Create a dictionary for quick lookup of land use types by land use ID
            var landUseAndLandUseType = landuses.Select(landUse =>
            {
                var landUseTypes = _mapper.Map<List<LandUseTypeReadDto>>(landUse.LandUseTypes);
                return new LandUseAndLandUseTypeReadDto(
                    new LandUsesReadDto(
                    landUse.LandUseId,
                    landUse.LandUseInitial!,
                    landUse.LandUseName!,
                    false),
                    landUseTypes
                );
            }).ToList();

            return landUseAndLandUseType;
        }

       
    }
}

