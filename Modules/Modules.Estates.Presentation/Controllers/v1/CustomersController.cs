using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.Enums;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{

    public partial class CustomerController : ControllerBase
    {

        //readonly ICustomerMasterService _customerMasterService;

        //public CustomerController(ICustomerMasterService customerMasterService)
        //{
        //    _customerMasterService = customerMasterService;
        //}


        //------------------
        [HttpPost]
        [Route("AddProspectiveCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddProspectiveCustomer([FromBody] ProspectiveCustomerDto values)
        {
            try
            {
                //return Ok(await _customerMasterService.CreateCustomer(values));

                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _customerMasterService.CreateCustomer(values);
                if (result.IsSuccess == true)
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

        [HttpPost]
        [Route("AddCompanyCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddCompanyCustomer([FromBody] CreateCompanyCustomerDto values)
        {
            try
            {
                //if(ModelState.IsValid)

                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _customerMasterService.CreateCustomer(values);
                if(result.IsSuccess == true)
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

        [HttpPost]
        [Route("AddIndividualCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddIndividualCustomer([FromBody] IndividualResidentCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }

                   
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }

                }

                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPost]
        [Route("AddJointCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddJointCustomer([FromBody] JointOwnershipCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var cnt = values.CoLesse!.Count();
                if (cnt == 0)
                {
                    return BadRequest("Co-Lesse cannot be empty or null");
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.JOINT_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.JOINT_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }
                }


                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPost]
        [Route("AddMultiCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult> AddMultiCustomer([FromBody] MultiOwnershipCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var cnt = values.Dependent!.Count();
                if (cnt == 0)
                {
                    return BadRequest("Dependant cannot be empty or null");
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.MULTI_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.MULTI_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }
                }


                return Ok(await _customerMasterService.CreateCustomer(values));
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

                var result = await _customerMasterService.UpdateCustomer(values);
                if (result.IsSuccess == true)
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

        [HttpPut]
        [Route("UpdateIndividualCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateIndividualCustomer([FromBody] UpdateIndividualResidentCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }


                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }

                }

                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateJointCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateJointCustomer([FromBody] UpdateJointOwnershipCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                var cnt = values.CoLesse!.Count();
                if (cnt == 0)
                {
                    return BadRequest("Co-Lesse cannot be empty or null");
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.JOINT_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.JOINT_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }
                }


                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateMultiCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateMultiCustomer([FromBody] UpdateMultiOwnershipCustomerDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                var cnt = values.Dependent!.Count();
                if (cnt == 0)
                {
                    return BadRequest("Dependant cannot be empty or null");
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.MULTI_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
                {
                    if (values.Expatriate is null)
                    {
                        return BadRequest("Expatriate details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.Expatriate!.ResidentPermitNumber))
                    {
                        return BadRequest("Resident permit number cannot be null or empty.");
                    }
                }

                if (values.CustomerTypeId == (int)CustomerTypeEnum.MULTI_OWNERSHIP && values.ResidentTypeId == (int)ResidentTypeEnum.NON_RESIDENT)
                {
                    if (values.NonResident is null)
                    {
                        return BadRequest("Non-resident contact person details cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_FullName))
                    {
                        return BadRequest("Contact person's fullname cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_EmailAddress))
                    {
                        return BadRequest("Contact person's email address cannot be null or empty.");
                    }

                    if (string.IsNullOrWhiteSpace(values.NonResident!.ContactPerson_PhoneNumber))
                    {
                        return BadRequest("Contact person's phone number cannot be null or empty.");
                    }
                }


                return Ok(await _customerMasterService.UpdateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }



    }
}

