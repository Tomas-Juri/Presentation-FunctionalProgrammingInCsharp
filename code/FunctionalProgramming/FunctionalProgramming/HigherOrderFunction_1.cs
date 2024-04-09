using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace FunctionalProgramming;

public class HigherOrderFunction_1
{
    public static Response<BlobDownloadInfo> Upload_Basic()
    {
        var blobServiceClient = new BlobServiceClient("secret---string");
        var containerClient = blobServiceClient.GetBlobContainerClient("photos");
        containerClient.CreateIfNotExists();
        
        var blobClient = containerClient.GetBlobClient("blob");
        return blobClient.Download();
    }

    public static Response<BlobDownloadInfo> Upload_Connect() =>
        WithBlob("blob-name", blob => blob.Download());

    private static T WithBlob<T>(string name ,Func<BlobClient, T> func)
    {
        var blobServiceClient = new BlobServiceClient("secret---string");
        var containerClient = blobServiceClient.GetBlobContainerClient("photos");
        
        containerClient.CreateIfNotExists();
        var blobClient = containerClient.GetBlobClient(name);
        
        return func(blobClient);
    }
}