// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.Invoice.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/07/2025 
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

        //----INVOICE TYPES-----
        /// <summary>
        /// Returns a list of all invoice types in the system
        /// </summary>
        [HttpGet]
        [Route("GetInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<InvoiceTypesReadDto>))]
        public async Task<ActionResult<List<InvoiceTypesReadDto>>> GetInvoiceTypes([FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            return Ok(await _invoiceTypesService.GetInvoiceTypesAsync());
        }

        // POST: api/CreateInvoiceTypes
        /// <summary>
        /// Creates a new invoice type record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new invoice type records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateInvoiceTypes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "invoiceTypeName": "Rent Invoice",
        ///         "invoiceTypeCode": "RENT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Invoice type created successfully.",
        ///         "data": {
        ///             "invoiceTypeId": 1,
        ///             "invoiceTypeName": "Rent Invoice",
        ///             "invoiceTypeCode": "RENT",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateInvoiceTypes([FromBody] InvoiceTypesCreateDto values, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            try
            {
                var response = await _invoiceTypesService.CreateInvoiceTypesAsync(values);
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

        // PUT: api/UpdateInvoiceTypes
        /// <summary>
        /// Updates an existing invoice type record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing invoice type record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateInvoiceTypes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "invoiceTypeId": 1,
        ///         "invoiceTypeName": "Updated Invoice Type",
        ///         "invoiceTypeCode": "UPD",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Invoice type updated successfully.",
        ///         "data": {
        ///             "invoiceTypeId": 1,
        ///             "invoiceTypeName": "Updated Invoice Type",
        ///             "invoiceTypeCode": "UPD",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateInvoiceTypes([FromBody] InvoiceTypesUpdateDto values, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            var response = await _invoiceTypesService.UpdateInvoiceTypesAsync(values);

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
        /// Deletes an existing invoice type record by its ID
        /// </summary>
        /// <param name="invoiceTypeId">The ID of the invoice type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteInvoiceType/{invoiceTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteInvoiceType(int invoiceTypeId, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            try
            {
                var response = await _invoiceTypesService.DeleteInvoiceTypesAsync(invoiceTypeId);

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

        //----DEPARTMENTS-----
        /// <summary>
        /// Returns a list of all departments in the system
        /// </summary>
        [HttpGet]
        [Route("GetDepartments")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DepartmentReadDto>))]
        public async Task<ActionResult<IEnumerable<DepartmentReadDto>>> GetDepartments([FromServices] IDepartmentService _departmentService)
        {
            return Ok(await _departmentService.GetDepartmentAsync());
        }

        /// <summary>
        /// Creates a new department record in the system
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateDepartment
        ///     {
        ///         "departmentId": 0,
        ///         "departmentName": "Finance",
        ///         "createdBy": "user-guid"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateDepartment")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateDepartment([FromBody] DepartmentCreateDto values, [FromServices] IDepartmentService _departmentService)
        {
            var response = await _departmentService.CreateDepartmentAsync(values);
            if (response.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                400 => BadRequest(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Updates an existing department record in the system
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateDepartment
        ///     {
        ///         "departmentId": 1,
        ///         "departmentName": "Updated Department",
        ///         "modifiedBy": "user-guid"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateDepartment([FromBody] DepartmentUpdateDto values, [FromServices] IDepartmentService _departmentService)
        {
            var response = await _departmentService.UpdateDepartmentAsync(values);
            if (response.IsSuccess)
                return Ok(response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                400 => BadRequest(response.ErrorResponse),
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an existing department record by its ID
        /// </summary>
        /// <param name="departmentId">The ID of the department to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteDepartment/{departmentId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteDepartment(int departmentId, [FromServices] IDepartmentService _departmentService)
        {
            var response = await _departmentService.DeleteDepartmentAsync(departmentId);
            if (response.IsSuccess)
                return Ok(response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        //----DEPARTMENT UNITS-----
        /// <summary>
        /// Returns a list of all department units in the system
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentUnits")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DepartmentUnitReadDto>))]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnits([FromServices] IDepartmentUnitService _departmentUnitService)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync());
        }

        /// <summary>
        /// Returns a list of department units for a specific department
        /// </summary>
        /// <param name="departmentId">The ID of the department</param>
        [HttpGet]
        [Route("GetDepartmentUnitsByDepartment/{departmentId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DepartmentUnitReadDto>))]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnitsByDepartment(int departmentId, [FromServices] IDepartmentUnitService _departmentUnitService)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitByDepartmentAsync(departmentId));
        }

        /// <summary>
        /// Creates a new department unit record in the system
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     POST /CreateDepartmentUnit
        ///     {
        ///         "departmentId": 1,
        ///         "unitId": 0,
        ///         "unitName": "Payroll",
        ///         "createdBy": "user-guid"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateDepartmentUnit")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateDepartmentUnit([FromBody] DepartmentUnitCreateDto values, [FromServices] IDepartmentUnitService _departmentUnitService)
        {
            var response = await _departmentUnitService.CreateDepartmentUnitAsync(values);
            if (response.IsSuccess)
                return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                400 => BadRequest(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Updates an existing department unit record in the system
        /// </summary>
        /// <remarks>
        /// **Sample Request:**
        ///
        ///     PUT /UpdateDepartmentUnit
        ///     {
        ///         "departmentId": 1,
        ///         "unitId": 2,
        ///         "unitName": "Updated Unit",
        ///         "modifiedBy": "user-guid"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateDepartmentUnit")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateDepartmentUnit([FromBody] DepartmentUnitUpdateDto values, [FromServices] IDepartmentUnitService _departmentUnitService)
        {
            var response = await _departmentUnitService.UpdateDepartmentUnitAsync(values);
            if (response.IsSuccess)
                return Ok(response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                400 => BadRequest(response.ErrorResponse),
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an existing department unit record by its ID
        /// </summary>
        /// <param name="unitId">The ID of the department unit to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteDepartmentUnit/{unitId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteDepartmentUnit(int unitId, [FromServices] IDepartmentUnitService _departmentUnitService)
        {
            var response = await _departmentUnitService.DeleteDepartmentUnitAsync(unitId);
            if (response.IsSuccess)
                return Ok(response.SuccessResponse);
            var status = response.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }





        




        

    }
}
