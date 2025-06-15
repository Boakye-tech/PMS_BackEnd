// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/HouseTypesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
    public class HouseTypesService : IHouseTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HouseTypesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HouseTypesReadDto>> GetHouseTypesAsync()
        {
            var houseTypes = await _unitOfWork.HouseTypes.GetAll();
            var rentalCategory = await _unitOfWork.RentalCategory.GetAll();
            var rentalType = await _unitOfWork.RentalType.GetAll();

            var result = from s in houseTypes
                         join rc in rentalCategory on s.RentalCategoryId equals rc.RentalCategoryId
                         join rt in rentalType on s.RentalTypeId equals rt.RentalTypeId
                         select new HouseTypesReadDto(
                             s.HouseTypeId,
                             s.Code,
                             s.TypeName,
                             s.RentalCategoryId,
                             rc.RentalCategories,
                             s.RentalTypeId,
                             rt.RentalTypes,
                             s.Features, // Assuming Features is already a string[]
                             s.Notes
                         );

            return result;
        }

        public async Task<ReturnResponsesDto> CreateHouseTypesAsync(HouseTypesCreateDto values)
        {
            try
            {
                int houseTypeId = 0;

                var existingHouseCode = await _unitOfWork.HouseTypes.Get(h => h.Code == values.Code);
                if (existingHouseCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "House Type Code already exists." },
                        SuccessResponse = null
                    };
                }

                var existingHouseType = await _unitOfWork.HouseTypes.Get(h => h.TypeName == values.TypeName);
                if (existingHouseType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "House Type Name already exists." },
                        SuccessResponse = null
                    };
                }

                var houseType = HouseTypes.Create(
                    houseTypeId,
                    values.Code!,
                    values.TypeName!,
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    values.Features!,
                    values.Notes!
                );

                houseType.CreatedBy = values.CreatedBy;
                houseType.CreatedOn = DateTime.Now;

                _unitOfWork.HouseTypes.Insert(houseType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "House Type details created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateHouseTypesAsync(HouseTypesUpdateDto values)
        {
            try
            {
                var houseType = await _unitOfWork.HouseTypes.Get(values.HouseTypeId);
                if (houseType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"House Type with ID {values.HouseTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                houseType.Update(
                    values.Code!,
                    values.TypeName!,
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    values.Features!,
                    values.Notes!
                );

                houseType.ModifiedBy = values.ModifiedBy;
                houseType.ModifiedOn = DateTime.Now;

                _unitOfWork.HouseTypes.Update(houseType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "House Type details modified successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteHouseTypes(int houseTypesId)
        {
            try
            {
                var houseType = await _unitOfWork.HouseTypes.Get(houseTypesId);
                if (houseType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"House Type with ID {houseTypesId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.HouseTypes.Delete(houseType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"House Type with ID {houseTypesId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}