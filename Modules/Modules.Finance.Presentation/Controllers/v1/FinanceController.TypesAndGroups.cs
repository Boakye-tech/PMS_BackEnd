// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.TypesAndGroups.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 
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


        //---RENTAL TYPES-------

        /// <summary>
        /// Returns a list of rental and debtor types
        /// </summary>
        [HttpGet]
        [Route("GetRentalAndDebtorTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<RentalAndDebtorTypesDto>))]
        public async Task<ActionResult<List<RentalAndDebtorTypesDto>>> GetRentalAndDebtorTypes([FromServices] IRentalTypesService _rentalTypesService)
        {
            return Ok(await _rentalTypesService.GetRentalAndDebtorTypesAsync());
        }

        /// <summary>
        /// Returns a list of rental types
        /// </summary>
        [HttpGet]
        [Route("GetRentalTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<RentalTypesReadDto>))]
        public async Task<ActionResult<List<RentalTypesReadDto>>> GetRentalTypes([FromServices] IRentalTypesService _rentalTypesService)
        {
            return Ok(await _rentalTypesService.GetRentalTypesAsync());
        }

        // POST: api/CreateRentalType
        /// <summary>
        /// Creates a new rental in the system
        /// </summary>
        /// <remarks>
        /// Addition of new rental type for managing debtor types and groups
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateRentalType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "rentalTypesId": 2,
        ///         "rentalType": "HOUSE RENT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Rental type created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateRentalType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateRentalType([FromServices] IRentalTypesService _rentalTypesService, [FromBody] RentalTypesCreateDto values)
        {
            try
            {
                var response = await _rentalTypesService.CreateRentalTypesAsync(values);
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

        // PUT: api/UpdateRentalType
        /// <summary>
        /// Updates an existing rental type record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing rental type record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateRentalType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "rentalTypesId": 2,
        ///         "rentalType": "HOUSE RENTALS",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Rental type updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateRentalType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateChartOfAccount([FromServices] IRentalTypesService _rentalTypesService, [FromBody] RentalTypesUpdateDto values)
        {
            var response = await _rentalTypesService.UpdateRentalTypesAsync(values);

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
        /// Deletes an rental type record by its ID
        /// </summary>
        /// <param name="rentalTypeId">The ID of the rental type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteRentalType/{rentalTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteRentalType([FromServices] IRentalTypesService _rentalTypesService, int rentalTypeId)
        {
            try
            {
                var response = await _rentalTypesService.DeleteRentalTypesAsync(rentalTypeId);

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

        //----DEBTOR TYPES-----
        /// <summary>
        /// Returns a list of debtor types
        /// </summary>
        [HttpGet]
        [Route("GetDebtorTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<DebtorTypesReadDto>))]
        public async Task<ActionResult<List<DebtorTypesReadDto>>> GetDebtorTypes(IDebtorTypesService _debtorTypesService)
        {
            return Ok(await _debtorTypesService.GetDebtorTypesAsync());
        }

        // POST: api/CreateDebtorTypes
        /// <summary>
        ///  Creates a new debtor type 
        /// </summary>
        ///     
        /// <remarks>
        /// Addition/Creation of new debtor type
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateDebtorTypes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "RentalTypesId": 1,
        ///         "DebtorType": 2,
        ///         "Description": "HOUSES WITHOUT ACREAGE",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Debtor Type created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateDebtorType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateDebtorType(IDebtorTypesService _debtorTypesService, [FromBody] DebtorTypesCreateDto values)
        {
            try
            {
                var response = await _debtorTypesService.CreateDebtorTypesAsync(values);

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

        // PUT: api/UpdateDebtorType
        /// <summary>
        /// Updates an exisiting debtor type
        /// </summary>
        /// <remarks>
        /// Updates the details of exsiting debtor type
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateDebtorType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "RentalTypesId": 1,
        ///         "DebtorTypesId": 1,
        ///         "DebtorType": 2,
        ///         "Description": "SPECIFIC HOUSES WITHOUT ACREAGE",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Debtor type updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateDebtorType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateDebtorType(IDebtorTypesService _debtorTypesService, [FromBody] DebtorTypesUpdateDto values)
        {
            var response = await _debtorTypesService.UpdateDebtorTypesAsync(values);

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
        /// Deletes an exsiting debtor type
        /// </summary>
        /// <param name="DebtorTypeId">The ID of the debtor type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteDebtorType/{DebtorTypesId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteDebtorType(IDebtorTypesService _debtorTypesService, int DebtorTypeId)
        {
            try
            {
                var response = await _debtorTypesService.DeleteDebtorTypesAsync(DebtorTypeId);

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


        //----GROUP NUMBERS-----
        /// <summary>
        /// Returns a list of all forms in the system
        /// </summary>
        [HttpGet]
        [Route("GetGroupNumber")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FormsReadDto>))]
        public async Task<ActionResult<IEnumerable<FormsReadDto>>> GetGroupNumber(IDebtorGroupsService _groupNumberService)
        {
            return Ok(await _groupNumberService.GetDebtorGroupsAsync());
        }

        // POST: api/CreateGroupNumber
        /// <summary>
        /// Creates a new group number in the system
        /// </summary>
        /// <remarks>
        /// Addition of new new group number for debtor type and rental type
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateGroupNumber
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "debtorTypesId": 7,
        ///         "groupName": "2",
        ///         "description": "AGRIC INDUSTRIAL PLOT(PLUS 0.5) OF IND. PLOT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Group Number created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateGroupNumber")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateGroupNumber(IDebtorGroupsService _groupNumberService, [FromBody] DebtorGroupsCreateDto values)
        {
            try
            {
                var response = await _groupNumberService.CreateDebtorGroupsAsync(values);
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

        // PUT: api/UpdateGroupNumber
        /// <summary>
        /// Updates an existing group number record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing group number record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateGroupNumber
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "debtorTypesId": 7,
        ///         "debtorGroupsId": 1,
        ///         "groupName": "2",
        ///         "Description": "AGRIC IND. PLOT(PLUS 0.5 ACREAGE) OF IND. PLOT",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Group number updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateGroupNumber")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateGroupNumber(IDebtorGroupsService _groupNumberService, [FromBody] DebtorGroupsUpdateDto values)
        {
            var response = await _groupNumberService.UpdateDebtorGroupsAsync(values);
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
        /// Deletes an existing group number record by its ID
        /// </summary>
        /// <param name="groupNumberId">The ID of the group number to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteGroupNumber/{groupNumberId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteGroupNumber(IDebtorGroupsService _groupNumberService, int groupNumberId)
        {
            try
            {
                var response = await _groupNumberService.DeleteDebtorGroupsAsync(groupNumberId);

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
