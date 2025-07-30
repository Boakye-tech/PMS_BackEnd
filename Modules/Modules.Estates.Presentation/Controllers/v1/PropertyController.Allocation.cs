// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Allocation.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {

        /// <summary>
        /// Returns a list of all allocation types
        /// </summary>
        [HttpGet]
        [Route("GetAllocationTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AllocationTypeReadDto))]
        public async Task<ActionResult<IEnumerable<AllocationTypeReadDto>>> GetAllocationTypes([FromServices] IAllocationTypeService _allocationTypeService)
        {
            return Ok(await _allocationTypeService.GetAllocationTypeAsync());
        }

        ///// <summary>
        ///// Returns an allocation type by its value
        ///// </summary>
        ///// <param name="allocationType">The value of the allocation type to retrieve</param>
        //[HttpGet]
        //[Route("GetAllocationType/{allocationType}")]
        //public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationType(string allocationType)
        //{
        //    return Ok(await _propertySetupServices.GetAllocationTypeAsync(allocationType));
        //}

        ///// <summary>
        ///// Returns an allocation type by its ID
        ///// </summary>
        ///// <param name="allocationTypeId">The ID of the allocation type to retrieve</param>
        //[HttpGet]
        //[Route("GetAllocationTypeById/{allocationTypeId}")]
        //public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationTypeById(int allocationTypeId)
        //{
        //    return Ok(await _propertySetupServices.GetAllocationTypeAsync(allocationTypeId));
        //}

        /// <summary>
        /// Creates a new allocation type
        /// </summary>
        /// <remarks>
        /// Creates a new allocation type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateAllocationType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "allocationTypeId": 0,
        ///         "allocationType": "RENTAL",
        ///         "allocationTypeDescription": "Rental allocation",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Allocation type created successfully.",
        ///         "data": {
        ///             "allocationTypeId": 1,
        ///             "allocationType": "RENTAL",
        ///             "allocationTypeDescription": "Rental allocation"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateAllocationType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateAllocationType([FromBody] AllocationTypeCreateDto values, [FromServices] IAllocationTypeService _allocationTypeService)
        {
            try
            {
                var result = await _allocationTypeService.CreateAllocationTypeAsync(values);

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
        /// Updates the details of an existing allocation type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing allocation type based on the allocation type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateAllocationType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "allocationTypeId": 1,
        ///         "allocationType": "RENTAL",
        ///         "allocationTypeDescription": "Updated rental allocation",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Allocation type details modified successfully.",
        ///         "data": {
        ///             "allocationTypeId": 1,
        ///             "allocationType": "RENTAL",
        ///             "allocationTypeDescription": "Updated rental allocation"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateAllocationType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<AllocationTypeReadDto>> UpdateAllocationType([FromBody] AllocationTypeUpdateDto values, [FromServices] IAllocationTypeService _allocationTypeService)
        {
            var result = await _allocationTypeService.UpdateAllocationTypeAsync(values);

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
        /// Deletes an allocation type by its ID
        /// </summary>
        /// <param name="allocationTypeId">The ID of the allocation type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteAllocationType/{allocationTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteAllocationType(int allocationTypeId, [FromServices] IAllocationTypeService _allocationTypeService)
        {
            try
            {
                var result = await _allocationTypeService.DeleteAllocationType(allocationTypeId);

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

