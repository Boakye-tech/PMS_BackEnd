// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Domain.ValueObjects.Property;

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

        public async Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values)
        {
            try
            {
                var propertyResult = PropertyMaster.Create(
                    values.PropertyTypeId,
                    values.LandUseId,
                    values.LandUseInitial,
                    values.LandUseTypeId,
                    values.LandUseTypeInitial,
                    values.LocalityId,
                    values.LocalityInitial,
                    values.AllocationTypeId,
                    values.AllocationTypeInitial,
                    values.BlockNumber!,
                    values.PlotNumber,
                    values.AcreageOne,
                    PropertyCoordinates.Create("", "", "", "", "", "").Value,
                    false,
                    null,
                    false);

                if (!propertyResult.IsSuccess)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = 400,
                            Message = propertyResult.Error
                        }
                    };
                }

                var property = propertyResult.Value;
                property.CreatedBy = values.CreatedBy;
                property.CreatedOn = DateTime.UtcNow;

                _unitOfWork.PropertyMaster.Insert(property);
                await _unitOfWork.Complete();

                var response = new PropertyMasterCreatePlotResponseDto
                {
                    PropertyNumber = property.PropertyNumber.Value,
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

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = 201,
                        Message = "Property created successfully.",
                    }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = 500,
                        Message = ex.InnerException?.Message ?? ex.Message
                    }
                };
            }
        }

        public Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }
    }
}

