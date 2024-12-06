namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IFloorNumberingService
{
    Task<FloorNumberingReadDto> AddFloorNumberingAsync(FloorNumberingCreateDto values);
    Task<FloorNumberingReadDto> UpdateFloorNumberingAsync(FloorNumberingUpdateDto values);
    Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync();
    Task<FloorNumberingReadDto> GetFloorNumberingAsync(int value);
    Task<FloorNumberingReadDto> GetFloorNumberingAsync(string value);
}

