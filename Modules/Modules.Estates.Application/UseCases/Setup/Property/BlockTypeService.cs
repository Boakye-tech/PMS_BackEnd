namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockTypeService: IBlockTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BlockTypeReadDto> AddBlockTypeAsync(BlockTypeCreateDto values)
    {
        BlockTypes input_values = new(values.blockTypeId, values.blockType!)
        {
            CreatedBy = values.createdby,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.BlockType.Insert(input_values);
        await _unitOfWork.Complete();

        return new BlockTypeReadDto(input_values.BlockTypeId, input_values.BlockType!);
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

    public async Task<BlockTypeReadDto> UpdateBlockTypeAsync(BlockTypeUpdateDto values)
    {
        BlockTypes input_values = new(values.blockTypeId, values.blockType!)
        {
            ModifiedBy = values.modifiedby,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.BlockType.Update(input_values);
        await _unitOfWork.Complete();

        return new BlockTypeReadDto(input_values.BlockTypeId, input_values.BlockType!);
    }
}

