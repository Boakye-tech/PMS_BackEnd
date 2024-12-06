namespace Modules.Estates.Application.Repositories.Setup.Property;

public class BlockSideService: IBlockSideService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockSideService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BlockSideReadDto> AddBlockSideAsync(BlockSideCreateDto values)
    {
        BlockSides input_values = new(values.sideId, values.side!)
        {
            CreatedBy = values.createdby,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.BlockSides.Insert(input_values);
        await _unitOfWork.Complete();

        return new BlockSideReadDto(input_values.SideId, input_values.Side!);
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

    public async Task<BlockSideReadDto> UpdateBlockSideAsync(BlockSideUpdateDto values)
    {
        BlockSides input_values = new(values.sideId, values.side!)
        {
            ModifiedBy = values.modifiedby,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.BlockSides.Update(input_values);
        await _unitOfWork.Complete();

        return new BlockSideReadDto(input_values.SideId, input_values.Side!);
    }
}

