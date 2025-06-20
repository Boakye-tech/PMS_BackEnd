// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockNumberService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockNumberService : IBlockNumberService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockNumberService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync()
    {
        var response = await _unitOfWork.BlockNumber.GetAll();
        return _mapper.Map<IEnumerable<BlockNumberReadDto>>(response);
    }

    public async Task<BlockNumberReadDto> GetBlockNumberAsync(int value)
    {
        var response = await _unitOfWork.BlockNumber.Get(value);
        return _mapper.Map<BlockNumberReadDto>(response);
    }

    public async Task<BlockNumberReadDto> GetBlockNumberAsync(string value)
    {
        var response = await _unitOfWork.BlockNumber.Get(bn => bn.BlockNumbers == value);
        return _mapper.Map<BlockNumberReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateBlockNumberAsync(BlockNumberCreateDto values)
    {
        try
        {
            var existingBlockNumber = await _unitOfWork.BlockNumber.Get(bn => bn.BlockNumbers == values.blockNumbers);
            if (existingBlockNumber != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Block Number already exists." },
                    SuccessResponse = null
                };
            }

            var blockNumber = BlockNumber.Create(0, values.blockNumbers!);
            blockNumber.CreatedBy = values.createdby;
            blockNumber.CreatedOn = DateTime.Now;

            _unitOfWork.BlockNumber.Insert(blockNumber);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Block Number created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values)
    {
        try
        {
            var blockNumber = await _unitOfWork.BlockNumber.Get(values.blockNumberId);
            if (blockNumber == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Number with ID {values.blockNumberId} not found." },
                    SuccessResponse = null
                };
            }

            blockNumber.Update(values.blockNumberId, values.blockNumbers!);
            blockNumber.ModifiedBy = values.modifiedby;
            blockNumber.ModifiedOn = DateTime.Now;

            _unitOfWork.BlockNumber.Update(blockNumber);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Block Number modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteBlockNumber(int blockNumberId)
    {
        try
        {
            var blockNumber = await _unitOfWork.BlockNumber.Get(blockNumberId);
            if (blockNumber == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Number with ID {blockNumberId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.BlockNumber.Delete(blockNumber);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Block Number with ID {blockNumberId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

