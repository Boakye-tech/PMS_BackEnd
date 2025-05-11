// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class CustomerController : ControllerBase
    {

        /// <summary>
        /// Creates a new prospective customer
        /// </summary>
        [HttpPost]
        [Route("AddProspectiveCustomer")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerRegistrationResponseDto))]
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
        [Authorize(Policy = "Permission:Customers.READ")]
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
        /// Modify or update existing company customer details
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
        /// Modify or update existing company customer details
        /// </summary>
        [HttpPut]
        [Route("UpdateCompanyCustomer")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> UpdateCompanyCustomer([FromBody] UpdateCompanyCustomerDto values)
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
                    _ => StatusCode(500, new { response = "Internal Server Error" }),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Returns a list of complaint statuses.
        /// </summary>
        /// <remarks>
        /// This endpoint returns all possible statuses that a complaint can go through.
        /// 
        /// **Sample Request:**
        /// 
        ///     GET /ComplaintStatus
        /// 
        /// **Sample Response:**
        /// 
        ///     [
        ///         {
        ///             "id": 1,
        ///             "name": "SUBMITTED",
        ///             "displayName": "Submit Complaint"
        ///         },
        ///         {
        ///             "id": 2,
        ///             "name": "ACKNOWLEDGED",
        ///             "displayName": "Complaint Acknowledged"
        ///         }
        ///     ]
        /// 
        /// </remarks>
        /// <returns>
        /// Returns HTTP 200 OK with a list of complaint statuses.  
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpGet]
        [Route("ComplaintStatus")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [Authorize(Policy = "Permission:Customers.READ")]
        public IActionResult ComplaintStatus()
        {
            var statuses = Enum.GetValues(typeof(ComplaintStatusEnum))
                                   .Cast<ComplaintStatusEnum>()
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
        /// Returns a list of complaint sources.
        /// </summary>
        /// <remarks>
        /// This endpoint returns all possible sources from which a complaint can originate.
        /// 
        /// **Sample Request:**
        /// 
        ///     GET /ComplaintSources
        /// 
        /// **Sample Response:**
        /// 
        ///     [
        ///         {
        ///             "id": 1,
        ///             "name": "CUSTOMER",
        ///             "displayName": "Online customer self service submission"
        ///         },
        ///         {
        ///             "id": 2,
        ///             "name": "STAFF",
        ///             "displayName": "Offline customer staff assisted submission"
        ///         }
        ///     ]
        ///  
        /// </remarks>
        /// <returns>
        /// Returns HTTP 200 OK with a list of complaint sources.  
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpGet]
        [Route("ComplaintSources")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ComplaintSources()
        {
            var statuses = Enum.GetValues(typeof(ComplaintSourceEnum))
                                   .Cast<ComplaintSourceEnum>()
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
        /// Returns a list of complaints
        /// </summary>
        [HttpGet]
        [Route("GetListOfComplaints")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ComplaintStaffReadDto>))]
        public async Task<ActionResult> GetListOfComplaints([FromQuery] string? searchParameter, [FromQuery] int complaintType, [FromQuery] int complaintStatus, [FromQuery] int departmentId, [FromQuery] int departmentUnitId, [FromQuery] string? userId)
        {
            try
            {

                var _userRole = _userContextService.GetUserRole();

                if (_userRole!.Contains("MIS") || _userRole.Contains("Complaint") || _userRole.Contains("Admin"))
                {
                    //searchParameter = null;
                    complaintType = 0;
                    complaintType = 0;
                    departmentId = 0;
                    departmentUnitId = 0;
                    userId = null;
                }

                if (_userRole!.Contains("Supervisor") || _userRole.Contains("Manager") || _userRole.Contains("Head"))
                {
                    //searchParameter = null;
                    departmentUnitId = 0;
                    userId = null;
                }

                string _parameter = HttpUtility.UrlDecode(searchParameter!);

                var result = await _complaintMasterServices.GetComplaintsList(searchParameter!, complaintType, complaintStatus, departmentId, departmentUnitId, userId!);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }

        }

        /// <summary>
        /// Returns a list of complaints based on a user query/optional parameters
        /// </summary>
        [HttpGet]
        [Route("GetComplaints")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ComplaintStaffReadDto>))]
        public async Task<ActionResult> GetListOfComplaints([FromQuery] string? complaintNumber, [FromQuery] string? customerCode_OR_propertyNumber)
        {
            try
            {
                if (complaintNumber is null && customerCode_OR_propertyNumber is null)
                {
                    return Ok(Array.Empty<string>());
                }

                if (complaintNumber is not null)
                {
                    var result = await _complaintMasterServices.GetComplaintSummary(complaintNumber);
                    return Ok(result);
                }

                if (customerCode_OR_propertyNumber is not null)
                {
                    var result = await _complaintMasterServices.GetCustomerComplaintsList(customerCode_OR_propertyNumber);
                    return Ok(result);
                }

                return Ok(Array.Empty<string>());

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }

        }


        /// <summary>
        /// Returns a list of complainants summary based on customer code or property number parameters
        /// </summary>
        [HttpGet]
        [Route("GetComplainantSearch/{customerCode_OR_propertyNumber}")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ComplainantSearchDto>))]
        public async Task<ActionResult> GetComplainantSearch(string? customerCode_OR_propertyNumber)
        {
            try
            {
                if (customerCode_OR_propertyNumber is not null)
                {
                    string param = HttpUtility.UrlDecode(customerCode_OR_propertyNumber!);
                    var result = await _complaintMasterServices.GetComplainantSearch(param);
                    return Ok(result);
                }

                return Ok(Array.Empty<string>());

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }

        }

        /// <summary>
        /// Returns details of a complaint
        /// </summary>
        [HttpGet]
        [Route("GetComplaintDetails/{complaintNumber}")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(200, Type = typeof(ComplaintDto))]
        public async Task<ActionResult> GetComplaintDetails(string complaintNumber)
        {
            try
            {
                var result = await _complaintMasterServices.GetComplaintDetails(complaintNumber);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }

        }

        /// <summary>
        /// Creates/Submit a new complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to submit a new complaint with all the necessary details.
        ///
        /// **Sample Request:**
        /// 
        ///     POST /SubmitComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintTypeId": 2,
        ///         "natureOfComplaintId": [5, 6],
        ///         "complaintNumber": "C85991",
        ///         "propertyNumber": "CPL/C02/DTA/F/981",
        ///         "propertyLocation": "COMMUNITY 3",
        ///         "customerCode": "2A00137",
        ///         "customerName": "Ama Serwaa",
        ///         "phoneNumber": "0549876543",
        ///         "emailAddress": "ama.serwaa@example.com",
        ///         "isTheMatterInCourt": "No",
        ///         "detailsOfComplaint": "The neighbor's construction is blocking my driveway and causing noise disturbances.",
        ///         "availabilityDate": "2025-04-25T09:00:00",
        ///         "submittedBy": "Ms. Ama Serwaa",
        ///         "submittedBy_PhoneNumber": "0549876543",
        ///         "documentImages": ["https://images/uploads/photo-1537731121640-bc1c4aba9b80.jpg"],
        ///         "source": 1,
        ///         "createdBy": "3fba6d17-3e29-4f61-8d8a-1a1f249cf111"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint submitted successfully with complaint number C85991."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "Nature of complaint cannot be null or empty."
        ///     }
        /// 
        /// **Sample Response 403:**
        /// 
        ///     {
        ///         "responseCode": 403,
        ///         "response": "Sorry you cannot submit complaints on behalf of another staff user."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while processing the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint details to be submitted.</param>
        /// <returns>
        /// Returns HTTP 200 OK with the response if the complaint is successfully submitted.
        /// Returns HTTP 204 No Content if nature of complaint is empty.
        /// Returns HTTP 403 Forbidden if trying to submit on behalf of another staff user.
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpPost]
        [Route("SubmitComplaint")]
        [Authorize(Policy = "Permission:Customers.COMPLAINT")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> SubmitComplaint([FromBody] ComplaintCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                if (values.NatureOfComplaintId!.Count() == 0)
                {
                    return StatusCode(204, "Nature of complaint cannot be null or empty");
                }


                var result = await _complaintMasterServices.CreateNewComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result),
                    404 => NotFound(result),
                    _ => StatusCode(500, result),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Updates/Modifies an existing complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows users to modify an existing complaint by providing the updated details.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /ModifyComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "phoneNumber": "0549876543",
        ///         "emailAddress": "ama.serwaa.updated@example.com",
        ///         "isTheMatterInCourt": "No",
        ///         "detailsOfComplaint": "The construction has now been completed, but it caused significant disruption to my property.",
        ///         "availabilityDate": "2025-04-30T09:00:00",
        ///         "documentImages": ["https://images/uploads/photo-1537731121640-bc1c4aba9b80.jpg"],
        ///         "modifiedBy": "2fba6d17-3e29-4f61-8d8a-1a1f249cf111"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully updated."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not modified."
        ///     }
        /// 
        /// **Sample Response 403:**
        /// 
        ///     {
        ///         "responseCode": 403,
        ///         "response": "You are not authorized to modify this complaint."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while updating the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint details to be updated.</param>
        /// <returns>
        /// Returns HTTP 200 OK with the response if the complaint is successfully updated.
        /// Returns HTTP 204 No Content if no changes were made to the complaint.
        /// Returns HTTP 403 Forbidden if the user is unauthorized to modify the complaint.
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpPut]
        [Route("ModifyComplaint")]
        [Authorize(Policy = "Permission:Complaints.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> ReviewComplaint([FromBody] ComplaintUpdateDto values)
        {
            
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ModifiedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.UpdateComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }

        }

        /// <summary>
        /// Acknowledges a submitted complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to acknowledge receipt of a complaint. 
        /// It marks the complaint as officially received and may trigger further processing workflows.
        /// The request must include the complaint number and the ID of the user acknowledging the complaint.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /AcknowledgeComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "acknowledgedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully acknowledged."
        ///     }
        ///     
        /// **Sample Response 401:**
        /// 
        ///     {
        ///         "responseCode": 401,
        ///         "response": "Unauthorized."
        ///     }
        ///     
        /// **Sample Response 403:**
        /// 
        ///     {
        ///         "responseCode": 403,
        ///         "response": "User forbidden from performing this operation"
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Complaint number C85991 doesnot exist."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while acknowledging the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint acknowledgment details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully acknowledged.
        /// Returns HTTP 401 Unauthorized.
        /// Returns HTTP 403 Forbidden.
        /// Returns HTTP 404 Not Found if the complaint does not exist.
        /// Returns HTTP 500 Internal Server Error if an error occurs.
        /// </returns>
        [HttpPut]
        [Route("AcknowledgeComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> AcknowledgeComplaint([FromBody] ComplaintAcknowledgmentDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.AcknowledgedBy))
                {
                    return Unauthorized();
                }

                if(values.ComplaintNumber!.Count == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent, new { StatusMessage = "The complaint number cannot be empty or null, it must contain at least one valid complaint number." });
                }

                var result = await _complaintMasterServices.AcknowledgeComplaint(values); 
                return result.StatusCode switch
                {
                    200 => Ok(result),
                    204 => StatusCode(StatusCodes.Status204NoContent,result),
                    403 => StatusCode(StatusCodes.Status403Forbidden,result),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result)
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Dispatches a submitted complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to dispatch a complaint to a specific department or unit for handling.
        /// It requires the complaint number, the user dispatching it, and the IDs of the target department and department unit.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /DispatchComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "dispatchedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a",
        ///         "dispatchedTo_DepartmentId": 401,
        ///         "dispatchedTo_DepartmentUnitId": 211
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully dispatched."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not dispatched."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Complaint not found."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while dispatching the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint dispatch details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully dispatched.
        /// Returns HTTP 204 No Content if no changes were made.
        /// Returns HTTP 400 Bad Request if the request is invalid.
        /// Returns HTTP 404 Not Found if the complaint does not exist.
        /// Returns HTTP 500 Internal Server Error if an error occurs.
        /// </returns>
        [HttpPut]
        [Route("DispatchComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> DispatchComplaint([FromBody] ComplaintDispatchedDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.DispatchedBy))
                {
                    return Unauthorized();
                }

                if (values.ComplaintNumber!.Count == 0)
                {
                    return StatusCode(StatusCodes.Status204NoContent, new { StatusMessage = "The complaint number cannot be empty or null, it must contain at least one valid complaint number." });
                }

                var result = await _complaintMasterServices.DispatchComplaint(values); 
                return result.StatusCode switch
                {
                    200 => Ok(result),
                    204 => StatusCode(StatusCodes.Status204NoContent, result),
                    404 => NotFound(result),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Reviews an existing complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to review a previously submitted complaint. 
        /// The review can include feedback or any necessary actions that are part of the complaint process. 
        /// It requires the complaint number and the user performing the review.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /ReviewComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "reviewedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully reviewed."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not reviewed."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Complaint not found."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while reviewing the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint review details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully reviewed.
        /// Returns HTTP 204 No Content if no changes were made to the complaint.
        /// Returns HTTP 400 Bad Request if the request is invalid.
        /// Returns HTTP 404 Not Found if the complaint does not exist.
        /// Returns HTTP 500 Internal Server Error if an error occurs.
        /// </returns>
        [HttpPut]
        [Route("ReviewComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> ReviewComplaint([FromBody] ComplaintReviewDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ReviewedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.ReviewComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result),
                    400 => BadRequest(result),
                    404 => NotFound(result),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Assigns an existing complaint to a user or department.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to assign a previously submitted complaint to a designated user 
        /// or department for further action. The request requires the complaint number, the user assigned to handle 
        /// the complaint, and optionally the user who is assigning the complaint.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /AssignComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "assignedTo": "a56f33bf-1234-42d2-bd10-777efb832f6a",
        ///         "assignedBy": "b76d44a5-9c54-4b7d-bb52-dfe1e798bb1d"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully assigned."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not assigned."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Complaint not found or invalid assignment details."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while assigning the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint assignment details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully assigned.
        /// Returns HTTP 204 No Content if no changes were made to the complaint.
        /// Returns HTTP 400 Bad Request if the request is invalid.
        /// Returns HTTP 404 Not Found if the complaint does not exist or the assignment details are invalid.
        /// Returns HTTP 500 Internal Server Error if an error occurs.
        /// </returns>
        [HttpPut]
        [Route("AssignComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> AssignComplaint([FromBody] ComplaintAssignDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.AssignedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.AssignComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    400 => BadRequest(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Resolves an existing complaint after investigation or action has been completed.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to mark a complaint as resolved. 
        /// It is typically used once the necessary investigation or remedial action has been completed. 
        /// The request must include the complaint number and the ID of the user resolving the complaint. 
        /// Optionally, notes about the resolution can also be provided.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /ResolveComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "resolvedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a",
        ///         "notes": "Issue was resolved by replacing defective meter."
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully resolved."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not resolved."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Complaint not found."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while resolving the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint resolution details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully resolved.
        /// Returns HTTP 204 No Content if no changes were made.
        /// Returns HTTP 400 Bad Request if the request is invalid.
        /// Returns HTTP 404 Not Found if the complaint does not exist.
        /// Returns HTTP 500 Internal Server Error if an error occurs.
        /// </returns>
        [HttpPut]
        [Route("ResolveComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> ResolveComplaint([FromBody] ComplaintResolutionDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ResolvedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.ResolveComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    400 => BadRequest(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Reopens a previously resolved complaint, allowing it to be addressed or investigated further.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to reopen a complaint that was previously marked as resolved. 
        /// This is typically used when a complaint requires additional investigation or was prematurely resolved. 
        /// The request requires the complaint number and the ID of the user performing the reopen action.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /ReopenComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "reopenedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully reopened."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not reopened."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Not found due to invalid complaint number."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while reopening the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint reopening details.</param>
        /// <returns>
        /// Returns HTTP 200 OK if the complaint is successfully reopened.
        /// Returns HTTP 204 No Content if no action was taken.
        /// Returns HTTP 400 Bad Request if the request is malformed.
        /// Returns HTTP 404 Not Found if the complaint does not exist.
        /// Returns HTTP 500 Internal Server Error if an unhandled exception occurs.
        /// </returns>
        [HttpPut]
        [Route("ReopenComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> ReopenComplaint([FromBody] ComplaintReopenedDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ReopenedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.ReopenComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    400 => BadRequest(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Closes a re-opened complaint after resolution or review.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to close a complaint that has been previously re-opened. 
        /// The complaint will be marked as closed once this operation is successful. The request requires the complaint number 
        /// and the user who is closing the complaint.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /CloseComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C85991",
        ///         "closedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C85991 has been successfully closed."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not closed."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        ///     
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Not found due to invalid fields."
        ///     }
        ///     
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while closing the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint closing details.</param>
        /// <returns>
        /// Returns HTTP 200 OK with the response if the complaint is successfully closed.
        /// Returns HTTP 204 No Content if no changes were made to close the complaint.
        /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
        /// Returns HTTP 404 Not Found if the request has invalid fields.
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpPut]
        [Route("CloseComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> CloseComplaint([FromBody] ComplaintClosedDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.ClosedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.CloseComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    400 => BadRequest(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Cancels an existing complaint.
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to cancel a complaint that has not been resolved or processed further. 
        /// The complaint will be marked as cancelled upon successful execution of this operation. The request requires 
        /// the complaint number and the user who is cancelling the complaint.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /CancelComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C12456",
        ///         "cancelledBy": "b61d23af-2345-43b1-9c2d-d1d842a3d9f7"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C12456 has been successfully cancelled."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The complaint was not cancelled."
        ///     }
        /// 
        /// **Sample Response 400:**
        /// 
        ///     {
        ///         "responseCode": 400,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        ///
        /// **Sample Response 404:**
        /// 
        ///     {
        ///         "responseCode": 404,
        ///         "response": "Not found due to invalid fields."
        ///     }
        ///     
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while cancelling the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint cancellation details.</param>
        /// <returns>
        /// Returns HTTP 200 OK with the response if the complaint is successfully cancelled.
        /// Returns HTTP 204 No Content if no changes were made to cancel the complaint.
        /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
        /// Returns HTTP 404 Not Found if the request has invalid fields.
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpPut]
        [Route("CancelComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> CancelComplaint([FromBody] ComplaintCancellationDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CancelledBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.CancelComplaint(values);
                return result.StatusCode switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    400 => BadRequest(result.StatusMessage),
                    404 => NotFound(result.StatusMessage),
                    _ => StatusCode(500, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Change the status of an existing complaint to IN-PROGRESS
        /// </summary>
        /// <remarks>
        /// This endpoint allows authorized users to manually change the status of an existing complaint to the in-progress status, the complaint should have been dispatched, assigned or reviewed. 
        /// The complaint will be marked as in-progress upon successful execution of this operation. The request requires 
        /// the complaint number and the user who is manually changing the complaint's status from the current status to the in-progress status.
        ///
        /// **Sample Request:**
        /// 
        ///     PUT /InProgressComplaint
        /// 
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "complaintNumber": "C12456",
        ///         "inprogressBy": "b61d23af-2345-43b1-9c2d-d1d842a3d9f7"
        ///     }
        /// 
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "responseCode": 200,
        ///         "response": "Complaint C12456 has been successfully been moved from the current status to in-progress."
        ///     }
        /// 
        /// **Sample Response 204:**
        /// 
        ///     {
        ///         "responseCode": 204,
        ///         "response": "No content. The status of the complaint was not changed."
        ///     }
        /// 
        /// **Sample Response 403:**
        /// 
        ///     {
        ///         "responseCode": 403,
        ///         "response": "Bad request due to missing or invalid fields."
        ///     }
        /// 
        /// **Sample Response 500:**
        /// 
        ///     {
        ///         "responseCode": 500,
        ///         "response": "An unexpected error occurred while changing the status of the complaint."
        ///     }
        /// </remarks>
        /// <param name="values">The complaint cancellation details.</param>
        /// <returns>
        /// Returns HTTP 200 OK with the response if the complaint is successfully cancelled.
        /// Returns HTTP 204 No Content if no changes were made to cancel the complaint.
        /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
        /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
        /// </returns>
        [HttpPut]
        [Route("InProgressComplaint")]
        [Authorize(Policy = "Permission:Complaints.UPDATE")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(BaseResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(BaseResponseDto))]
        public async Task<ActionResult> InProgressComplaint([FromBody] ComplaintInProgressDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.InProgressBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.InProgressComplaint(values);
                var status = result.StatusCode;
                return status switch
                {
                    200 => Ok(result.StatusMessage),
                    204 => NoContent(),
                    403 => StatusCode(StatusCodes.Status403Forbidden, result.StatusMessage),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.StatusMessage),
                };

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the details of a complainant using a provided customer code.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches complainant information linked to the specified customer code.
        /// It is typically used to pre-fill or verify complainant data during complaint registration or lookup.
        /// 
        /// **Sample Request:**
        /// 
        ///     GET /GetComplainantDetails/CUST001234
        /// 
        /// **Sample Successful Response (200 OK):**
        /// 
        ///     [
        ///         {
        ///             "propertyNumber": "CPL/C02/DTA/F/980",
        ///             "propertyLocation": "COMMUNITY TWO",
        ///             "customerName": "Kwame Ghana",
        ///             "phoneNumber": "0245678901",
        ///             "emailAddress": "kwame.ghana@example.com"
        ///         }
        ///     ]
        /// 
        /// **Response Codes:**
        /// - 200 OK: Returns a list of complainant details matching the given customer code.
        /// - 403 Forbidden: User does not have the required permissions.
        /// </remarks>
        /// <param name="customerCode">The unique customer code associated with the complainant.</param>
        /// <returns>A list of <see cref="ComplainantDetailsDto"/> records containing complainant information.</returns>
        [HttpGet]
        [Route("GetComplainantDetails/{customerCode}")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ComplainantDetailsDto>))]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Obsolete]
        public async Task<ActionResult<List<ComplainantDetailsDto>>> GetComplainantDetails(string customerCode)
        {
            return Ok(await _complaintMasterServices.GetComplainantDetails(customerCode));
        }

        /// <summary>
        /// Retrieves the details of a complainant using either a provided property number or customer code.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches complainant information linked to the specified property number or customer code.
        /// It is typically used to pre-fill or verify complainant data during complaint registration or lookup.
        /// 
        /// **Sample Request:**
        /// 
        ///     GET /GetComplainantDetails?propertyNumber=RPL/C06/DTA/A/12&customerCode=2MI0106
        /// 
        /// **Sample Successful Response (200 OK):**
        /// 
        ///         {
        ///             "propertyNumber": "CPL/C02/DTA/F/980",
        ///             "propertyLocation": "COMMUNITY TWO",
        ///             "customerName": "Kwame Ghana",
        ///             "phoneNumber": "0245678901",
        ///             "emailAddress": "kwame.ghana@example.com"
        ///         }
        ///                 /// **Sample Successful Response (200 OK):**
        /// 
        ///     [
        ///         {
        ///             "propertyNumber": "CPL/C02/DTA/F/980",
        ///             "propertyLocation": "COMMUNITY TWO",
        ///             "customerName": "Kwame Ghana",
        ///             "phoneNumber": "0245678901",
        ///             "emailAddress": "kwame.ghana@example.com"
        ///         }
        ///     ]
        /// 
        /// **Response Codes:**
        /// - 200 OK: Returns a list of complainant details matching the given property number.
        /// </remarks>
        /// <returns>A list of <see cref="ComplainantDetailsDto"/> records containing complainant information.</returns>
        [HttpGet]
        [Route("GetComplainantDetails")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ComplainantDetailsDto))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ComplainantDetailsDto>))]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetComplainantDetailsByPropertyNumber([FromQuery] string? propertyNumber, [FromQuery] string? customerCode)
        {
            if (!string.IsNullOrWhiteSpace(propertyNumber))
            {
                string _propertyNumber = HttpUtility.UrlDecode(propertyNumber!);
                return Ok(await _complaintMasterServices.GetComplainantDetailsByPropertyNumber(_propertyNumber));
            }

            if (!string.IsNullOrWhiteSpace(customerCode))
            {
                return Ok(await _complaintMasterServices.GetComplainantDetails(customerCode));
            }

            return Ok();
        }

        [HttpGet]
        [Route("GetListOfComplaintsByDepartment/{departmentId}")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ComplainantDetailsDto>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Obsolete]
        public async Task<ActionResult> GetListOfComplaintsByDepartment(int departmentId, [FromQuery] int departmentUnitId, [FromQuery] int complaintStatus)
        {
            if (departmentId == 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new { response = "Department Id cannot be zero." });
            }

            return Ok(await _complaintMasterServices.GetListOfComplaintsByDepartment(departmentId, departmentUnitId,complaintStatus));
        }

        [HttpGet]
        [Route("GetListOfComplaintsByAssignee/{userId}")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ComplainantDetailsDto>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Obsolete]
        public async Task<ActionResult> GetListOfComplaintsByAssignee(string userId, [FromQuery] int complaintStatus)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                return StatusCode(StatusCodes.Status204NoContent, new { response = "User id cannot be null or empty." });
            }

            return Ok(await _complaintMasterServices.GetListOfComplaintsByAssignee(userId,complaintStatus));

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

