using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.Enums;
using Modules.Estates.Presentation.Constants;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Modules.Estates.Presentation.Controllers.v1
{
    /// <summary>
    /// Presentation controller to handle all customer management related routes
    /// </summary>
    public partial class CustomerController : ControllerBase
    {

        /// <summary>
        /// Creates a new prospective customer
        /// </summary>
        [HttpPost]
        [Route("AddProspectiveCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddProspectiveCustomer([FromBody] ProspectiveCustomerCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _customerMasterService.CreateCustomer(values);
                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.StatusCode;
                return status switch
                {
                    204 => NoContent(),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(500, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Creates a new company customer
        /// </summary>
        [HttpPost]
        [Route("AddCompanyCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddCompanyCustomer([FromBody] CreateCompanyCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _customerMasterService.CreateCustomer(values);
                if(result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.StatusCode;
                return status switch
                {
                    204 => NoContent(),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(500, result.ErrorResponse),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Creates a new individual customer across three residential status (i.e. Expatriate, Non-Resident and Resident)
        /// </summary>
        [HttpPost]
        [Route("AddIndividualCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddIndividualCustomer([FromBody] IndividualResidentCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.CreatedBy!))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }


                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Creates a new joint-customer across three residential status (i.e. Expatriate, Non-Resident and Resident)
        /// </summary>
        [HttpPost]
        [Route("AddJointCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddJointCustomer([FromBody] JointOwnershipCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.CreatedBy!))
                {
                    return Unauthorized();
                }

                var cnt = values.CoLesse!.Count();
                if (cnt == 0)
                {
                    return BadRequest(CustomerConstants.ErrorCoLesseEmpty);
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }


                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Creates a new multi-customer across three residential status (i.e. Expatriate, Non-Resident and Resident)
        /// </summary>
        [HttpPost]
        [Route("AddMultiCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddMultiCustomer([FromBody] MultiOwnershipCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.CreatedBy!))
                {
                    return Unauthorized();
                }

                var cnt = values.Dependent!.Count();
                if (cnt == 0)
                {
                    return BadRequest(CustomerConstants.ErrorDependentEmpty);
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }


                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Approve customers with a pending status
        /// </summary>
        [HttpPut]
        [Route("ApproveCustomer")]
        [Authorize(Policy = "Permission:Customers.APPROVE")]
        public async Task<ActionResult> StopCustomerDebit([FromBody] ApproveCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.approvedBy))
                {
                    return Unauthorized();
                }

                var status = await _customerMasterService.ApproveCustomerAsync(values);

                return status switch
                {
                    200 => Ok("success"),
                    400 => BadRequest(),
                    404 => NotFound($"Customer code {values.customerCode} not found"),
                    500 => StatusCode(500, "unsuccessful"),
                    _ => StatusCode(500, "Internal Server Error"),
                }; ;

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Returns customer details based on a valid customer code
        /// </summary>
        [HttpGet]
        [Route("GetCustomerDetails/{customerCode}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetCustomer(string customerCode)
        {
            try
            {
                var result = await _customerMasterService.GetCustomer(customerCode);
                if (result is null)
                {
                    return NotFound($"Customer Code {customerCode} not found!");
                }

                if (result.CustomerTypeId == (int)CustomerTypeEnum.PROSPECTIVE)
                {
                    return Ok(await _customerMasterService.GetProspectiveCustomerDetails(customerCode));
                }

                if (result.CustomerTypeId == (int)CustomerTypeEnum.COMPANY)
                {
                    return Ok(await _customerMasterService.GetCompanyCustomerDetails(customerCode));
                }

                if (result.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL)
                {
                    return Ok(await _customerMasterService.GetIndividualCustomerDetails(customerCode));
                }

                if (result.CustomerTypeId == (int)CustomerTypeEnum.JOINT_OWNERSHIP)
                {
                    return Ok(await _customerMasterService.GetJointCustomerDetails(customerCode));
                }

                if (result.CustomerTypeId == (int)CustomerTypeEnum.MULTI_OWNERSHIP)
                {
                    return Ok(await _customerMasterService.GetMultiCustomerDetails(customerCode));
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
            
        }

        /// <summary>
        /// <Modify or update existing company customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateProspectiveCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateProspectiveCustomer([FromBody] UpdateProspectiveCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }

                var result = await _customerMasterService.UpdateCustomer(values);
                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.StatusCode;
                return status switch
                {
                    204 => NoContent(),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(500, result.ErrorResponse),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }



        /// <summary>
        /// <Modify or update existing company customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateCompanyCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateCompanyCustomer([FromBody] UpdateCompanyCustomerDto values)
        {
            try
            {
                //if(ModelState.IsValid)

                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }

                var result = await _customerMasterService.UpdateCustomer(values);
                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.StatusCode;
                return status switch
                {
                    204 => NoContent(),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(500, result.ErrorResponse),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify or update existing individual customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateIndividualCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [Obsolete("UpdateIndividualCustomer endpoint is obsolete and would be removed in future releases. Please use the UpdateCustomerDetails endpoint")]
        public async Task<ActionResult> UpdateIndividualCustomer([FromBody] UpdateIndividualResidentCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.ModifiedBy!))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }

                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify or update existing joint-customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateJointCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [Obsolete("UpdateJointCustomer endpoint is obsolete and would be removed in future releases. Please use the UpdateCustomerDetails endpoint")]
        public async Task<ActionResult> UpdateJointCustomer([FromBody] UpdateJointOwnershipCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.ModifiedBy!))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }


                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify or update existing multi-customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateMultiCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [Obsolete("UpdateMultiCustomer endpoint is obsolete and would be removed in future releases. Please use the UpdateCustomerDetails endpoint")]
        public async Task<ActionResult> UpdateMultiCustomer([FromBody] UpdateMultiOwnershipCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.ModifiedBy!))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }

                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify or update existing non-company customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateCustomerDetails")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateCustomerDetails([FromBody] UpdateIndividualResidentCustomerDto values)
        {
            try
            {
                if (!IsAuthorized(values.ModifiedBy!))
                {
                    return Unauthorized();
                }

                var validationError = ValidateCustomerDetails(values);
                if (validationError is not null)
                {
                    return BadRequest(validationError);
                }

                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }


        /// <summary>
        /// Remove or delete existing customer details
        /// </summary>
        [HttpDelete("DeleteCustomer/{customerCode}/{deletedBy}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteCustomer(string customerCode, string deletedBy)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerCode) && string.IsNullOrWhiteSpace(deletedBy))
                {
                    return BadRequest("Customer code and or deleted by cannot be empty or null");
                }

                var values = new DeleteCustomerRequestDto(customerCode, deletedBy);
                var response = await _customerMasterService.DeleteCustomerAsync(values);

                return response switch
                {
                    200 => Ok("Deleted successfully."),
                    400 => BadRequest(),
                    404 => NotFound("Customer code provided cannot be found"),
                    _ => StatusCode(500, "Internal Server Error"),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Activate customer stop debit
        /// </summary>
        [HttpPut]
        [Route("StopCustomerDebit")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> StopCustomerDebit([FromBody] StopDebitRequestDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ActionBy))
                {
                    return Unauthorized();
                }

                var status = await _customerMasterService.StopCustomerDebitAsync(values);

                return status switch
                {
                    200 => Ok( new{ response = "success" }),
                    400 => BadRequest(),
                    404 => NotFound(new { response = $"Customer code {values.CustomerCode} not found" }),
                    500 => StatusCode(500, new { response = "unsuccessful" }),
                    _ => StatusCode(500, new { response = "Internal Server Error" }),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Deactivate customer stop debit
        /// </summary>
        [HttpPut]
        [Route("UnstopCustomerDebit")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UnstopCustomerDebit([FromBody] StopDebitRequestDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ActionBy))
                {
                    return Unauthorized();
                }

                var status = await _customerMasterService.StopCustomerDebitAsync(values);

                return status switch
                {
                    200 => Ok(new { response = "success" }),
                    400 => BadRequest(),
                    404 => NotFound(new { response = $"Customer code {values.CustomerCode} not found" }),
                    500 => StatusCode(500, new { response = "unsuccessful" }),
                    _ => StatusCode(500, new { response = "Internal Server Error" }),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }


        /// <summary>
        /// Checks if the current user is authorized.
        /// </summary>
        private bool IsAuthorized(string modifiedBy)
        {
            var userId = _userContextService.GetUserId();
            return string.Equals(userId, modifiedBy);
        }

        /// <summary>
        /// Validates the customer details and returns an error message if validation fails.
        /// </summary>
        private string? ValidateCustomerDetails(dynamic values)
        {
            return values.ResidentTypeId switch
            {
                (int)ResidentTypeEnum.EXPATRIATE => ValidateExpatriate(values.Expatriate),
                (int)ResidentTypeEnum.NON_RESIDENT => ValidateNonResident(values.NonResident),
                _ => null
            };
        }

        /// <summary>
        /// Validates expatriate details.
        /// </summary>
        private static string? ValidateExpatriate(IndividualExpatriateCustomerDto? expatriate)
        {
            if (expatriate is null) return CustomerConstants.ErrorExpatriateNull;
            if (string.IsNullOrWhiteSpace(expatriate.ResidentPermitNumber)) return CustomerConstants.ErrorResidentPermitNull;
            return null;
        }

        /// <summary>
        /// Validates non-resident details.
        /// </summary>
        private static string? ValidateNonResident(IndividualNonResidentCustomerDto? nonResident)
        {
            if (nonResident is null) return CustomerConstants.ErrorNonResidentNull;
            if (string.IsNullOrWhiteSpace(nonResident.ContactPerson_FullName)) return CustomerConstants.ErrorContactFullNameNull;
            if (string.IsNullOrWhiteSpace(nonResident.ContactPerson_EmailAddress)) return CustomerConstants.ErrorContactEmailNull;
            if (string.IsNullOrWhiteSpace(nonResident.ContactPerson_PhoneNumber)) return CustomerConstants.ErrorContactPhoneNull;
            return null;
        }



    }
}

