using System;
namespace Modules.Customers.Application.Interfaces.ExternalService
{
	public interface IAzureBlobService
	{
        Task<Uri> UploadFileBlobAsync(string blobContainerName, Stream content, string contentType, string fileName);
        Task<string> DeleteFileBlobAsync(string blobContainerName, string fileName);
    }
}

