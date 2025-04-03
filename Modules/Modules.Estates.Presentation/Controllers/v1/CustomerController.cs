using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Threading.Tasks;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Common.Infrastructure.Authentication;
using Modules.Estates.Application.Enums;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Policy = "Permission:Customers.READ")]


    /// <summary>
    /// Presentation controller to handle all customer management related routes
    /// </summary>
    public partial class CustomerController : ControllerBase
    {
        readonly ICustomerTypeService _customerTypeService;
        readonly IGenderService _genderService;
        readonly IIdentificationTypeService _identificationTypeService;
        readonly INationalityService _nationalityService;
        readonly IResidentTypeService _residentTypeService;
        readonly ISocialMediaService _socialMediaService;
        readonly ITitleService _titleService;
        readonly IOwnershipTypeService _ownershipTypeService;
        readonly ICustomerMasterService _customerMasterService;
        readonly IUserContextService _userContextService;
        readonly IInterestExpressedService _interestExpressedService;

        public CustomerController(ICustomerTypeService customerTypeService, IGenderService genderService, IIdentificationTypeService identificationTypeService, INationalityService nationalityService, IResidentTypeService residentTypeService,
                                  ISocialMediaService socialMediaService, ITitleService titleService, ICustomerMasterService customerMasterService, IOwnershipTypeService ownershipTypeService, IUserContextService userContextService, IInterestExpressedService interestExpressedService)
        {
            _customerTypeService = customerTypeService;
            _genderService = genderService;
            _identificationTypeService = identificationTypeService;
            _nationalityService = nationalityService;
            _residentTypeService = residentTypeService;
            _socialMediaService = socialMediaService;
            _titleService = titleService;
            _customerMasterService = customerMasterService;
            _ownershipTypeService = ownershipTypeService;
            _userContextService = userContextService;
            _interestExpressedService = interestExpressedService;
        }

        //----------------------CUSTOMER TYPES------------
        /// <summary>
        /// Returns a list of exisitng customer types
        /// </summary>
        [HttpGet]
        [Route("GetCustomerTypes")]
        public async Task<ActionResult<IEnumerable<CustomerTypeReadDto>>> GetCustomerTypes()
        {
            return Ok(await _customerTypeService.GetCustomerTypeAsync());
        }

        /// <summary>
        ///  Create a new customer type
        /// </summary>
        /// 
        /// <remarks>
        /// Categories into which various customers are grouped
        ///
        /// Sample Request:
        ///
        /// POST /CreateCustomerType
        /// 
        /// {
        ///    "customerTypeId": 0,
        ///    "customerTypes": "RESIDENT",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateCustomerType")]
        [Authorize(Policy = "Permission:Customers.CREATE")] 
        public async Task<ActionResult<CustomerTypeReadDto>> CreateCustomerType([FromBody] CustomerTypeCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if(!string.Equals(userId, values.createdBy))
                {
                    return Unauthorized();
                }

                return Ok(await _customerTypeService.AddCustomerTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng customer types
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// PUT /UpdateCustomerType
        /// 
        /// {
        ///    "customerTypeId": 0,
        ///    "customerTypes": "RESIDENT",
        ///    "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateCustomerType")]
        [Authorize(Policy = "Permission:Customers.UPDATE")] 
        public async Task<ActionResult<CustomerTypeReadDto>> UpdateCustomerType([FromBody] CustomerTypeUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedBy))
            {
                return Unauthorized();
            }

            return Ok(await _customerTypeService.UpdateCustomerTypeAsync(values));
        }

        /// <summary>
        /// Removes an existing customer type
        /// </summary>
        [HttpDelete("DeleteCustomerType/{customerTypeId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteCustomerType(int customerTypeId)
        {
            var response = await _customerTypeService.DeleteCustomerTyeAsync(customerTypeId);

            if(response == "success")
            {
                return Ok(await _customerTypeService.DeleteCustomerTyeAsync(customerTypeId));
            }

            return BadRequest();
        }

        //----------------------GENDER------------
        /// <summary>
        /// Returns a list of existing genders
        /// </summary>
        [HttpGet]
        [Route("GetGenders")]
        public async Task<ActionResult<IEnumerable<GenderReadDto>>> GetGender()
        {
            return Ok(await _genderService.GetGenderAsync());
        }

        /// <summary>
        /// Returns an existing gender based on the name
        /// </summary>
        [HttpGet]
        [Route("GetGender/{value}")]
        private async Task<ActionResult<GenderReadDto>> GetGender(string value)
        {
            return Ok(await _genderService.GetGenderAsync(value));
        }

        /// <summary>
        /// Returns an existing gender based on the id
        /// </summary>
        [HttpGet]
        [Route("GetGender/{genderId}")]
        public async Task<ActionResult<GenderReadDto>> GetGender(int genderId)
        {
            return Ok(await _genderService.GetGenderAsync(genderId));
        }

        /// <summary>
        ///  Create a new gender
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateGender
        /// 
        /// {
        ///    "genderId": 0,
        ///    "genderType": "FE-MALE",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateGender")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<GenderReadDto>> CreateGender([FromBody] GenderCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.createdBy))
                {
                    return Unauthorized();
                }

                return Ok(await _genderService.AddGenderAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng genders
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// PUT /UpdateGender
        /// 
        /// {
        ///    "genderId": 1,
        ///    "genderType": "FEMALE",
        ///    "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateGender")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<GenderReadDto>> UpdateGender([FromBody] GenderUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedBy))
            {
                return Unauthorized();
            }

            return Ok(await _genderService.UpdateGenderAsync(values));
        }

        /// <summary>
        /// Removes an existing gender based on the id
        /// </summary>
        [HttpDelete("DeleteGender/{genderId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteGender(int genderId)
        {
            return Ok(await _genderService.DeleteGenderAsync(genderId));
        }

        //----------------------IDENTIFICATION TYPES------------
        /// <summary>
        /// Returns a list of exisitng identification types
        /// </summary>
        [HttpGet]
        [Route("GetIdentificationTypes")]
        public async Task<ActionResult<IEnumerable<IdentificationTypeReadDto>>> GetIdentificationTypes()
        {
            return Ok(await _identificationTypeService.GetIdentificationTypeAsync());
        }

        /// <summary>
        ///  Create a new identification type
        /// </summary>
        /// <remarks>
        /// The various forms of identification accepted during registration
        ///
        /// Sample Request:
        ///
        /// POST /CreateIdentificationType
        /// 
        /// {
        ///    "identificationTypeId": 0,
        ///    "identificationTypes": "GHANA CARD",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateIdentificationType")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<IdentificationTypeReadDto>> CreateIdentificationType([FromBody] IdentificationTypeCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdBy))
                {
                    return Unauthorized();
                }

                return Ok(await _identificationTypeService.AddIdentificationTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng identification types
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// PUT /UpdateIdentificationType
        /// 
        /// {
        ///    "identificationTypeId": 2,
        ///    "identificationTypes": "PASSPORT",
        ///    "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateIdentificationType")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<IdentificationTypeReadDto>> UpdateCustomerType([FromBody] IdentificationTypeUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedBy))
            {
                return Unauthorized();
            }
            return Ok(await _identificationTypeService.UpdateIdentificationTypeAsync(values));
        }

        /// <summary>
        /// Removes an existing identification type based on the id
        /// </summary>
        [HttpDelete("DeleteIdentificationType/{identificationTypeId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteIdentificationType(int identificationTypeId)
        {
            return Ok(await _identificationTypeService.DeleteIdentificationTypeAsync(identificationTypeId));
        }

        //----------------------NATIONALITY------------
        /// <summary>
        /// Returns a list of exisitng nationalities
        /// </summary>
        [HttpGet]
        [Route("GetNationality")]
        public async Task<ActionResult<IEnumerable<NationalityReadDto>>> GetNationality()
        {
            return Ok(await _nationalityService.GetNationalityAsync());
        }

        /// <summary>
        ///  Create a new nationality
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateNationality
        /// 
        /// {
        ///    "nationalityId": 0,
        ///    "nationalities": "GHANAIAN",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateNationality")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<NationalityReadDto>> CreateNationality([FromBody] NationalityCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdby))
                {
                    return Unauthorized();
                }

                return Ok(await _nationalityService.AddNationalityAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng nationalities
        /// </summary>
        ///
        /// Sample Request:
        ///
        /// PUT /UpdateNationality
        /// 
        /// {
        ///    "nationalityId": 3,
        ///    "nationalities": "CHINESE",
        ///    "modifiedby": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateNationality")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<NationalityReadDto>> UpdateNationality([FromBody] NationalityUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedby))
            {
                return Unauthorized();
            }
            return Ok(await _nationalityService.UpdateNationalityAsync(values));
        }

        /// <summary>
        /// Removes an existing nationality based on the id
        /// </summary>
        [HttpDelete("DeleteNationality/{nationalityId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteNationality(int nationalityId)
        {
            return Ok(await _nationalityService.DeleteNationalityAsync(nationalityId));
        }

        //----------------------RESIDENT TYPES------------
        /// <summary>
        /// Returns a list of exisitng resident types
        /// </summary>
        [HttpGet]
        [Route("GetResidentTypes")]
        public async Task<ActionResult<IEnumerable<ResidentTypeReadDto>>> GetResidentTypes()
        {
            return Ok(await _residentTypeService.GetResidentTypeAsync());
        }

        /// <summary>
        ///  Create a new resident type
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateResidentType
        /// 
        /// {
        ///    "residentTypeId": 0,
        ///    "residentTypes": "NON-RESIDENT",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateResidentType")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<ResidentTypeReadDto>> CreateResidentType([FromBody] ResidentTypeCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdBy))
                {
                    return Unauthorized();
                }
                return Ok(await _residentTypeService.AddResidentTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng resident types
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// PUT /UpdateResidentType
        /// 
        /// {
        ///    "residentTypeId": 2,
        ///    "residentTypes": "EXPATRAITE",
        ///    "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateResidentType")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<ResidentTypeReadDto>> UpdateResidentType([FromBody] ResidentTypeUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedBy))
            {
                return Unauthorized();
            }
            return Ok(await _residentTypeService.UpdateResidentTypeAsync(values));
        }

        /// <summary>
        /// Removes an existing resident type based on the id
        /// </summary>
        [HttpDelete("DeleteResidentType/{residentTypeId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteResidentType(int residentTypeId)
        {
            return Ok(await _residentTypeService.DeleteResidentTypeAsync(residentTypeId));
        }

        //----------------------SOCIAL MEDIA------------
        /// <summary>
        /// Returns a list of exisitng social media platforms
        /// </summary>
        [HttpGet]
        [Route("GetSocialMedia")]
        public async Task<ActionResult<IEnumerable<SocialMediaReadDto>>> GetSocialMedia()
        {
            return Ok(await _socialMediaService.GetSocialMediaAsync());
        }

        /// <summary>
        ///  Add a new social media platform
        /// </summary>
        [HttpPost]
        [Route("AddSocialMedia")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<SocialMediaReadDto>> AddSocialMedia([FromBody] SocialMediaCreateDto values)
        {
            try
            {

                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                return Ok(await _socialMediaService.AddSocialMediaAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng social media platforms
        /// </summary>
        [HttpPut]
        [Route("UpdateSocialMedia")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<SocialMediaReadDto>> UpdateSocialMedia([FromBody] SocialMediaUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }
            return Ok(await _socialMediaService.UpdateSocialMediaAsync(values));
        }

        /// <summary>
        /// Removes an existing social media based on the id
        /// </summary>
        [HttpDelete("DeleteSocialMedia/{socialMediaId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteSocialMedia(int socialMediaId)
        {
            return Ok(await _socialMediaService.DeleteSocialMediaAsync(socialMediaId));
        }

        //----------------------TITLE------------
        /// <summary>
        /// Returns a list of exisitng titles
        /// </summary>
        [HttpGet]
        [Route("GetTitles")]
        public async Task<ActionResult<IEnumerable<TitleReadDto>>> GetTitles()
        {
            return Ok(await _titleService.GetTitleAsync());
        }

        /// <summary>
        /// Returns details of exisitng titles based on the name
        /// </summary>
        [HttpGet]
        [Route("GetTitle/{value}")]
        private async Task<ActionResult<TitleReadDto>> GetTitle(string value)
        {
            return Ok(await _titleService.GetTitleAsync(value));
        }

        /// <summary>
        /// Returns details of exisitng titles based on the id
        /// </summary>
        [HttpGet]
        [Route("GetTitles/{titleId}")]
        public async Task<ActionResult<TitleReadDto>> GetTitleById(int titleId)
        {
            return Ok(await _titleService.GetTitleAsync(titleId));
        }

        /// <summary>
        ///  Create a new title
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateTitle
        /// 
        /// {
        ///    "titleId": 0,
        ///    "titles": "MR. and MRS.",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateTitle")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<TitleReadDto>> CreateTitle([FromBody] TitleCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdby))
                {
                    return Unauthorized();
                }

                return Ok(await _titleService.AddTitleAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng titles
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /UpdateTitle
        /// 
        /// {
        ///    "titleId": 1,
        ///    "titles": "MR. & MRS.",
        ///    "modifiedby": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateTitle")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<TitleReadDto>> UpdateTitle([FromBody] TitleUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedby))
            {
                return Unauthorized();
            }
            return Ok(await _titleService.UpdateTitleAsync(values));
        }

        /// <summary>
        /// Removes an existing title based on the id
        /// </summary>
        [HttpDelete("DeleteTitle/{titleId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteTitle(int titleId)
        {
            return Ok(await _titleService.DeleteTitleAsync(titleId));
        }


        //----------------------OWNERSHIP TYPE------------
        /// <summary>
        /// Returns a list of exisitng ownership types
        /// </summary>
        [HttpGet]
        [Route("GetOwnershipTypes")]
        public async Task<ActionResult<IEnumerable<OwnershipTypeReadDto>>> GetOwnershipTypes()
        {
            return Ok(await _ownershipTypeService.GetOwnershipTypeAsync());
        }

        /// <summary>
        /// Returns an exisitng ownership type based on the name
        /// </summary>
        [HttpGet]
        [Route("GetOwnershipTypes/{value}")]
        private async Task<ActionResult<OwnershipTypeReadDto>> GetOwnershipTypes(string value)
        {
            return Ok(await _ownershipTypeService.GetOwnershipTypeAsync(value));
        }

        /// <summary>
        /// Returns an exisitng ownership type based on the id
        /// </summary>
        [HttpGet]
        [Route("GetOwnershipType/{ownershipTypeId}")]
        private async Task<ActionResult<OwnershipTypeReadDto>> GetOwnershipType(int ownershipTypeId)
        {
            return Ok(await _ownershipTypeService.GetOwnershipTypeAsync(ownershipTypeId));
        }

        /// <summary>
        ///  Create a new ownership type
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateTitle
        /// 
        /// {
        ///    "ownershipTypeId": 0,
        ///    "ownershipType": "LEASEHOLDS",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateOwnershipType")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<OwnershipTypeReadDto>> CreateOwnershipType([FromBody] OwnershipTypeCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdby))
                {
                    return Unauthorized();
                }

                return Ok(await _ownershipTypeService.AddOwnershipTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng ownership type
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /UpdateTitle
        /// 
        /// {
        ///    "ownershipTypeId": 3,
        ///    "ownershipType": "LEASE HOLD",
        ///    "modifiedby": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateOwnershipType")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<OwnershipTypeReadDto>> UpdateOwnershipType([FromBody] OwnershipTypeUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedby))
            {
                return Unauthorized();
            }
            return Ok(await _ownershipTypeService.UpdateOwnershipTypeAsync(values));
        }

        /// <summary>
        /// Removes an existing title based on the id
        /// </summary>
        [HttpDelete("DeleteOwnershipType/{ownershipTypeId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteOwnershipType(int ownershipTypeId)
        {
            return Ok(await _ownershipTypeService.DeleteOwnershipTypeAsync(ownershipTypeId));
        }


        /// <summary>
        /// Returns a list of marital status
        /// </summary>
        [HttpGet]
        [Route("MaritalStatus")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult MaritalStatus()
        {
            var statuses = Enum.GetValues(typeof(MaritalStatusEnum))
                                   .Cast<MaritalStatusEnum>()
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
        /// Returns a list of customers based on optional search parameters. The entire list is returned if no pa
        /// </summary>
        [HttpGet]
        [Route("GetCustomerList")]
        public async Task<ActionResult<IEnumerable<CustomerListDto>>> GetCustomerList([FromQuery]string? searchParam, [FromQuery]string? locality)
        {
            return Ok(await _customerMasterService.GetCustomerListAsync(searchParam, locality));
        }

        //----------------------INTEREST EXPRESSED------------
        /// <summary>
        /// Returns a list of options for prospective customer interest expressed
        /// </summary>
        [HttpGet]
        [Route("GetInterestExpressed")]
        public async Task<ActionResult<IEnumerable<InterestExpressedReadDto>>> GetInterestExpressed()
        {
            return Ok(await _interestExpressedService.GetInterestExpressedAsync());
        }


        /// <summary>
        ///  Create a new customer interest expressed option
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /CreateInterestExpressed
        /// 
        /// {
        ///    "interestExpressedId": 0,
        ///    "customerInterestExpressed": "INTERESTED IN BUYING A SERVICED PLOT",
        ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPost]
        [Route("CreateInterestExpressed")]
        [Authorize(Policy = "Permission:Customers.CREATE")]
        public async Task<ActionResult<InterestExpressedReadDto>> CreateInterestExpressed([FromBody] InterestExpressedCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.createdBy))
                {
                    return Unauthorized();
                }

                return Ok(await _interestExpressedService.CreateInterestExpressedAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of exisitng customer interest expressed option
        /// </summary>
        /// <remarks>
        ///
        /// Sample Request:
        ///
        /// POST /UpdateInterestExpressed
        /// 
        /// {
        ///    "ownershipTypeId": 3,
        ///    "ownershipType": "TO ENQUIRE ABOUT SITE 3 APARTMENTS",
        ///    "modifiedby": "32ea339b-75f2-4f57-8153-915f127a9612"
        /// }
        /// </remarks>
        [HttpPut]
        [Route("UpdateInterestExpressed")]
        [Authorize(Policy = "Permission:Customers.UPDATE")]
        public async Task<ActionResult<InterestExpressedReadDto>> UpdateInterestExpressed([FromBody] InterestExpressedUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.modifiedBy))
            {
                return Unauthorized();
            }

            return Ok(await _interestExpressedService.UpdateInterestExpressedAsync(values));
        }

        /// <summary>
        /// Removes an existing customer interest expressed option based on the id
        /// </summary>
        [HttpDelete("DeleteInterestExpressed/{interestExpressedId}")]
        [Authorize(Policy = "Permission:Customers.DELETE")]
        public async Task<ActionResult> DeleteInterestExpressed(int interestExpressedId)
        {
            return Ok(await _interestExpressedService.DeleteInterestExpressedAsync(interestExpressedId));
        }


    }
}

