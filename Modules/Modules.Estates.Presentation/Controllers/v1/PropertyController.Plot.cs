// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Plot.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of plot dimensions
        /// </summary>
        [HttpGet]
        [Route("GetPlotDimensions")]
        public async Task<ActionResult<IEnumerable<PlotDimensionReadDto>>> GetPlotDimensions([FromServices] IPlotDimensionService _plotDimensionService)
        {
            return Ok(await _plotDimensionService.GetPlotDimensionAsync());
        }

        /// <summary>
        /// Returns a plot dimension by its value
        /// </summary>
        /// <param name="value">The value of the plot dimension to retrieve</param>
        [HttpGet]
        [Route("GetPlotDimension/{value}")]
        public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimension(string value, [FromServices] IPlotDimensionService _plotDimensionService)
        {
            return Ok(await _plotDimensionService.GetPlotDimensionAsync(value));
        }

        /// <summary>
        /// Returns a plot dimension by its ID
        /// </summary>
        /// <param name="plotDimensionId">The ID of the plot dimension to retrieve</param>
        [HttpGet]
        [Route("GetPlotDimensionById/{plotDimensionId}")]
        public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimensionById(int plotDimensionId, [FromServices] IPlotDimensionService _plotDimensionService)
        {
            return Ok(await _plotDimensionService.GetPlotDimensionAsync(plotDimensionId));
        }

        /// <summary>
        /// Creates a new plot dimension
        /// </summary>
        /// <remarks>
        /// Creates a new plot dimension in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePlotDimension
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "plotDimensionId": 0,
        ///         "plotDimension": "100x100",
        ///         "plotDimensionDescription": "100 meters by 100 meters",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Plot dimension created successfully.",
        ///         "data": {
        ///             "plotDimensionId": 1,
        ///             "plotDimension": "100x100",
        ///             "plotDimensionDescription": "100 meters by 100 meters"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePlotDimension")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePlotDimension([FromBody] PlotDimensionCreateDto values, [FromServices] IPlotDimensionService _plotDimensionService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _plotDimensionService.CreatePlotDimensionAsync(values);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing plot dimension
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing plot dimension based on the plot dimension id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePlotDimension
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "plotDimensionId": 1,
        ///         "plotDimension": "100x100",
        ///         "plotDimensionDescription": "Updated 100 meters by 100 meters",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Plot dimension details modified successfully.",
        ///         "data": {
        ///             "plotDimensionId": 1,
        ///             "plotDimension": "100x100",
        ///             "plotDimensionDescription": "Updated 100 meters by 100 meters"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePlotDimension")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PlotDimensionReadDto>> UpdatePlotDimension([FromBody] PlotDimensionUpdateDto values, [FromServices] IPlotDimensionService _plotDimensionService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _plotDimensionService.UpdatePlotDimensionAsync(values);

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
        /// Deletes a plot dimension by its ID
        /// </summary>
        /// <param name="plotDimensionId">The ID of the plot dimension to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePlotDimension/{plotDimensionId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePlotDimension(int plotDimensionId, [FromServices] IPlotDimensionService _plotDimensionService)
        {
            try
            {
                var result = await _plotDimensionService.DeletePlotDimension(plotDimensionId);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        /// <summary>
        /// Returns a list of plot types
        /// </summary>
        [HttpGet]
        [Route("GetPlotTypes")]
        public async Task<ActionResult<IEnumerable<PlotTypeReadDto>>> GetPlotTypes([FromServices] IPlotTypeService _plotTypeService)
        {
            return Ok(await _plotTypeService.GetPlotTypeAsync());
        }

        /// <summary>
        /// Creates a new plot type
        /// </summary>
        /// <remarks>
        /// Creates a new property type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePlotType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PlotTypeId": 0,
        ///         "PlotType": "SERVICED PLOT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Plot type created successfully."
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePlotType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePlotType([FromBody] PlotTypeCreateDto values, [FromServices] IPlotTypeService _plotTypeService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _plotTypeService.CreatePlotTypeAsync(values);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing plot type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing plot type based on the plot type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePlotType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PlotTypeId": 1,
        ///         "PlotType": "SEMI-SERVICED PLOT",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Plot type details modified successfully."
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePlotType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PlotTypeReadDto>> UpdatePlotType([FromBody] PlotTypeUpdateDto values, [FromServices] IPlotTypeService _plotTypeService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _plotTypeService.UpdatePlotTypeAsync(values);

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
        /// Deletes a property type by its ID
        /// </summary>
        /// <param name="PlotTypeId">The ID of the property type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePlotType/{plotTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePlotType(int plotTypeId, [FromServices] IPlotTypeService _plotTypeService)
        {
            try
            {
                var result = await _plotTypeService.DeletePlotType(plotTypeId);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}