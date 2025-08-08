// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Lease.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {

        // Lease Type and Period endpoints
        /// <summary>
        /// Returns a list of lease types and their associated periods
        /// </summary>
        [HttpGet]
        [Route("GetLeaseTypeAndPeriods")]
        public async Task<ActionResult<IEnumerable<LeaseTypeAndPeriodReadDto>>> GetLeaseTypeAndPeriods([FromServices] ILeaseTypeAndPeriodService _leaseService)
        {
            return Ok(await _leaseService.GetLeaseTypeAndPeriodAsync());
        }

        /// <summary>
        /// Creates a new lease type and period
        /// </summary>
        /// <remarks>
        /// Creates a new lease type and period in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateLeaseTypeAndPeriod
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "leaseTypeAndPeriodId": 0,
        ///         "leaseType": "RESIDENTIAL",
        ///         "leasePeriod": "12",
        ///         "leaseTypeDescription": "12 months residential lease",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Lease type and period created successfully.",
        ///         "data": {
        ///             "leaseTypeAndPeriodId": 1,
        ///             "leaseType": "RESIDENTIAL",
        ///             "leasePeriod": "12",
        ///             "leaseTypeDescription": "12 months residential lease"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateLeaseTypeAndPeriod")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateLeaseTypeAndPeriod([FromBody] LeaseTypeAndPeriodCreateDto values, [FromServices] ILeaseTypeAndPeriodService _leaseService)
        {
            try
            {
                var result = await _leaseService.CreateLeaseTypeAndPeriodAsync(values);

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
        /// Updates the details of an existing lease type and period
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing lease type and period based on the lease type and period id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateLeaseTypeAndPeriod
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "leaseTypeAndPeriodId": 1,
        ///         "leaseType": "RESIDENTIAL",
        ///         "leasePeriod": "12",
        ///         "leaseTypeDescription": "Updated 12 months residential lease",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Lease type and period details modified successfully.",
        ///         "data": {
        ///             "leaseTypeAndPeriodId": 1,
        ///             "leaseType": "RESIDENTIAL",
        ///             "leasePeriod": "12",
        ///             "leaseTypeDescription": "Updated 12 months residential lease"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateLeaseTypeAndPeriod")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LeaseTypeAndPeriodReadDto>> UpdateLeaseTypeAndPeriod([FromBody] LeaseTypeAndPeriodUpdateDto values, [FromServices] ILeaseTypeAndPeriodService _leaseService)
        {
            var result = await _leaseService.UpdateLeaseTypeAndPeriodAsync(values);

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
        /// Deletes a lease type and period by its ID
        /// </summary>
        /// <param name="leaseTypeAndPeriodId">The ID of the lease type and period to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteLeaseTypeAndPeriod/{leaseTypeAndPeriodId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId, [FromServices] ILeaseTypeAndPeriodService _leaseService)
        {
            try
            {
                var result = await _leaseService.DeleteLeaseTypeAndPeriod(leaseTypeAndPeriodId);

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
        /// Returns a list of lease status
        /// </summary>
        [HttpGet]
        //[Authorize(Policy = "Permission:Customers.READ")]
        [Route("LeaseStatusEnum")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult LeaseStatus()
        {
            var statuses = Enum.GetValues(typeof(LeaseStatusEnum))
                                   .Cast<LeaseStatusEnum>()
                                   .Select(e => new
                                   {
                                       Id = (int)e,
                                       Name = e.ToString(),
                                       DisplayName = e.GetType()
                                                     .GetField(e.ToString())!
                                                      .GetCustomAttribute<DescriptionAttribute>()?
                                                      .Description

                                   });
            return Ok(statuses);
        }

        /// <summary>
        /// Returns a list of marital status
        /// </summary>
        [HttpGet]
        //[Authorize(Policy = "Permission:Customers.READ")]
        [Route("LeaseRenewalStatus")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult RenewalStatus()
        {
            var statuses = Enum.GetValues(typeof(RenewalStatusEnum))
                                   .Cast<RenewalStatusEnum>()
                                   .Select(e => new
                                   {
                                       Id = (int)e,
                                       Name = e.ToString(),
                                       DisplayName = e.GetType()
                                                     .GetField(e.ToString())!
                                                      .GetCustomAttribute<DescriptionAttribute>()?
                                                      .Description

                                   });
            return Ok(statuses);
        }

    }
}

