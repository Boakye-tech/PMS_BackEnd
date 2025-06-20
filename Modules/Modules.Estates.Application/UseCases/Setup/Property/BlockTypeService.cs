// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockTypeService : IBlockTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BlockTypeReadDto>> GetBlockTypeAsync()
    {
        var response = await _unitOfWork.BlockType.GetAll();
        return _mapper.Map<IEnumerable<BlockTypeReadDto>>(response);
    }

    public async Task<BlockTypeReadDto> GetBlockTypeAsync(int value)
    {
        var response = await _unitOfWork.BlockType.Get(value);
        return _mapper.Map<BlockTypeReadDto>(response);
    }

    public async Task<BlockTypeReadDto> GetBlockTypeAsync(string value)
    {
        var response = await _unitOfWork.BlockType.Get(bt => bt.BlockType == value);
        return _mapper.Map<BlockTypeReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateBlockTypeAsync(BlockTypeCreateDto values)
    {
        try
        {
            var existingType = await _unitOfWork.BlockType.Get(bt => bt.BlockType == values.blockType);
            if (existingType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Block Type already exists." },
                    SuccessResponse = null
                };
            }

            var blockType = BlockTypes.Create(0, values.blockType);
            blockType.CreatedBy = values.createdby;
            blockType.CreatedOn = DateTime.Now;

            _unitOfWork.BlockType.Insert(blockType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Block Type created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateBlockTypeAsync(BlockTypeUpdateDto values)
    {
        try
        {
            var blockType = await _unitOfWork.BlockType.Get(values.blockTypeId);
            if (blockType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Type with ID {values.blockTypeId} not found." },
                    SuccessResponse = null
                };
            }

            blockType.Update(values.blockTypeId, values.blockType);
            blockType.ModifiedBy = values.modifiedby;
            blockType.ModifiedOn = DateTime.Now;

            _unitOfWork.BlockType.Update(blockType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Block Type modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteBlockType(int blockTypeId)
    {
        try
        {
            var blockType = await _unitOfWork.BlockType.Get(blockTypeId);
            if (blockType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Type with ID {blockTypeId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.BlockType.Delete(blockType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Block Type with ID {blockTypeId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

