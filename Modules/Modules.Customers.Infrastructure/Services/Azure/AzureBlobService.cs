// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Web;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Modules.Customers.Infrastructure.Services.Azure
{
    public class AzureBlobService : IAzureBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public AzureBlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }


        private BlobContainerClient GetContainerClient(string blobContainerName)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(blobContainerName);
            containerClient.CreateIfNotExists(PublicAccessType.Blob);
            return containerClient;
        }

        static string ExtractBlobName(string blobContainerName, string blobUrl)
        {
            
            blobUrl = HttpUtility.UrlDecode(blobUrl);// Decode any %20, %2F, etc.
            Uri uri = new Uri(blobUrl);
            string path = uri.AbsolutePath;  // Extracts "/mindspringsimagesonline/Screenshot%202024-09-20%20at%207.45.58%20PM.png"

            string blobName = path.Replace($"/{blobContainerName}/", ""); // Remove container prefix

            blobName = HttpUtility.UrlDecode(blobName);
            return blobName;
        }

        public async Task<Uri> UploadFileBlobAsync(string blobContainerName, Stream content, string contentType, string fileName)
        {
            var containerClient = GetContainerClient(blobContainerName);
            var blobClient = containerClient.GetBlobClient(fileName);
            await blobClient.UploadAsync(content, new BlobHttpHeaders { ContentType = contentType });
            return blobClient.Uri;
        }

        public async Task<string> DeleteFileBlobAsync(string blobContainerName, string fileName)
        {
            fileName = ExtractBlobName(blobContainerName,fileName);

            var containerClient = GetContainerClient(blobContainerName);
            var blobClient = containerClient.GetBlobClient(fileName);

            bool exists = await blobClient.DeleteIfExistsAsync();

            if (exists)
            {
                return $"FileName '{fileName}' deleted successfully.";
            }
            else
            {
                return $"FileName '{fileName}' does not exist.";

            }


        }


    }
}

