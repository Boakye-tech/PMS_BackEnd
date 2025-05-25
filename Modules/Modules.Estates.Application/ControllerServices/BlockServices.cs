// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/ControllerServices/BlockServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 12:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.ControllerServices;

public class BlockServices : IBlockServices
{
    public IBlockNumberService BlockNumberService { get; }
    public IBlockSideService BlockSideService { get; }
    public IBlockTypeService BlockTypeService { get; }
    public IBlockUnitService BlockUnitService { get; }

    public IFloorAreaService FloorAreaService { get; }
    public IFloorNumberingService FloorNumberingService { get; }


    public BlockServices(IBlockNumberService blockNumberService, IBlockSideService blockSideService, IBlockTypeService blockTypeService, IBlockUnitService blockUnitService, IFloorAreaService floorAreaService, IFloorNumberingService floorNumberingService)
    {
        BlockNumberService = blockNumberService;
        BlockSideService = blockSideService;
        BlockTypeService = blockTypeService;
        BlockUnitService = blockUnitService;

        FloorAreaService = floorAreaService;
        FloorNumberingService = floorNumberingService;
    }

    // Block Number methods
    public async Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync() =>
        await BlockNumberService.GetBlockNumberAsync();

    public async Task<ReturnResponsesDto> CreateBlockNumberAsync(BlockNumberCreateDto values) =>
        await BlockNumberService.CreateBlockNumberAsync(values);

    public async Task<ReturnResponsesDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values) =>
        await BlockNumberService.UpdateBlockNumberAsync(values);

    public async Task<ReturnResponsesDto> DeleteBlockNumber(int blockNumberId) =>
        await BlockNumberService.DeleteBlockNumber(blockNumberId);

    // Block Side methods
    public async Task<IEnumerable<BlockSideReadDto>> GetBlockSidesAsync() =>
        await BlockSideService.GetBlockSideAsync();

    public async Task<ReturnResponsesDto> CreateBlockSideAsync(BlockSideCreateDto values) =>
        await BlockSideService.CreateBlockSideAsync(values);

    public async Task<ReturnResponsesDto> UpdateBlockSideAsync(BlockSideUpdateDto values) =>
        await BlockSideService.UpdateBlockSideAsync(values);

    public async Task<ReturnResponsesDto> DeleteBlockSide(int blockSideId) =>
        await BlockSideService.DeleteBlockSide(blockSideId);

    // Block Type methods
    public async Task<IEnumerable<BlockTypeReadDto>> GetBlockTypesAsync() =>
        await BlockTypeService.GetBlockTypeAsync();

    public async Task<ReturnResponsesDto> CreateBlockTypeAsync(BlockTypeCreateDto values) =>
        await BlockTypeService.CreateBlockTypeAsync(values);

    public async Task<ReturnResponsesDto> UpdateBlockTypeAsync(BlockTypeUpdateDto values) =>
        await BlockTypeService.UpdateBlockTypeAsync(values);

    public async Task<ReturnResponsesDto> DeleteBlockType(int blockTypeId) =>
        await BlockTypeService.DeleteBlockType(blockTypeId);

    // Block Unit methods
    public async Task<IEnumerable<BlockUnitReadDto>> GetBlockUnitsAsync() =>
        await BlockUnitService.GetBlockUnitAsync();

    public async Task<ReturnResponsesDto> CreateBlockUnitAsync(BlockUnitCreateDto values) =>
        await BlockUnitService.CreateBlockUnitAsync(values);

    public async Task<ReturnResponsesDto> UpdateBlockUnitAsync(BlockUnitUpdateDto values) =>
        await BlockUnitService.UpdateBlockUnitAsync(values);

    public async Task<ReturnResponsesDto> DeleteBlockUnit(int blockUnitId) =>
        await BlockUnitService.DeleteBlockUnit(blockUnitId);


    // Floor Area methods
    public async Task<IEnumerable<FloorAreaReadDto>> GetFloorAreaAsync() =>
        await FloorAreaService.GetFloorAreaAsync();

    public async Task<ReturnResponsesDto> CreateFloorAreaAsync(FloorAreaCreateDto values) =>
        await FloorAreaService.CreateFloorAreaAsync(values);

    public async Task<ReturnResponsesDto> UpdateFloorAreaAsync(FloorAreaUpdateDto values) =>
        await FloorAreaService.UpdateFloorAreaAsync(values);

    public async Task<ReturnResponsesDto> DeleteFloorArea(int floorAreaId) =>
        await FloorAreaService.DeleteFloorArea(floorAreaId);


    // Floor Numbering methods
    public async Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync() =>
        await FloorNumberingService.GetFloorNumberingAsync();

    public async Task<ReturnResponsesDto> CreateFloorNumberAsync(FloorNumberingCreateDto values) =>
        await FloorNumberingService.CreateFloorNumberingAsync(values);

    public async Task<ReturnResponsesDto> UpdateFloorNumberAsync(FloorNumberingUpdateDto values) =>
        await FloorNumberingService.UpdateFloorNumberingAsync(values);

    public async Task<ReturnResponsesDto> DeleteFloorNumbering(int floorNumberingId) =>
        await FloorNumberingService.DeleteFloorNumbering(floorNumberingId);
}