// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Registration/Property/PropertyMasterService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Registration.Property;
using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Application.UseCases.Registration.Property
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

        public Task<ReturnResponsesDto> CreateApartment(ApartmentTypeCreateDto values)
        {
            throw new NotImplementedException();
        }

        //public Task<ReturnResponsesDto> CreateApartment(ApartmentTypeCreateDto values)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ReturnResponsesDto> CreateHouse(HouseCreateDto values)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ReturnResponsesDto> CreatePlot(PlotCreateDto values)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values)
        {
            try
            {
                var propertyResult = PropertyMaster.Create(
                    values.PropertyTypeId,
                    values.LandUseId,
                    string.Empty, //values.LandUseInitial,
                    values.LandUseTypeId,
                     string.Empty, //values.LandUseTypeInitial,
                    values.LocalityId,
                     string.Empty, //values.LocalityInitial,
                    values.AllocationTypeId,
                     string.Empty, //values.AllocationTypeInitial,
                    values.BlockNumber!,
                    values.NumberFrom,
                    values.NumberTo,
                    values.AcreageOne,
                    PropertyCoordinates.Create("", "", "", "", "", "").Value,
                    false,
                    null,
                    false
                    );

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
                    PropertyType = _unitOfWork.PlotType.Get(pt => pt.PlotTypeId == property.PropertyTypeId).Result!.PlotTypes, //remember to check this line
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

        public Task<ReturnResponsesDto> CreateRentalHouse(RentalHouseCreateDto values)
        {
            throw new NotImplementedException();
        }

        //public Task<ReturnResponsesDto> CreateShopsOffice(ShopsOfficesDto values)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }
    }
}

