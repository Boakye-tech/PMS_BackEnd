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
                
                //check if land use exist and get land use initials
                var _landUse = await _unitOfWork.LandUse.Get(values.LandUseId);
                if(_landUse is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Land Use Id provided does not exist"
                        }
                    };
                }
                
                //check if land use type exist and get land use type initials
                var _landUseType = await _unitOfWork.LandUseType.Get(values.LandUseTypeId);
                if (_landUseType is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Land Use Type Id provided does not exist"
                        }
                    };
                }

                //check if locality exist and get locality initials
                var _locality = await _unitOfWork.Locality.Get(values.LocalityId);
                if (_locality is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Locality Id provided does not exist"
                        }
                    };
                }

                //check if allocation type exist and allocation type initials
                var _allocationype = await _unitOfWork.AllocationType.Get(values.AllocationTypeId);
                if (_allocationype is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Allocation Type Id provided does not exist"
                        }
                    };
                }

                //check for plot size (dimensions)

                double _dimensions = 0;
                if (values.PlotDimensionId > 0)
                {
                    var _plotDimension = await _unitOfWork.PlotDimension.Get(values.PlotDimensionId);
                    if (_plotDimension is null)
                    {
                        return new ReturnResponsesDto
                        {
                            IsSuccess = false,
                            ErrorResponse = new ErrorResponseDto
                            {
                                Code = StatusCodes.Status400BadRequest,
                                Message = "Plot Dimension Id provided does not exist"
                            }
                        };
                    }

                    var _result = _plotDimension.PlotDimensions.ToLower().Split('x');
                    _dimensions = Convert.ToDouble(_result.First()) * Convert.ToDouble(_result.Last());
                }


                var propertyResult = PropertyMaster.Create(
                    values.PropertyTypeId,
                    values.LandUseId,
                    _landUse.LandUseInitial!,
                    values.LandUseTypeId,
                    _landUseType.LandUseTypeInitial!,
                    values.LocalityId,
                     _locality.LocalityInitial,
                    values.AllocationTypeId,
                    _allocationype.AllocationTypeInitial,
                    values.BlockNumber!,
                    values.NumberFrom,
                    values.NumberTo,
                    _dimensions,
                    PropertyCoordinates.Create("", "", "", "", "", "").Value,
                    false,
                    values.BlockUnit!
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
                        Code = StatusCodes.Status500InternalServerError,
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

        //public async Task<List<PropertyListSummaryViewDto>> GetListOfProperties()
        //{
        //    //throw new NotImplementedException();
        //    var result = await (from property in _unitOfWork.PropertyMaster.GetQueryable()

        //                        join customer in _unitOfWork.CustomerMaster.GetQueryable()
        //                            on property.CustomerCode equals customer.CustomerCode into customerJoin
        //                        from customer in customerJoin.DefaultIfEmpty()

        //                        join landUse in _unitOfWork.LandUse.GetQueryable()
        //                            on property.LandUseId equals landUse.LandUseId into landUseJoin
        //                        from landUse in landUseJoin.DefaultIfEmpty()

        //                        select new PropertyListSummaryViewDto
        //                        {
        //                            PropertyNumber = property.PropertyNumber!.Value,
        //                            LandUseName = landUse != null ? landUse.LandUseName : null,
        //                            CustomerCode = property.CustomerCode,
        //                            CustomerName = customer != null
        //                                    ? (customer.OtherNames ?? "") + " " + (customer.SurName ?? "") + " " + (customer.CompanyName ?? "")
        //                                    : null,
        //                            PhoneNumber = customer == null ? null : customer.PrimaryMobileNumber,
        //                            Address = customer == null ? null : customer.ResidentialAddress,
        //                            Image = property.Images == null ? null : property.Images.FirstOrDefault()
        //                        }
        //                    ).ToListAsync();

        //    return result;
        //}

        public async Task<List<PropertyListSummaryViewDto>> GetListOfProperties(string? search = null,int? landUseId = null,int? landUseTypeId = null,int? localityId = null,int? allocationTypeId = null)
        {
            var query = from property in _unitOfWork.PropertyMaster.GetQueryable()

                        join customer in _unitOfWork.CustomerMaster.GetQueryable()
                            on property.CustomerCode equals customer.CustomerCode into customerJoin
                        from customer in customerJoin.DefaultIfEmpty()

                        join landUse in _unitOfWork.LandUse.GetQueryable()
                            on property.LandUseId equals landUse.LandUseId into landUseJoin
                        from landUse in landUseJoin.DefaultIfEmpty()

                        select new { property, customer, landUse };

            // Apply filters
            if (landUseId.HasValue)
                query = query.Where(x => x.property.LandUseId == landUseId);

            if (landUseTypeId.HasValue)
                query = query.Where(x => x.property.LandUseTypeId == landUseTypeId);

            if (localityId.HasValue)
                query = query.Where(x => x.property.LocalityId == localityId);

            if (allocationTypeId.HasValue)
                query = query.Where(x => x.property.AllocationTypeId == allocationTypeId);

            // Apply search (partial match)
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToUpper();
                query = query.Where(x =>
                    x.property.PropertyNumber.Value.ToUpper().Contains(search) ||
                    (x.property.BlockNumber != null && x.property.BlockNumber.ToUpper().Contains(search)) ||
                    (x.customer != null &&
                        (
                            (x.customer.SurName ?? "").ToUpper().Contains(search) ||
                            (x.customer.OtherNames ?? "").ToUpper().Contains(search)
                        ))
                );
            }

            // Final projection
            var result = await query.Select(x => new PropertyListSummaryViewDto
            {
                PropertyNumber = x.property.PropertyNumber!.Value,
                LandUseName = x.landUse != null ? x.landUse.LandUseName : null,
                CustomerCode = x.property.CustomerCode,
                CustomerName = x.customer != null
                    ? $"{x.customer.OtherNames ?? ""} {x.customer.SurName ?? ""} {x.customer.CompanyName ?? ""}".Trim()
                    : null,
                PhoneNumber = x.customer == null ? null : x.customer.PrimaryMobileNumber,
                Address = x.customer == null ? null : x.customer.ResidentialAddress,
                Image = x.property == null ? null : x.property.Images.FirstOrDefault()
            }).ToListAsync();

            return result;
        }


        public Task<List<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }
    }
}

