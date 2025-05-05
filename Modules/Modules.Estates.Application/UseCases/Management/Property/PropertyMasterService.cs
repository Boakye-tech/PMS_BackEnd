// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Management.Property
{
	public class PropertyMasterService : IPropertyMasterService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PropertyMasterService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PropertyMasterCreatePlotResponseDto> CreateProperty(PropertyMasterCreatePlotDto values)
        {
            //throw new NotImplementedException();

            PropertyMaster property = PropertyMaster.Create(values.PropertyMasterId, values.PropertyTypeId, values.LandUseInitial, values.LandUseId, values.LandUseTypeInitial, values.LandUseTypeId,
                                                            values.LocalityInitial, values.LocalityId, values.AllocationTypeInitial, values.AllocationTypeId, values.BlockNumber!, values.PlotNumber, values.AcreageOne,
                                                            values.AcreageTwo, values.PropertyHeightId, values.PlotSizeId, values.SitePlanNumber!, false);

            property.CreatedBy = values.CreatedBy;
            property.CreatedOn = DateTime.UtcNow;

            _unitOfWork.PropertyMaster.Insert(property);
            await _unitOfWork.Complete();

            return new PropertyMasterCreatePlotResponseDto
            {
                PropertyNumber = property.PropertyNumber,
                PropertyType = _unitOfWork.PropertyType.Get(pt => pt.PropertyTypeId == property.PropertyTypeId).Result!.PropertyTypes,
                Locality = _unitOfWork.Locality.Get(l => l.LocalityId == property.LocalityId).Result!.LocalityName,
                LandUse = "",
                LandUseType = "", 

                AllocationType = "",
                BlockNumber = "",

                PlotNumber = "",

                AcreageOne = 0,

                AcreageTwo = 0,

                PropertyHeight = "",

                PlotSize = "",

                SitePlanNumber = "",


                CoordinateOne = "",

                CoordinateTwo = "",

                CoordinateThree = "",

                CoordinateFour = "",

                CoordinateFive = "",

                CoordinateSix = ""

            };
            
        }

        public Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }
    }
}

