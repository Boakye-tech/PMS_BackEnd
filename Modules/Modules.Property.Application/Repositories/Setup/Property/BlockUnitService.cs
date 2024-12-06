using System;

namespace Modules.Estates.Application.Repositories.Setup.Property;

public class BlockUnitService: IBlockUnitService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockUnitService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BlockUnitReadDto> AddBlockUnitAsync(BlockUnitCreateDto values)
    {
        BlockUnit input_values = new(values.unitId, values.unit!)
        {
            CreatedBy = values.createdby,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.BlockUnit.Insert(input_values);
        await _unitOfWork.Complete();

        return new BlockUnitReadDto(input_values.UnitId, input_values.Unit!);
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

    public async Task<BlockUnitReadDto> UpdateBlockUnitAsync(BlockUnitUpdateDto values)
    {
        BlockUnit input_values = new(values.unitId, values.unit!)
        {
            ModifiedBy = values.modifiedby,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.BlockUnit.Update(input_values);
        await _unitOfWork.Complete();

        return new BlockUnitReadDto(input_values.UnitId, input_values.Unit!);
    }
}

