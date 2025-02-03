using System.Web;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class FileManagerController : ControllerBase
{
    private readonly IAzureBlobService _blobService;


    public FileManagerController(IAzureBlobService blobService)
    {
        _blobService = blobService;
    }



    // POST api/values
    [HttpPost]
    [Route("UploadFileDocuments")]
    public async Task<IActionResult> UploadFileDocuments(IFormFile files)
    {
        try
        {
            if (files == null)
                return BadRequest();

            var result = await _blobService.UploadFileBlobAsync("mindspringsimagesonline", files.OpenReadStream(), files.ContentType, files.FileName);
            var toReturn = result.AbsoluteUri;

            return Ok(new { path = toReturn });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

}

