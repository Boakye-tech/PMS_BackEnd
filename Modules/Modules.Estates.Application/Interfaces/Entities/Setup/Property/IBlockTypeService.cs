namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockTypeService
{
    Task<BlockTypeReadDto> AddBlockTypeAsync(BlockTypeCreateDto values);
    Task<BlockTypeReadDto> UpdateBlockTypeAsync(BlockTypeUpdateDto values);
    Task<IEnumerable<BlockTypeReadDto>> GetBlockTypeAsync();
    Task<BlockTypeReadDto> GetBlockTypeAsync(int value);
    Task<BlockTypeReadDto> GetBlockTypeAsync(string value);
}

