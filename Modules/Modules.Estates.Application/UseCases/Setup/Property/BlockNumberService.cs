// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class BlockNumberService: IBlockNumberService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockNumberService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<BlockNumberReadDto> AddBlockNumberAsync(BlockNumberCreateDto values)
    {
        BlockNumber input_values = new(values.blockNumberId, values.blockNumbers!)
        {
            CreatedBy = values.createdby,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.BlockNumber.Insert(input_values);
        await _unitOfWork.Complete();

        return new BlockNumberReadDto(input_values.BlockNumberId, input_values.BlockNumbers!);
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

    public async Task<BlockNumberReadDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values)
    {
        BlockNumber input_values = new(values.blockNumberId, values.blockNumbers!)
        {
            ModifiedBy = values.modifiedby,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.BlockNumber.Update(input_values);
        await _unitOfWork.Complete();

        return new BlockNumberReadDto(input_values.BlockNumberId, input_values.BlockNumbers!);
    }
}

