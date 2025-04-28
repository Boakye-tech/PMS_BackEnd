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
        /// Returns a list of complaint status
        /// </summary>
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
        /// Returns a list of complaints
        /// </summary>
        [HttpGet]
        [Route("GetListOfComplaints")]
        [Authorize(Policy = "Permission:Customers.READ")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ComplaintStaffReadDto>))]
        public async Task<ActionResult> GetListOfComplaints()
        {
            try
            {
                var result = await _complaintMasterServices.GetComplaintsList();
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
        /// Acknowledges a submitted complaint
        /// </summary>
        [HttpPut]
        [Route("AcknowledgeComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> AcknowledgeComplaint([FromBody] ComplaintAcknowledgmentDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.AcknowledgedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.AcknowledgeComplaint(values); 
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
        /// Dispatches a submitted complaint
        /// </summary>
        [HttpPut]
        [Route("DispatchComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult> DispatchComplaint([FromBody] ComplaintDispatchedDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.DispatchedBy))
                {
                    return Unauthorized();
                }

                var result = await _complaintMasterServices.DispatchComplaint(values); 
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
        /// Reviews an existing complaint
        /// </summary>
        [HttpPut]
        [Route("ReviewComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
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
        /// Assigns an existing complaint
        /// </summary>
        [HttpPut]
        [Route("AssignComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
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
        /// Resolve an existing complaint
        /// </summary>
        [HttpPut]
        [Route("ResolveComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
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
        /// Reopens a resolved complaint
        /// </summary>
        [HttpPut]
        [Route("ReopenComplaint")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
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

