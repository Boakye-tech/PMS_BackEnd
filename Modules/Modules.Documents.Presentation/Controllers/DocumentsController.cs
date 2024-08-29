using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.FormTemplates;
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

    public DocumentsController(IFormTemplateService formTemplateService)
    {
        _formTemplateService = formTemplateService;
    }

    [HttpGet]
    [Route("GetFormTemplates")]
    //[Authorize(Policy = "Permission:PropertySetup.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FormTemplateDto>))]
    public async Task<ActionResult> GetPlotFeatures()
    {
        return Ok(await _formTemplateService.GetAllFormTemplatesAsync());
    }


    [HttpPost]
    [Route("CreateFormTemplate")]
    //[Authorize(Policy = "Permission:PropertySetup.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
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

    [HttpPost]
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




}

