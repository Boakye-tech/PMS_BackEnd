// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockSideService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockSideService : IBlockSideService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockSideService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BlockSideReadDto>> GetBlockSideAsync()
    {
        var response = await _unitOfWork.BlockSides.GetAll();
        return _mapper.Map<IEnumerable<BlockSideReadDto>>(response);
    }

    public async Task<BlockSideReadDto> GetBlockSideAsync(int value)
    {
        var response = await _unitOfWork.BlockSides.Get(value);
        return _mapper.Map<BlockSideReadDto>(response);
    }

    public async Task<BlockSideReadDto> GetBlockSideAsync(string value)
    {
        var response = await _unitOfWork.BlockSides.Get(bs => bs.Side == value);
        return _mapper.Map<BlockSideReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateBlockSideAsync(BlockSideCreateDto values)
    {
        try
        {
            var existingSide = await _unitOfWork.BlockSides.Get(bs => bs.Side == values.side);
            if (existingSide != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Block Side already exists." },
                    SuccessResponse = null
                };
            }

            var blockSide = BlockSides.Create(0, values.side);
            blockSide.CreatedBy = values.createdby;
            blockSide.CreatedOn = DateTime.Now;

            _unitOfWork.BlockSides.Insert(blockSide);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Block Side created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateBlockSideAsync(BlockSideUpdateDto values)
    {
        try
        {
            var blockSide = await _unitOfWork.BlockSides.Get(values.sideId);
            if (blockSide == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Side with ID {values.sideId} not found." },
                    SuccessResponse = null
                };
            }

            blockSide.Update(values.sideId, values.side);
            blockSide.ModifiedBy = values.modifiedby;
            blockSide.ModifiedOn = DateTime.Now;

            _unitOfWork.BlockSides.Update(blockSide);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Block Side modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteBlockSide(int sideId)
    {
        try
        {
            var blockSide = await _unitOfWork.BlockSides.Get(sideId);
            if (blockSide == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Block Side with ID {sideId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.BlockSides.Delete(blockSide);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Block Side with ID {sideId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

