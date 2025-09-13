using System.ComponentModel;
using System.Reflection;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.ApplicationForm;
using Modules.Documents.Application.Dtos.FormTemplates;
using Modules.Documents.Application.Enums;
using Modules.Documents.Application.Interfaces;

namespace Modules.Documents.Presentation.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
//[Route("[controller]")]
[Produces("application/json")]

public class DocumentsController : ControllerBase
{
    private readonly IFormTemplateService _formTemplateService;

    private readonly IFormSubmissionService _formSubmissionService;

    public DocumentsController(IFormTemplateService formTemplateService, IFormSubmissionService formSubmissionService)
    {
        _formTemplateService = formTemplateService;
        _formSubmissionService = formSubmissionService;
    }


    [HttpGet]
    [Route("FieldOptionsDataSource")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    //[Authorize(Policy = "Permission:Customers.READ")]
    public IActionResult FieldOptionsDataSource()
    {
        var options = Enum.GetValues(typeof(FieldOptionsEnum))
                               .Cast<FieldOptionsEnum>()
                               .Select(e => new
                               {
                                   Id = (int)e,
                                   Name = e.ToString(),
                                   DisplayName = e.GetType()
                                                 .GetField(e.ToString())!
                                                  .GetCustomAttribute<DescriptionAttribute>()?
                                                  .Description

                               });
        return Ok(options);
    }

    [HttpGet]
    [Route("GetFormFields")]
    //[Authorize(Policy = "Permission:PropertySetup.READ")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult GetFormFields([FromServices] IFieldTypeService typeService)
    {
        return Ok(typeService.GetAllFieldTypes());
    }

    [HttpGet]
    [Route("GetFormTemplates")]
    //[Authorize(Policy = "Permission:PropertySetup.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FormTemplateDto>))]
    public async Task<ActionResult> GetFormTemplates([FromQuery] int landUseId, [FromQuery] int landUseTypeId)
    {
        var templates = await _formTemplateService.GetAllFormTemplatesAsync(landUseId, landUseTypeId);
        return Ok(templates);

    }


    [HttpPost]
    [Route("CreateFormTemplate")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(FormsSuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateFormTemplate([FromBody] CreateFormTemplateDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formTemplateService.CreateFormTemplateAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdateFormTemplate")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateFormTemplate([FromBody] UpdateFormTemplateDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formTemplateService.UpdateFormTemplateAsync(values.FormTemplateId, values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    [HttpPost]
    [Route("CreateApplicationForm")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateApplicationForm([FromBody] CreateFormSubmissionDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formSubmissionService.CreateSubmissionAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdateApplicationForm")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateApplicationForm([FromBody] UpdateFormSubmissionDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formSubmissionService.UpdateSubmissionAsync(values.FormSubmissionId , values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }


    [HttpGet]
    [Route("GetApplications")]
    //[Authorize(Policy = "Permission:PropertySetup.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<FormSubmissionDto>))]
    public async Task<ActionResult> GetApplications([FromQuery] int? applicationId = null,[FromQuery] string? emailAddress = null,[FromQuery] int? templateId = null)
    {
        if (applicationId.HasValue)
        {
            return Ok(await _formSubmissionService.GetSubmissionByIdAsync(applicationId.Value));
        }

        if (!string.IsNullOrWhiteSpace(emailAddress))
        {
            return Ok(await _formSubmissionService.GetSubmissionsByApplicantAsync(emailAddress));
        }

        if (templateId.HasValue)
        {
            return Ok(await _formSubmissionService.GetSubmissionsByTemplateAsync(templateId.Value));
        }

        return Ok(new List<FormSubmissionDto>()); // return empty list instead of Ok() for consistency
    }


    [HttpGet]
    [Route("GetApplicationsSubmittedSummary")]
    //[Authorize(Policy = "Permission:PropertySetup.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SubmissionSummaryDto))]
    public async Task<ActionResult> GetApplicationsSubmittedSummary()
    {
        return Ok(await _formSubmissionService.GetSubmissionSummaryAsync());
    }


    [HttpPost]
    [Route("SubmitApplicationForm")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> SubmitApplicationForm([FromBody] int id)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formSubmissionService.SubmitSubmissionAsync(id);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdateSubmissionStatus")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateSubmissionStatus([FromBody] UpdateFormSubmissionStatusDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.createdBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _formSubmissionService.UpdateSubmissionStatusAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }




}

