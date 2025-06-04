// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LocalityAndSitesServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 12:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class LocalityAndSitesService : ILocalityAndSitesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LocalityAndSitesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<LocalityAndSitesReadDto>> GetLocalityAndSitesAsync()
        {
            //throw new NotImplementedException();

            // Get all localities and sites in a single query using Include
            var localities = await _unitOfWork.Locality.GetAll(includes: new List<string> { "Sites" });

            // Create a dictionary for quick lookup of land use types by land use ID
            var localitiesAndSites = localities.Select(locality =>
            {
                var sites = _mapper.Map<List<SitesReadDto>>(locality.Sites);
                return new LocalityAndSitesReadDto(
                    new LocalityReadsDto(
                    locality.LocalityId,
                    locality.LocalityInitial!,
                    locality.LocalityName!,
                    locality.CustomerCode,
                    locality.CustomerCodeCounter,
                    false),
                    sites
                );
            }).ToList();

            return localitiesAndSites;
        }
    }
}

