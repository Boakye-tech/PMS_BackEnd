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

using Microsoft.EntityFrameworkCore;
using Modules.Estates.Application.DTO.Management.Property;
using Modules.Estates.Application.DTO.Registration.Property;
using Modules.Estates.Domain.ValueObjects.Property;
using static System.Net.Mime.MediaTypeNames;

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

                //check if land use type exist and get land use type initials

                //check if locality exist and get locality initials

                //check if allocation type exist and allocation type initials


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

