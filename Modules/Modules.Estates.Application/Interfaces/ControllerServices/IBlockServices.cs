// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IBlockServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:41 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IBlockServices
	{
		// Block Number methods
		Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync();
		Task<ReturnResponsesDto> CreateBlockNumberAsync(BlockNumberCreateDto values);
		Task<ReturnResponsesDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values);
		Task<ReturnResponsesDto> DeleteBlockNumber(int blockNumberId);

		// Block Side methods
		Task<IEnumerable<BlockSideReadDto>> GetBlockSidesAsync();
		Task<ReturnResponsesDto> CreateBlockSideAsync(BlockSideCreateDto values);
		Task<ReturnResponsesDto> UpdateBlockSideAsync(BlockSideUpdateDto values);
		Task<ReturnResponsesDto> DeleteBlockSide(int blockSideId);

		// Block Type methods
		Task<IEnumerable<BlockTypeReadDto>> GetBlockTypesAsync();
		Task<ReturnResponsesDto> CreateBlockTypeAsync(BlockTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateBlockTypeAsync(BlockTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteBlockType(int blockTypeId);

		// Block Unit methods
		Task<IEnumerable<BlockUnitReadDto>> GetBlockUnitsAsync();
		Task<ReturnResponsesDto> CreateBlockUnitAsync(BlockUnitCreateDto values);
		Task<ReturnResponsesDto> UpdateBlockUnitAsync(BlockUnitUpdateDto values);
		Task<ReturnResponsesDto> DeleteBlockUnit(int blockUnitId);

		// Floor Area methods
		Task<IEnumerable<FloorAreaReadDto>> GetFloorAreaAsync();
		Task<ReturnResponsesDto> CreateFloorAreaAsync(FloorAreaCreateDto values);
		Task<ReturnResponsesDto> UpdateFloorAreaAsync(FloorAreaUpdateDto values);
		Task<ReturnResponsesDto> DeleteFloorArea(int floorAreaId);

		// Floor Numbering methods
		Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync();
		Task<ReturnResponsesDto> CreateFloorNumberAsync(FloorNumberingCreateDto values);
		Task<ReturnResponsesDto> UpdateFloorNumberAsync(FloorNumberingUpdateDto values);
		Task<ReturnResponsesDto> DeleteFloorNumbering(int floorNumberingId);
	}
}

