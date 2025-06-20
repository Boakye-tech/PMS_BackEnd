// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockUnitService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockUnitService : IBlockUnitService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockUnitService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BlockUnitReadDto>> GetBlockUnitAsync()
    {
        var response = await _unitOfWork.BlockUnit.GetAll();
        return _mapper.Map<IEnumerable<BlockUnitReadDto>>(response);
    }

    public async Task<BlockUnitReadDto> GetBlockUnitAsync(int value)
    {
        var response = await _unitOfWork.BlockUnit.Get(value);
        return _mapper.Map<BlockUnitReadDto>(response);
    }

    public async Task<BlockUnitReadDto> GetBlockUnitAsync(string value)
    {
        var response = await _unitOfWork.BlockUnit.Get(bu => bu.Unit == value);
        return _mapper.Map<BlockUnitReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateBlockUnitAsync(BlockUnitCreateDto values)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(values.unit))
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Block Unit name cannot be empty." },
                    SuccessResponse = null
                };
            }

            var existingUnit = await _unitOfWork.BlockUnit.Get(bu => bu.Unit == values.unit);
            if (existingUnit != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Block Unit already exists." },
                    SuccessResponse = null
                };
            }

            var blockUnit = BlockUnit.Create(0, values.unit);
            blockUnit.CreatedBy = values.createdby;
            blockUnit.CreatedOn = DateTime.Now;

            _unitOfWork.BlockUnit.Insert(blockUnit);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Block Unit created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateBlockUnitAsync(BlockUnitUpdateDto values)
    {
        try
        {
            var blockUnit = await _unitOfWork.BlockUnit.Get(values.unitId);
            if (blockUnit == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Unit with ID {values.unitId} not found." },
                    SuccessResponse = null
                };
            }

            blockUnit.Update(values.unitId, values.unit);
            blockUnit.ModifiedBy = values.modifiedby;
            blockUnit.ModifiedOn = DateTime.Now;

            _unitOfWork.BlockUnit.Update(blockUnit);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Block Unit modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteBlockUnit(int unitId)
    {
        try
        {
            var blockUnit = await _unitOfWork.BlockUnit.Get(unitId);
            if (blockUnit == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Unit with ID {unitId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.BlockUnit.Delete(blockUnit);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Block Unit with ID {unitId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }
}

