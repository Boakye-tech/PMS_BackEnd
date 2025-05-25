// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/AllocationTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class AllocationTypeService : IAllocationTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AllocationTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync()
    {
        var allocationTypes = await _unitOfWork.AllocationType.GetAll();
        return _mapper.Map<IEnumerable<AllocationTypeReadDto>>(allocationTypes);
    }

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value)
    {
        var allocationType = await _unitOfWork.AllocationType.Get(value);
        return _mapper.Map<AllocationTypeReadDto>(allocationType);
    }

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value)
    {
        var allocationType = await _unitOfWork.AllocationType.Get(at => at.AllocationTypeInitial == value || at.AllocationTypes == value);
        return _mapper.Map<AllocationTypeReadDto>(allocationType);
    }

    public async Task<ReturnResponsesDto> CreateAllocationTypeAsync(AllocationTypeCreateDto values)
    {
        try
        {
            int allocationTypeId = 0;

            var allocationTypeInitial = await _unitOfWork.AllocationType.Get(at => at.AllocationTypeInitial == values.AllocationTypeInitial);
            if (allocationTypeInitial != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Allocation Type Initial already exists." },
                    SuccessResponse = null
                };
            }

            var allocationType = await _unitOfWork.AllocationType.Get(at => at.AllocationTypes == values.AllocationTypes);
            if (allocationType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Allocation Type Name already exists." },
                    SuccessResponse = null
                };
            }

            var newAllocationType = AllocationType.Create(allocationTypeId, values.AllocationTypeInitial!, values.AllocationTypes!);
            newAllocationType.CreatedBy = values.CreatedBy;
            newAllocationType.CreatedOn = DateTime.Now;

            _unitOfWork.AllocationType.Insert(newAllocationType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Allocation Type created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values)
    {
        try
        {
            var allocationType = await _unitOfWork.AllocationType.Get(values.AllocationTypeId);
            if (allocationType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Allocation Type with ID {values.AllocationTypeId} not found." },
                    SuccessResponse = null
                };
            }

            allocationType.Update(values.AllocationTypeId, values.AllocationTypeInitial!, values.AllocationTypes!);
            allocationType.ModifiedBy = values.ModifiedBy;
            allocationType.ModifiedOn = DateTime.Now;

            _unitOfWork.AllocationType.Update(allocationType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Allocation Type modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteAllocationType(int allocationTypeId)
    {
        try
        {
            var allocationType = await _unitOfWork.AllocationType.Get(allocationTypeId);
            if (allocationType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Allocation Type with ID {allocationTypeId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.AllocationType.Delete(allocationType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Allocation Type with ID {allocationTypeId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

