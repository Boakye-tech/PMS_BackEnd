﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public partial class CustomerController : ControllerBase
    {
        readonly ICustomerTypeService _customerTypeService;
        readonly IGenderService _genderService;
        readonly IIdentificationTypeService _identificationTypeService;
        readonly INationalityService _nationalityService;
        readonly IResidentTypeService _residentTypeService;
        readonly ISocialMediaService _socialMediaService;
        readonly ITitleService _titleService;

        readonly ICustomerMasterService _customerMasterService;

        public CustomerController(ICustomerTypeService customerTypeService, IGenderService genderService, IIdentificationTypeService identificationTypeService, INationalityService nationalityService,
                                  IResidentTypeService residentTypeService, ISocialMediaService socialMediaService, ITitleService titleService, ICustomerMasterService customerMasterService)
        {
            _customerTypeService = customerTypeService;
            _genderService = genderService;
            _identificationTypeService = identificationTypeService;
            _nationalityService = nationalityService;
            _residentTypeService = residentTypeService;
            _socialMediaService = socialMediaService;
            _titleService = titleService;

            _customerMasterService = customerMasterService;
        }

        //----------------------CUSTOMER TYPES------------
        /// <summary>
        /// Returns a list of exisitng customer types
        /// </summary>
        [HttpGet]
        [Route("Setup/GetCustomerTypes")]
        public async Task<ActionResult<IEnumerable<CustomerTypeReadDto>>> GetCustomerTypes()
        {
            return Ok(await _customerTypeService.GetCustomerTypeAsync());
        }

        /// <summary>
        /// Add a new customer type
        /// </summary>
        [HttpPost]
        [Route("AddCustomerType")]
        public async Task<ActionResult<CustomerTypeReadDto>> AddCustomerType([FromBody] CustomerTypeCreateDto values)
        {
            try
            {
                return Ok(await _customerTypeService.AddCustomerTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing customer type
        /// </summary>
        [HttpPut]
        [Route("UpdateCustomerType")]
        public async Task<ActionResult<CustomerTypeReadDto>> UpdateCustomerType([FromBody] CustomerTypeUpdateDto values)
        {
            return Ok(await _customerTypeService.UpdateCustomerTypeAsync(values));
        }

        [HttpDelete("DeleteCustomerType/{customerTypeId}")]
        public void DeleteCustomerType(int customerTypeId)
        {
        }

        //----------------------GENDER------------
        /// <summary>
        /// Returns a list of existing genders
        /// </summary>
        [HttpGet]
        [Route("Setup/GetGenders")]
        public async Task<ActionResult<IEnumerable<GenderReadDto>>> GetGender()
        {
            return Ok(await _genderService.GetGenderAsync());
        }

        [HttpGet]
        [Route("Setup/GetGender/{value}")]
        public async Task<ActionResult<GenderReadDto>> GetGender(string value)
        {
            return Ok(await _genderService.GetGenderAsync(value));
        }

        [HttpGet]
        [Route("Setup/GetGenderById/{genderId}")]
        public async Task<ActionResult<GenderReadDto>> GetGenderById(int genderId)
        {
            return Ok(await _genderService.GetGenderAsync(genderId));
        }


        /// <summary>
        /// Add a new gender type
        /// </summary>
        [HttpPost]
        [Route("AddGender")]
        public async Task<ActionResult<GenderReadDto>> AddGender([FromBody] GenderCreateDto values)
        {
            try
            {
                return Ok(await _genderService.AddGenderAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing gender type
        /// </summary>
        [HttpPut]
        [Route("UpdateGender")]
        public async Task<ActionResult<GenderReadDto>> UpdateGender([FromBody] GenderUpdateDto values)
        {
            return Ok(await _genderService.UpdateGenderAsync(values));
        }

        [HttpDelete("DeleteGender/{genderId}")]
        public void DeleteGender(int genderId)
        { }

        //----------------------IDENTIFICATION TYPES------------
        /// <summary>
        /// Returns a list of exisitng identification types
        /// </summary>
        [HttpGet]
        [Route("Setup/GetIdentificationTypes")]
        public async Task<ActionResult<IEnumerable<IdentificationTypeReadDto>>> GetIdentificationTypes()
        {
            return Ok(await _identificationTypeService.GetIdentificationTypeAsync());
        }


        /// <summary>
        /// Add a new identification type
        /// </summary>
        [HttpPost]
        [Route("AddIdentificationType")]
        public async Task<ActionResult<IdentificationTypeReadDto>> AddIdentificationType([FromBody] IdentificationTypeCreateDto values)
        {
            try
            {
                return Ok(await _identificationTypeService.AddIdentificationTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing identification type
        /// </summary>
        [HttpPut]
        [Route("UpdateIdentificationType")]
        public async Task<ActionResult<IdentificationTypeReadDto>> UpdateCustomerType([FromBody] IdentificationTypeUpdateDto values)
        {
            return Ok(await _identificationTypeService.UpdateIdentificationTypeAsync(values));
        }

        [HttpDelete("DeleteIdentificationType/{identificationTypeId}")]
        public void DeleteIdentificationType(int identificationTypeId)
        {
        }

        //----------------------NATIONALITY------------
        /// <summary>
        /// Returns a list of exisitng nationalities
        /// </summary>
        [HttpGet]
        [Route("Setup/GetNationality")]
        public async Task<ActionResult<IEnumerable<NationalityReadDto>>> GetNationality()
        {
            return Ok(await _nationalityService.GetNationalityAsync());
        }

        /// <summary>
        /// Add a new nationality
        /// </summary>
        [HttpPost]
        [Route("AddNationality")]
        public async Task<ActionResult<NationalityReadDto>> AddNationality([FromBody] NationalityCreateDto values)
        {
            try
            {
                return Ok(await _nationalityService.AddNationalityAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing nationality
        /// </summary>
        [HttpPut]
        [Route("UpdateNationality")]
        public async Task<ActionResult<NationalityReadDto>> UpdateNationality([FromBody] NationalityUpdateDto values)
        {
            return Ok(await _nationalityService.UpdateNationalityAsync(values));
        }

        [HttpDelete("DeleteNationality/{nationalityId}")]
        public void DeleteNationality(int nationalityId)
        {
        }

        //----------------------RESIDENT TYPES------------
        /// <summary>
        /// Returns a list of exisitng resident types
        /// </summary>
        [HttpGet]
        [Route("Setup/GetResidentTypes")]
        public async Task<ActionResult<IEnumerable<ResidentTypeReadDto>>> GetResidentTypes()
        {
            return Ok(await _residentTypeService.GetResidentTypeAsync());
        }


        /// <summary>
        /// Add a new resident type
        /// </summary>
        [HttpPost]
        [Route("AddResidentType")]
        public async Task<ActionResult<ResidentTypeReadDto>> AddResidentType([FromBody] ResidentTypeCreateDto values)
        {
            try
            {
                return Ok(await _residentTypeService.AddResidentTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing resident type
        /// </summary>
        [HttpPut]
        [Route("UpdateResidentType")]
        public async Task<ActionResult<ResidentTypeReadDto>> UpdateResidentType([FromBody] ResidentTypeUpdateDto values)
        {
            return Ok(await _residentTypeService.UpdateResidentTypeAsync(values));
        }

        [HttpDelete("DeleteResidentType/{residentTypeId}")]
        public void DeleteResidentType(int residentTypeId)
        {
        }

        //----------------------SOCIAL MEDIA------------
        /// <summary>
        /// Returns a list of exisitng social media platforms
        /// </summary>
        [HttpGet]
        [Route("Setup/GetSocialMedia")]
        public async Task<ActionResult<IEnumerable<SocialMediaReadDto>>> GetSocialMedia()
        {
            return Ok(await _socialMediaService.GetSocialMediaAsync());
        }


        /// <summary>
        /// Add a new social media platform
        /// </summary>
        [HttpPost]
        [Route("AddSocialMedia")]
        public async Task<ActionResult<SocialMediaReadDto>> AddSocialMedia([FromBody] SocialMediaCreateDto values)
        {
            try
            {
                return Ok(await _socialMediaService.AddSocialMediaAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing social media platform
        /// </summary>
        [HttpPut]
        [Route("UpdateSocialMedia")]
        public async Task<ActionResult<SocialMediaReadDto>> UpdateSocialMedia([FromBody] SocialMediaUpdateDto values)
        {
            return Ok(await _socialMediaService.UpdateSocialMediaAsync(values));
        }

        [HttpDelete("DeleteSocialMedia/{socialMediaId}")]
        public void DeleteSocialMedia(int socialMediaId)
        {
        }

        //----------------------TITLE------------
        /// <summary>
        /// Returns a list of exisitng titles
        /// </summary>
        [HttpGet]
        [Route("Setup/GetTitles")]
        public async Task<ActionResult<IEnumerable<TitleReadDto>>> GetTitles()
        {
            return Ok(await _titleService.GetTitleAsync());
        }

        /// <summary>
        /// Returns an exisitng title based on the title name
        /// </summary>
        [HttpGet]
        [Route("Setup/GetTitle/{value}")]
        public async Task<ActionResult<TitleReadDto>> GetTitle(string value)
        {
            return Ok(await _titleService.GetTitleAsync(value));
        }

        /// <summary>
        /// Returns an exisitng title based on the title id
        /// </summary>
        [HttpGet]
        [Route("Setup/GetTitlesById/{titleId}")]
        public async Task<ActionResult<TitleReadDto>> GetTitleById(int titleId)
        {
            return Ok(await _titleService.GetTitleAsync(titleId));
        }


        /// <summary>
        /// Add a new title
        /// </summary>
        [HttpPost]
        [Route("AddTitle")]
        public async Task<ActionResult<TitleReadDto>> AddTitle([FromBody] TitleCreateDto values)
        {
            try
            {
                return Ok(await _titleService.AddTitleAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies an existing title
        /// </summary>
        [HttpPut]
        [Route("UpdateTitle")]
        public async Task<ActionResult<TitleReadDto>> UpdateTitle([FromBody] TitleUpdateDto values)
        {
            return Ok(await _titleService.UpdateTitleAsync(values));
        }

        [HttpDelete("DeleteTitle/{titleId}")]
        public void DeleteTitle(int titleId)
        { }

        //------------------

        /// <summary>
        /// Add a new prospective customer
        /// </summary>
        [HttpPost]
        [Route("AddProspectiveCustomer")]
        public async Task<ActionResult<ProspectiveCustomerResponseDto>> AddProspectiveCustomer([FromBody] ProspectiveCustomerCreateDto values)
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


        /// <summary>
        /// Add a new company customer
        /// </summary>
        [HttpPost]
        [Route("AddCompanyCustomer")]
        public async Task<ActionResult<CompanyCustomerResponseDto>> AddCompanyCustomer([FromBody] CreateCompanyCustomerDto values)
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


    }
}

