// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.Services.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Modules.Finance.Application.Dtos.Setup;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Finance.Presentation.Controllers
{
    public partial class FinanceController : ControllerBase
    {
        //---DEPARTMENT SERVICES-------
        /// <summary>
        /// Returns a list of all departmental services in the system
        /// </summary>
        [HttpGet]
        [Route("GetServices")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ServicesReadDto>))]
        public async Task<ActionResult<List<ServicesReadDto>>> GetServices([FromServices] IServicesService _services)
        {
            return Ok(await _services.GetServicesAsync());
        }

        // POST: api/CreateServices
        /// <summary>
        /// Creates a new departmental service record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new departmental service for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateServices
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "DepartmentId": 301,
        ///         "RoomNumber": 330,
        ///         "ServiceName": "TRANSFERS",
        ///         "Description": "TRANSFER FEE",
        ///         "HasFee": true,
        ///         "Amount": 600,
        ///         "AccountCode": 500301
        ///         "CreatedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Departmental services created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateServices")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateServices([FromServices] IServicesService _services, [FromBody] ServicesCreateDto values)
        {
            try
            {
                var response = await _services.CreateServicesAsync(values);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
                }
                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                    400 => BadRequest(response.ErrorResponse),
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT: api/UpdateServices
        /// <summary>
        /// Updates an existing departmental service record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing departmental service record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateServices
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "DepartmentId": 301,
        ///         "RoomNumber": 330,
        ///         "ServiceName": "TRANSFERS",
        ///         "Description": "TRANSFER FEE",
        ///         "HasFee": true,
        ///         "Amount": 750,
        ///         "AccountCode": 500301
        ///         "ModifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Departmental services updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateServices")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateServices([FromServices] IServicesService _services, [FromBody] ServicesUpdateDto values)
        {
            var response = await _services.UpdateServicesAsync(values);

            if (response.IsSuccess)
            {
                return Ok(response.SuccessResponse);
            }

            var status = response.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                400 => BadRequest(response.ErrorResponse),
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an existing departmental service record by its ID
        /// </summary>
        /// <param name="serviceId">The ID of the departmental service to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteServices/{serviceId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteServices([FromServices] IServicesService _services, int serviceId)
        {
            try
            {
                var response = await _services.DeleteServicesAsync(serviceId);

                if (response.IsSuccess)
                {
                    return Ok(response.SuccessResponse);
                }

                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }



    }
}
