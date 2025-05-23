﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Web;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
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

    [HttpDelete]
    [Route("DeleteUploadFile/{filename}")]
    public async Task<IActionResult> DeleteUploadFile(string filename)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(filename) == true)
                return BadRequest();

            var result = await _blobService.DeleteFileBlobAsync("mindspringsimagesonline", filename);

            return Ok(new { Response = result });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

}

