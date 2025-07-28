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

        private async Task<(TEntity? entity, ReturnResponsesDto? error)> ValidateEntity<TEntity>(Func<Task<TEntity?>> fetchFunc, string errorMessage, int errorCode = StatusCodes.Status400BadRequest) where TEntity : class
        {
            var entity = await fetchFunc();
            if (entity == null)
            {
                return (null, new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = errorCode,
                        Message = errorMessage
                    }
                });
            }
            return (entity, null);
        }

        /// <summary>
        /// Parses a range string (e.g., "001A to 010A") and returns a list of all values in the range, with validation and error handling.
        /// </summary>
        /// <param name="from">The start of the range (e.g., "001A").</param>
        /// <param name="to">The end of the range (e.g., "010A").</param>
        /// <returns>List of strings representing the range, inclusive.</returns>
        /// <exception cref="ArgumentException">Thrown if the format is invalid or the suffixes don't match or the range is invalid.</exception>
        private static List<string> GenerateRangeStrings(string from, string to)
        {
            if (string.IsNullOrWhiteSpace(from) || string.IsNullOrWhiteSpace(to))
                throw new ArgumentException("Both 'from' and 'to' values must be provided.");

            // Regex: group 1 = number, group 2 = optional single letter suffix
            var regex = new System.Text.RegularExpressions.Regex(@"^(\d+)([A-Za-z]?)$");
            var matchFrom = regex.Match(from);
            var matchTo = regex.Match(to);

            if (!matchFrom.Success || !matchTo.Success)
                throw new ArgumentException($"Invalid format. Both values must be in the format 'number' or 'number+letter'. Got: '{from}' and '{to}'");

            var fromNumStr = matchFrom.Groups[1].Value;
            var fromSuffix = matchFrom.Groups[2].Value;
            var toNumStr = matchTo.Groups[1].Value;
            var toSuffix = matchTo.Groups[2].Value;

            if (!string.Equals(fromSuffix, toSuffix, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException($"Suffixes do not match: '{fromSuffix}' vs '{toSuffix}'");

            if (fromNumStr.Length != toNumStr.Length)
                throw new ArgumentException($"Number part padding does not match: '{from}' vs '{to}'");

            if (!int.TryParse(fromNumStr, out int fromNum) || !int.TryParse(toNumStr, out int toNum))
                throw new ArgumentException($"Could not parse numeric part of range: '{from}' or '{to}'");

            if (toNum < fromNum)
                throw new ArgumentException($"The 'to' value must not be less than the 'from' value: {from} to {to}");

            var result = new List<string>();
            int width = fromNumStr.Length;

            if (fromNum == toNum)
            {
                result.Add(fromNum.ToString($"D{width}") + fromSuffix);
                return result;
            }

            for (int i = fromNum; i <= toNum; i++)
            {
                result.Add(i.ToString($"D{width}") + fromSuffix);
            }
            return result;
        }

        public async Task<ReturnResponsesDto> CreateApartment(ApartmentCreateDto values)
        {
            try
            {
                var (schemeType, schemeTypeError) = await ValidateEntity(() => _unitOfWork.SchemeTypes.Get(values.SchemeTypeId), "Scheme Id provided does not exist");
                if (schemeTypeError != null) return schemeTypeError;

                var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
                if (landUseError != null) return landUseError;

                //check if land use type exist and get land use type initials
                var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
                if (landUseTypeError != null) return landUseTypeError;

                //check if locality exist and get locality initials
                var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
                if (localityError != null) return localityError;

                //check for site
                if (values.SiteId > 0)
                {
                    var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                    if (siteError != null) return siteError;
                }

                //check if allocation type exist and allocation type initials
                var (allocationype, allocationypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
                if (allocationypeError != null) return allocationypeError;

                //check block number
                var (blockNumber, blockNumberError) = await ValidateEntity(() => _unitOfWork.BlockNumber.Get(values.BlockNumberId), "Block Number Id provided does not exist");
                if (blockNumberError != null) return blockNumberError;

                //check floor number
                var (floorNumber, floorNumberError) = await ValidateEntity(() => _unitOfWork.FloorNumbering.Get(values.FloorNumberId), "Floor Number Id provided does not exist");
                if (floorNumberError != null) return floorNumberError;

                // check if apartment category exist and get apartment category
                var (apartmentCategory, apartmentCategoryError) = await ValidateEntity(() => _unitOfWork.ApartmentCategory.Get(values.ApartmentCategoryId), "Apartment Category Id provided does not exist");
                if (apartmentCategoryError != null) return apartmentCategoryError;

                //check if apartment type exist and get apartment type
                var (apartmentType, apartmentTypeError) = await ValidateEntity(() => _unitOfWork.ApartmentTypes.Get(values.ApartmentTypeId), "Apartment Type Id provided does not exist");
                if (apartmentTypeError != null) return apartmentTypeError;

                //check BlockTypeId
                var (blockType, blockTypeError) = await ValidateEntity(() => _unitOfWork.BlockType.Get(values.BlockTypeId), "Block Type Id provided does not exist");
                if (blockTypeError != null) return blockTypeError;

                //check BlockSideId
                var (blockSide, blockSideError) = await ValidateEntity(() => _unitOfWork.BlockSides.Get(values.BlockSideId), "Block Side Id provided does not exist");
                if (blockSideError != null) return blockSideError;

                //check BlockUnitId
                var (blockUnit, blockUnitError) = await ValidateEntity(() => _unitOfWork.BlockUnit.Get(values.BlockUnitId), "Block Unit Id provided does not exist");
                if (blockUnitError != null) return blockUnitError;

                var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4);

                List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

                List<string> roomNumberList;
                if (string.IsNullOrWhiteSpace(values.RoomNumberTo))
                {
                    // Only one plot number provided
                    roomNumberList = new List<string> { values.RoomNumberFrom };
                }
                else
                {
                    roomNumberList = GenerateRangeStrings(values.RoomNumberFrom, values.RoomNumberTo);
                }

                foreach (var roomNumber in roomNumberList)
                {

                    var propertyResult = PropertyMaster.CreateApartment
                       (
                       values.SchemeTypeId, schemeType!.SchemeTypeName, values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId,
                       landUseType!.LandUseTypeInitial!, values.LocalityId, locality!.LocalityInitial, values.SiteId,
                       values.AllocationTypeId, allocationype!.AllocationTypeInitial, values.ApartmentCategoryId, values.ApartmentTypeId,
                       values.BlockTypeId, values.BlockSideId, values.BlockUnitId, blockUnit!.Unit, values.BlockNumberId, blockNumber!.BlockNumbers,
                       values.FloorNumberId, roomNumber, coordinates.Value,
                       values.PropertyStatusId, values.Images, true
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

                    _propertyMasterList.Add(property);
                }

                _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
                //_unitOfWork.PropertyMaster.Insert(property);
                await _unitOfWork.Complete();


                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = 201,
                        Message = "Property created successfully", //Message = $"Property created successfully. The new property number is - {propertyResult.Value}",
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

        public async Task<ReturnResponsesDto> CreatePlot(PlotCreateDto values)
        {
            try
            {
                var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
                if (landUseError != null) return landUseError;

                //check if land use type exist and get land use type initials
                var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
                if (landUseTypeError != null) return landUseTypeError;

                //check if locality exist and get locality initials
                var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
                if (localityError != null) return localityError;

                //check for site
                if (values.SiteId > 0)
                {
                    var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                    if (siteError != null) return siteError;
                }

                //check if allocation type exist and allocation type initials
                var (allocationtype, allocationtypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
                if (allocationtypeError != null) return allocationtypeError;

                //check for plot size (dimensions)
                string _dimensions = string.Empty;
                if (values.PlotDimensionId > 0)
                {
                    var (plotDimension, plotDimensionError) = await ValidateEntity(() => _unitOfWork.PlotDimension.Get(values.PlotDimensionId), "Plot Dimension Id provided does not exist");
                    if (plotDimensionError != null) return plotDimensionError;

                    _dimensions = plotDimension!.PlotDimensions;
                }

                //check block number
                var (blockNumber, blockNumberError) = await ValidateEntity(
                    () => _unitOfWork.BlockNumber.Get(values.BlockNumberId),
                    "Block Number Id provided does not exist"
                );
                if (blockNumberError != null) return blockNumberError;

                //check plot type
                var (plotType, plotTypeError) = await ValidateEntity(
                    () => _unitOfWork.PlotType.Get(values.PlotTypeId),
                    "Plot Type Id provided does not exist"
                );
                if (plotTypeError != null) return plotTypeError;

                //check property height
                var (propertyHeight, propertyHeightError) = await ValidateEntity(
                    () => _unitOfWork.PropertyHeight.Get(values.PropertyHeightId),
                    "Property Height Id provided does not exist"
                );
                if (propertyHeightError != null) return propertyHeightError;

                var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4, values.Coordinate5, values.Coordinate6);

                List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

                List<string> plotNumberList;
                if (string.IsNullOrWhiteSpace(values.PlotNumberTo))
                {
                    // Only one plot number provided
                    plotNumberList = new List<string> { values.PlotNumberFrom };
                }
                else
                {
                    plotNumberList = GenerateRangeStrings(values.PlotNumberFrom, values.PlotNumberTo);
                }

                foreach (var plotNumber in plotNumberList)
                {
                    var propertyResult = PropertyMaster.CreatePlot
                        (
                        values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId, landUseType!.LandUseTypeInitial!, values.LocalityId, locality!.LocalityInitial, values.SiteId,
                        values.AllocationTypeId, allocationtype!.AllocationTypeInitial, values.BlockNumberId, blockNumber!.BlockNumbers, plotNumber,values.PlotDimensionId, _dimensions, values.PlotTypeId,
                        values.PropertyHeightId, coordinates.Value, values.SitePlan, values.Cadastal, values.PropertyStatusId, values.Images,
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

                    _propertyMasterList.Add(property);
                }

                _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
                //_unitOfWork.PropertyMaster.Insert(property);
                await _unitOfWork.Complete();


                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = 201,
                        Message = "Property created successfully.", //$"Property created successfully. The new property number is - {propertyResult.Value}",
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

        public async Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values)
        {
            try
            {

                //check if land use exist and get land use initials
                var _landUse = await _unitOfWork.LandUse.Get(values.LandUseId);
                if (_landUse is null)
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
                string _dimensions = string.Empty;
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

                    _dimensions = _plotDimension.PlotDimensions;
                    //var _result = _plotDimension.PlotDimensions.ToLower().Split('x');
                    //_dimensions = Convert.ToDouble(_result.First()) * Convert.ToDouble(_result.Last());
                }


                var propertyResult = PropertyMaster.Create(
                    //values.PropertyTypeId,
                    0,
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
                    values.PlotDimensionId,
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

        public ReturnResponsesDto GetAcreage(string plotDimension)
        {
            //throw new NotImplementedException();
            if (!plotDimension.ToLower().Contains('x'))
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Message = "Plot Dimension might not be in the expected format."
                    }
                };
            }

            var _result = plotDimension.ToLower().Split('x');
            if (_result.Length > 2)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Message = "Plot Dimension might not be in the expected format."
                    }
                };

            }

            //double _dimensions = Convert.ToDouble(_result.First()) * Convert.ToDouble(_result.Last());

            var _acreage = PlotSize.Create(0, plotDimension);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = StatusCodes.Status200OK,
                    Message = _acreage.Value.Acreage.ToString()
                }
            };

        }


        public async Task<ReturnResponsesDto> GetAcreage(int plotDimensionId)
        {
            //throw new NotImplementedException();


            try
            {
                if (plotDimensionId <= 0)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Plot Dimension Id cannot be zero"
                        }
                    };
                }

                var _plotDimension = await _unitOfWork.PlotDimension.Get(plotDimensionId);
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

                //var _result = _plotDimension.PlotDimensions.ToLower().Split('x');
                //double _dimensions = Convert.ToDouble(_result.First()) * Convert.ToDouble(_result.Last());

                var _acreage = PlotSize.Create(plotDimensionId, _plotDimension.PlotDimensions);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = _acreage.Value.Acreage.ToString("F2")
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
                        Message = ex.Message ?? ex.InnerException!.Message
                    }
                };

            }


        }


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

        public async Task<List<PropertyListSummaryViewDto>> GetListOfProperties(string? search = null, int? landUseId = null, int? landUseTypeId = null, int? localityId = null, int? allocationTypeId = null)
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
                    //(x.property.BlockNumber != null && x.property.BlockNumber.ToUpper().Contains(search)) ||
                    (x.property.CustomerCode != null && x.property.CustomerCode.ToUpper().Contains(search)) ||
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

        public async Task<ReturnResponsesDto> CreateShopsOffice(ShopOfficeCreateDto values)
        {
            var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
            if (landUseError != null) return landUseError;

            //check if land use type exist and get land use type initials
            var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
            if (landUseTypeError != null) return landUseTypeError;

            //check if locality exist and get locality initials
            var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
            if (localityError != null) return localityError;

            //check for site
            if (values.SiteId > 0)
            {
                var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                if (siteError != null) return siteError;
            }

            //check if allocation type exist and allocation type initials
            var (allocationtype, allocationtypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
            if (allocationtypeError != null) return allocationtypeError;

            //check block number
            var (blockNumber, blockNumberError) = await ValidateEntity(() => _unitOfWork.BlockNumber.Get(values.BlockNumberId), "Block Number Id provided does not exist");
            if (blockNumberError != null) return blockNumberError;

            //check floor number
            if (values.FloorNumberId > 0)
            {
                var (floorNumber, floorNumberError) = await ValidateEntity(() => _unitOfWork.FloorNumbering.Get(values.FloorNumberId), "Floor Number Id provided does not exist");
                if (floorNumberError != null) return floorNumberError;

            }

            var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4);

            List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

            List<string> shopOfficeNumberList;
            if (string.IsNullOrWhiteSpace(values.ShopOfficeNumberFrom))
            {
                // Only one plot number provided
                shopOfficeNumberList = new List<string> { values.ShopOfficeNumberFrom };
            }
            else
            {
                shopOfficeNumberList = GenerateRangeStrings(values.ShopOfficeNumberFrom, values.ShopOfficeNumberTo);
            }

            foreach (var shopofficeNumber in shopOfficeNumberList)
            {
                var propertyResult = PropertyMaster.CreateShopsOffices
                 (
                 values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId, landUseType!.LandUseTypeInitial!, values.LocalityId,
                 locality!.LocalityInitial, values.SiteId, values.AllocationTypeId, allocationtype!.AllocationTypeInitial, values.BlockNumberId,
                 blockNumber!.BlockNumbers, shopofficeNumber, values.RentalCategoryId, values.RentalTypeId, values.ShopOfficeTypeId,
                 coordinates.Value, values.PropertyStatusId, values.Images, false
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

                _propertyMasterList.Add(property);
            }


            _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
            await _unitOfWork.Complete();


            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = 201,
                    Message = $"Property created successfully.",
                }
            };

        }

        public async Task<ReturnResponsesDto> CreateHouse(HouseCreateDto values)
        {
            //check if land use exist and get land use initials
            var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
            if (landUseError != null) return landUseError;

            //check if land use type exist and get land use type initials
            var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
            if (landUseTypeError != null) return landUseTypeError;

            //check if locality exist and get locality initials
            var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
            if (localityError != null) return localityError;

            //check for site
            if (values.SiteId > 0)
            {
                var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                if (siteError != null) return siteError;
            }

            //check if allocation type exist and allocation type initials
            var (allocationtype, allocationtypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
            if (allocationtypeError != null) return allocationtypeError;

            //check block number
            var (blockNumber, blockNumberError) = await ValidateEntity(() => _unitOfWork.BlockNumber.Get(values.BlockNumberId), "Block Number Id provided does not exist");
            if (blockNumberError != null) return blockNumberError;

            //check for plot size (dimensions)
            string _dimensions = string.Empty;
            if (values.PlotDimensionId > 0)
            {
                var (plotDimension, plotDimensionError) = await ValidateEntity(() => _unitOfWork.PlotDimension.Get(values.PlotDimensionId), "Plot Dimension Id provided does not exist");
                if (plotDimensionError != null) return plotDimensionError;

                _dimensions = plotDimension!.PlotDimensions;
            }

            var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4);

            List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

            List<string> houseNumberList;
            if (string.IsNullOrWhiteSpace(values.HouseNumberFrom))
            {
                // Only one plot number provided
                houseNumberList = new List<string> { values.HouseNumberFrom };
            }
            else
            {
                houseNumberList = GenerateRangeStrings(values.HouseNumberFrom, values.HouseNumberTo);
            }

            foreach (var houseNumber in houseNumberList)
            {
                var propertyResult = PropertyMaster.CreateHouses
                 (
                 values.SchemeTypeId, values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId, landUseType!.LandUseTypeInitial!, values.LocalityId,
                 locality!.LocalityInitial, values.SiteId, values.AllocationTypeId, allocationtype!.AllocationTypeInitial, values.BlockNumberId,
                 blockNumber!.BlockNumbers, houseNumber, values.HouseCategoryId, values.HouseCategoryTypeId, values.HouseTypeId, values.PlotDimensionId, _dimensions,
                  values.PlotTypeId, coordinates.Value, values.PropertyStatusId, values.Images, false
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

                _propertyMasterList.Add(property);
            }


            _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
            await _unitOfWork.Complete();


            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = 201,
                    Message = $"Property created successfully.",
                }
            };
        }

        public async Task<ReturnResponsesDto> CreateRentalHouse(RentalHouseCreateDto values)
        {
            //check if land use exist and get land use initials
            var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
            if (landUseError != null) return landUseError;

            //check if land use type exist and get land use type initials
            var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
            if (landUseTypeError != null) return landUseTypeError;

            //check if locality exist and get locality initials
            var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
            if (localityError != null) return localityError;

            //check for site
            if (values.SiteId > 0)
            {
                var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                if (siteError != null) return siteError;
            }

            //check if allocation type exist and allocation type initials
            var (allocationtype, allocationtypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
            if (allocationtypeError != null) return allocationtypeError;

            //check block number
            var (blockNumber, blockNumberError) = await ValidateEntity(() => _unitOfWork.BlockNumber.Get(values.BlockNumberId), "Block Number Id provided does not exist");
            if (blockNumberError != null) return blockNumberError;

            var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4);

            List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

            List<string> rentalHouseNumberList;
            if (string.IsNullOrWhiteSpace(values.RoomNumberFrom))
            {
                // Only one plot number provided
                rentalHouseNumberList = new List<string> { values.RoomNumberFrom };
            }
            else
            {
                rentalHouseNumberList = GenerateRangeStrings(values.RoomNumberFrom, values.RoomNumberTo);
            }

            foreach (var rentalHouseNumber in rentalHouseNumberList)
            {
                var propertyResult = PropertyMaster.CreateRentalHouses
                 (
                 values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId, landUseType!.LandUseTypeInitial!, values.LocalityId,
                 locality!.LocalityInitial, values.SiteId, values.AllocationTypeId, allocationtype!.AllocationTypeInitial, values.BlockNumberId,
                 blockNumber!.BlockNumbers, rentalHouseNumber, values.HouseCategoryId, values.HouseCategoryTypeId, values.HouseTypeId,
                 coordinates.Value, values.PropertyStatusId, values.Images, false
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

                _propertyMasterList.Add(property);
            }


            _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
            await _unitOfWork.Complete();


            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = 201,
                    Message = $"Property created successfully.",
                }
            };

        }

        public async Task<ReturnResponsesDto> CreateLargeScale(largeScaleCreateDto values)
        {
            try
            {
                if (values.MotherPropertyNumber.Substring(0, 3) != "LSD") return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Message = "Sorry the property number provided is not a large scale property."
                    }
                };


                //check if mother plot number(large scale plot) exist
                var (plot, plotError) = await ValidateEntity(() => _unitOfWork.PropertyMaster.Get(p => p.PropertyNumber!.Value == values.MotherPropertyNumber), "Large scale property number provided does not exist");
                if (plotError != null) return plotError;


                //check if land use exist and get land use initials
                var (landUse, landUseError) = await ValidateEntity(() => _unitOfWork.LandUse.Get(values.LandUseId), "Land Use Id provided does not exist");
                if (landUseError != null) return landUseError;

                //check if land use type exist and get land use type initials
                var (landUseType, landUseTypeError) = await ValidateEntity(() => _unitOfWork.LandUseType.Get(values.LandUseTypeId), "Land Use Type Id provided does not exist");
                if (landUseTypeError != null) return landUseTypeError;

                //check if locality exist and get locality initials
                var (locality, localityError) = await ValidateEntity(() => _unitOfWork.Locality.Get(values.LocalityId), "Locality Id provided does not exist");
                if (localityError != null) return localityError;

                //check for site
                if (values.SiteId > 0)
                {
                    var (site, siteError) = await ValidateEntity(() => _unitOfWork.Sites.Get(values.SiteId), "Site Id provided does not exist");
                    if (siteError != null) return siteError;
                }

                //check if allocation type exist and allocation type initials
                var (allocationtype, allocationtypeError) = await ValidateEntity(() => _unitOfWork.AllocationType.Get(values.AllocationTypeId), "Allocation Type Id provided does not exist");
                if (allocationtypeError != null) return allocationtypeError;

                //check for plot size (dimensions)
                string _dimensions = string.Empty;
                if (values.PlotDimensionId > 0)
                {
                    var (plotDimension, plotDimensionError) = await ValidateEntity(() => _unitOfWork.PlotDimension.Get(values.PlotDimensionId), "Plot Dimension Id provided does not exist");
                    if (plotDimensionError != null) return plotDimensionError;

                    _dimensions = plotDimension!.PlotDimensions;
                }

                //check block number
                var (blockNumber, blockNumberError) = await ValidateEntity(
                    () => _unitOfWork.BlockNumber.Get(values.BlockNumberId),
                    "Block Number Id provided does not exist"
                );
                if (blockNumberError != null) return blockNumberError;

                //check plot type
                var (plotType, plotTypeError) = await ValidateEntity(
                    () => _unitOfWork.PlotType.Get(values.PlotTypeId),
                    "Plot Type Id provided does not exist"
                );
                if (plotTypeError != null) return plotTypeError;

                //check property height
                var (propertyHeight, propertyHeightError) = await ValidateEntity(
                    () => _unitOfWork.PropertyHeight.Get(values.PropertyHeightId),
                    "Property Height Id provided does not exist"
                );
                if (propertyHeightError != null) return propertyHeightError;

                var coordinates = PropertyCoordinates.Create(values.Coordinate1, values.Coordinate2, values.Coordinate3, values.Coordinate4, values.Coordinate5, values.Coordinate6);

                List<PropertyMaster> _propertyMasterList = new List<PropertyMaster>();

                List<string> plotNumberList;
                if (string.IsNullOrWhiteSpace(values.PlotNumberTo))
                {
                    // Only one plot number provided
                    plotNumberList = new List<string> { values.PlotNumberFrom };
                }
                else
                {
                    plotNumberList = GenerateRangeStrings(values.PlotNumberFrom, values.PlotNumberTo);
                }

                foreach (var plotNumber in plotNumberList)
                {
                    var propertyResult = PropertyMaster.CreatePlot
                        (
                        values.LandUseId, landUse!.LandUseInitial!, values.LandUseTypeId, landUseType!.LandUseTypeInitial!, values.LocalityId, locality!.LocalityInitial, values.SiteId,
                        values.AllocationTypeId, allocationtype!.AllocationTypeInitial, values.BlockNumberId, blockNumber!.BlockNumbers, plotNumber, values.PlotDimensionId, _dimensions,
                        values.PlotTypeId, values.PropertyHeightId, coordinates.Value, values.SitePlan, values.Cadastal, values.PropertyStatusId, values.Images,
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

                    _propertyMasterList.Add(property);
                }

                _unitOfWork.PropertyMaster.InsertRange(_propertyMasterList);
                //_unitOfWork.PropertyMaster.Insert(property);
                await _unitOfWork.Complete();


                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = 201,
                        Message = "Property created successfully.", //$"Property created successfully. The new property number is - {propertyResult.Value}",
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






    }
}

