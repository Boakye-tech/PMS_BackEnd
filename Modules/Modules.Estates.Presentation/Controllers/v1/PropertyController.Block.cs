using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Setup;

namespace Modules.Estates.Presentation.Controllers.v1;

public partial class PropertyController
{
    /// <summary>
    /// Returns a list of block numbers
    /// </summary>
    [HttpGet]
    [Route("GetBlockNumber")]
    public async Task<ActionResult<IEnumerable<BlockNumberReadDto>>> GetBlockNumber()
    {
        return Ok(await _blockServices.GetBlockNumberAsync());
    }

    /// <summary>
    /// Creates a new block number
    /// </summary>
    /// <remarks>
    /// Creates a new block number in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockNumberId": 0,
    ///         "blockNumber": "A1",
    ///         "blockDescription": "Block A1",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block number created successfully.",
    ///         "data": {
    ///             "blockNumberId": 1,
    ///             "blockNumber": "A1",
    ///             "blockDescription": "Block A1"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockNumber")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockNumber([FromBody] BlockNumberCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateBlockNumberAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing block number
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing block number based on the block number id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockNumberId": 1,
    ///         "blockNumber": "A1",
    ///         "blockDescription": "Updated Block A1",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block number details modified successfully.",
    ///         "data": {
    ///             "blockNumberId": 1,
    ///             "blockNumber": "A1",
    ///             "blockDescription": "Updated Block A1"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockNumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockNumberReadDto>> UpdateBlockNumber([FromBody] BlockNumberUpdateDto values)
    {
        var result = await _blockServices.UpdateBlockNumberAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes a block number by its ID
    /// </summary>
    /// <param name="blockNumberId">The ID of the block number to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteBlockNumber/{blockNumberId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockNumber(int blockNumberId)
    {
        try
        {
            var result = await _blockServices.DeleteBlockNumber(blockNumberId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Returns a list of block sides
    /// </summary>
    [HttpGet]
    [Route("GetBlockSides")]
    public async Task<ActionResult<IEnumerable<BlockSideReadDto>>> GetBlockSides()
    {
        return Ok(await _blockServices.GetBlockSidesAsync());
    }

    /// <summary>
    /// Creates a new block side
    /// </summary>
    /// <remarks>
    /// Creates a new block side in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockSide
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockSideId": 0,
    ///         "blockSide": "NORTH",
    ///         "blockSideDescription": "North side of the block",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block side created successfully.",
    ///         "data": {
    ///             "blockSideId": 1,
    ///             "blockSide": "NORTH",
    ///             "blockSideDescription": "North side of the block"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockSide")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockSide([FromBody] BlockSideCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateBlockSideAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing block side
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing block side based on the block side id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockSide
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockSideId": 1,
    ///         "blockSide": "NORTH",
    ///         "blockSideDescription": "Updated North side of the block",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block side details modified successfully.",
    ///         "data": {
    ///             "blockSideId": 1,
    ///             "blockSide": "NORTH",
    ///             "blockSideDescription": "Updated North side of the block"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockSide")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockSideReadDto>> UpdateBlockSide([FromBody] BlockSideUpdateDto values)
    {
        var result = await _blockServices.UpdateBlockSideAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes a block side by its ID
    /// </summary>
    /// <param name="blockSideId">The ID of the block side to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteBlockSide/{blockSideId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockSide(int blockSideId)
    {
        try
        {
            var result = await _blockServices.DeleteBlockSide(blockSideId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Returns a list of block types
    /// </summary>
    [HttpGet]
    [Route("GetBlockTypes")]
    public async Task<ActionResult<IEnumerable<BlockTypeReadDto>>> GetBlockTypes()
    {
        return Ok(await _blockServices.GetBlockTypesAsync());
    }

    /// <summary>
    /// Creates a new block type
    /// </summary>
    /// <remarks>
    /// Creates a new block type in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockTypeId": 0,
    ///         "blockType": "RESIDENTIAL",
    ///         "blockTypeDescription": "Residential block type",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block type created successfully.",
    ///         "data": {
    ///             "blockTypeId": 1,
    ///             "blockType": "RESIDENTIAL",
    ///             "blockTypeDescription": "Residential block type"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockType([FromBody] BlockTypeCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateBlockTypeAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing block type
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing block type based on the block type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockTypeId": 1,
    ///         "blockType": "RESIDENTIAL",
    ///         "blockTypeDescription": "Updated Residential block type",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block type details modified successfully.",
    ///         "data": {
    ///             "blockTypeId": 1,
    ///             "blockType": "RESIDENTIAL",
    ///             "blockTypeDescription": "Updated Residential block type"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockTypeReadDto>> UpdateBlockType([FromBody] BlockTypeUpdateDto values)
    {
        var result = await _blockServices.UpdateBlockTypeAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes a block type by its ID
    /// </summary>
    /// <param name="blockTypeId">The ID of the block type to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteBlockType/{blockTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockType(int blockTypeId)
    {
        try
        {
            var result = await _blockServices.DeleteBlockType(blockTypeId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Returns a list of block units
    /// </summary>
    [HttpGet]
    [Route("GetBlockUnits")]
    public async Task<ActionResult<IEnumerable<BlockUnitReadDto>>> GetBlockUnits()
    {
        return Ok(await _blockServices.GetBlockUnitsAsync());
    }

    /// <summary>
    /// Creates a new block unit
    /// </summary>
    /// <remarks>
    /// Creates a new block unit in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockUnit
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockUnitId": 0,
    ///         "blockUnit": "UNIT-1",
    ///         "blockUnitDescription": "Unit 1 in the block",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block unit created successfully.",
    ///         "data": {
    ///             "blockUnitId": 1,
    ///             "blockUnit": "UNIT-1",
    ///             "blockUnitDescription": "Unit 1 in the block"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockUnit")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockUnit([FromBody] BlockUnitCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateBlockUnitAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing block unit
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing block unit based on the block unit id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockUnit
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockUnitId": 1,
    ///         "blockUnit": "UNIT-1",
    ///         "blockUnitDescription": "Updated Unit 1 in the block",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block unit details modified successfully.",
    ///         "data": {
    ///             "blockUnitId": 1,
    ///             "blockUnit": "UNIT-1",
    ///             "blockUnitDescription": "Updated Unit 1 in the block"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockUnit")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockUnitReadDto>> UpdateBlockUnit([FromBody] BlockUnitUpdateDto values)
    {
        var result = await _blockServices.UpdateBlockUnitAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes a block unit by its ID
    /// </summary>
    /// <param name="blockUnitId">The ID of the block unit to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteBlockUnit/{blockUnitId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockUnit(int blockUnitId)
    {
        try
        {
            var result = await _blockServices.DeleteBlockUnit(blockUnitId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }
}