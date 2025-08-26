// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Registration/Property/PropertyMasterQueryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/08/2025 12:29 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Web;

namespace Modules.Estates.Application.UseCases.Registration.Property
{
	public class PropertyMasterQueryService : IPropertyMasterQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PropertyMasterQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            var result = await query.OrderByDescending(x => x.property.CreatedOn).Select(x => new PropertyListSummaryViewDto
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

        public async Task<List<largeScaleListDto>> GetLargeScaleListForRegistration()
        {
            var rawResult = await (
                from property in _unitOfWork.PropertyMaster.GetQueryable()
                join customer in _unitOfWork.CustomerMaster.GetQueryable()
                    on property.CustomerCode equals customer.CustomerCode
                where property.PropertyNumber!.Value.Substring(0, 3) == "LSD"
                select new
                {
                    PropertyNumber = property.PropertyNumber!.Value,
                    property.CustomerCode,
                    CustomerName = customer.CompanyName + " " + customer.OtherNames + " " + customer.SurName,
                    Acreage = property.PlotSize!.Acreage
                }).ToListAsync();

            // Project into DTO and apply Trim in memory
            var result = rawResult.Select(ls => new largeScaleListDto(
                ls.PropertyNumber,
                ls.CustomerCode,
                ls.CustomerName.Trim(),
                ls.Acreage
            )).ToList();

            return result;
        }

        public async Task<PropertyMasterReadDto> GetPropertyDetails(string propertyNumber)
        {
            //throw new NotImplementedException();

            string _propertyNumber = HttpUtility.UrlDecode(propertyNumber);

            var properties = await _unitOfWork.PropertyMaster.GetQueryable()
                .Where(a => a.PropertyNumber!.Value.Contains(_propertyNumber))
                .Include(a => a.LandUse)
                .Include(a => a.LandUseType)
                .Include(a => a.Locality)
                .Include(a => a.AllocationType)
                .Include(a => a.Customer)
                .Include(a => a.PropertyType)
                .Include(a => a.Site)
                .Include(a => a.PropertyStatus)
                .Include(a => a.ApartmentCategory)
                .Include(a => a.ApartmentType)
                .Include(a => a.SchemeType)
                .Include(a => a.BlockNumber)
                .Include(a => a.BlockType)
                .Include(a => a.BlockUnit)
                .Include(a => a.BlockSide)
                .Include(a => a.PlotType)
                .Include(a => a.PropertyHeight)
                .Include(a => a.PlotDimension)
                .Include(a => a.RentalCategory)
                .Include(a => a.RentalType)
                .Include(a => a.Types)
                .OrderByDescending(a => a.PropertyMasterId)
                .Select(a => new PropertyMasterReadDto(
                    a.PropertyMasterId,
                    a.PropertyNumber!.Value,
                    a.PropertyTypeId,
                    a.PropertyType!.PropertyTypeName,
                    a.LocalityId,
                    a.Locality!.LocalityName,
                    a.SiteId,
                    a.Site!.SiteName,
                    a.LandUseId,
                    a.LandUse!.LandUseName,
                    a.LandUseTypeId,
                    a.LandUseType!.LandUseTypeName,
                    a.AllocationTypeId,
                    a.AllocationType!.AllocationTypes,
                    a.BlockNumberId,
                    a.BlockNumber!.BlockNumbers,
                    a.PlotSize!.Acreage,
                    a.Lease!.TermInYears,
                    a.RoomSize,
                    a.PropertyStatusId,
                    a.PropertyStatus!.PropertyStatusName,
                    a.ApartmentCategoryId,
                    a.ApartmentCategory!.ApartmentCategoryName,
                    a.ApartmentTypeId,
                    a.ApartmentType!.ApartmentType,
                    a.SchemeTypeId,
                    a.SchemeType!.SchemeTypeName,
                    a.BlockTypeId,
                    a.BlockType!.BlockType,
                    a.BlockUnitId,
                    a.BlockUnit!.Unit,
                    a.BlockSideId,
                    a.BlockSide!.Side,
                    a.Lease!.CommencementDate,
                    a.Lease!.ExpiryDate,
                    a.CustomerCode,
                    string.Concat(a.Customer!.OtherNames, a.Customer.SurName, a.Customer.CompanyName),
                    a.Coordinates!.CoordinateOne,
                    a.Coordinates!.CoordinateTwo,
                    a.Coordinates!.CoordinateThree,
                    a.Coordinates!.CoordinateFour,
                    a.Coordinates!.CoordinateFive,
                    a.Coordinates!.CoordinateSix,
                    a.IsDeleted,
                    a.CreatedOn,
                    a.CreatedBy,
                    a.ModifiedOn,
                    a.ModifiedBy,
                    a.DeletedOn,
                    a.DeletedBy,
                    a.ApprovedOn,
                    a.ApprovedBy,
                    a.Images,
                    a.Number,
                    a.RentalCategoryId,
                    a.RentalCategory!.RentalCategories,
                    a.RentalTypeId,
                    a.RentalType!.RentalTypes,
                    a.TypeId,
                    a.Types!.Code,
                    a.Types.TypeName,
                    a.CadastralPlanNumber,
                    a.Comments,
                    a.CostPrice,
                    a.CurrencyId,
                    a.DebtorType,
                    a.FloorNumberId,
                    a.GroupNumber,
                    a.MotherPropertyNumber,
                    a.RightOfEntry,
                    a.RoomsOccupied,
                    a.SellingPrice,
                    a.SitePlanNumber,
                    a.TotalNumberOfRooms,
                    a.OldPropertyNumber,
                    a.PlotTypeId,
                    a.PlotType!.PlotTypes,
                    a.PropertyHeightId,
                    a.PropertyHeight!.PropertyHeights,
                    a.DateOfConstruction,
                    a.DateOfTenancy,
                    a.DateTransferedToHos,
                    a.PlotSize.Acreage2,
                    a.PlotSize.DimensionId,
                    a.PlotDimension!.PlotDimensions
                ))
                .FirstOrDefaultAsync();

            return properties!;

        }

        public Task<List<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }

    }
}

