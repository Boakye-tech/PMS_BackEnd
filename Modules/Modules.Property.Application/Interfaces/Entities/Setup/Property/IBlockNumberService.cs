namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockNumberService
{
    Task<BlockNumberReadDto> AddBlockNumberAsync(BlockNumberCreateDto values);
    Task<BlockNumberReadDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values);
    Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync();
    Task<BlockNumberReadDto> GetBlockNumberAsync(int value);
    Task<BlockNumberReadDto> GetBlockNumberAsync(string value);
}

