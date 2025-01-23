using System;
namespace Modules.Customers.Application.Interfaces.Services
{
	public interface IAzureBlobService
	{
        Task<Uri> UploadFileBlobAsync(string blobContainerName, Stream content, string contentType, string fileName);
    }
}

