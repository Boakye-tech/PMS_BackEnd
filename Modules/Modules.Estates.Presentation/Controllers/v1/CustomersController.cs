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
        public async Task<ActionResult<ProspectiveCustomerResponseDto>> AddProspectiveCustomer([FromBody] ProspectiveCustomerDto values)
        {
            try
            {
                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPost]
        [Route("AddCompanyCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE", Roles = "Estates Officer, Estates Manager")]
        public async Task<ActionResult<CompanyCustomerResponseDto>> AddCompanyCustomer([FromBody] CompanyCustomerDto values)
        {
            try
            {
                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPost]
        [Route("AddIndividualCustomer")]
        public async Task<ActionResult<IndividualCustomerResponseDto>> AddIndividualCustomer([FromBody] IndividualResidentCustomerDto values)
        {
            try
            {
                if(values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.EXPATRIATE)
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

                //if (values.CustomerTypeId == (int)CustomerTypeEnum.INDIVIDUAL && values.ResidentTypeId == (int)ResidentTypeEnum.RESIDENT)
                //{
                //}

                return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPost]
        [Route("AddJointCustomer")]
        public ActionResult<IndividualCustomerResponseDto> AddJointCustomer([FromBody] JointOwnershipCustomerDto values)
        {
            try
            {
                return Ok();
                //return Ok(await _customerMasterService.CreateCustomer(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //[HttpPost]
        //[Route("AddMultiCustomer")]
        //public async Task<ActionResult<IndividualCustomerResponseDto>> AddMultiCustomer([FromBody] MultiOwnershipCustomerDto values)
        //{
        //    try
        //    {
        //        return Ok(await _customerMasterService.CreateCustomer(values));
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.InnerException!.Message);
        //    }
        //}









    }
}

