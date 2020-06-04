using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FunctionSAS2020
{
    public class Connection
    {
        public CloudStorageAccount Create()
        {

            var connectionString = "DefaultEndpointsProtocol=https;AccountName=alextorpe;AccountKey=O8nwOWtm/XWyxDOeaD16J7QgFILBtdq7EOtft9a0mqVe+e6/xq5WUDT0KoTkYJwI8HIHimGng6PxE+KGb6+Bjw==;EndpointSuffix=core.windows.net";
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            return storageAccount;
        }
//        private async Task<string> GetAccessTokenAsync()
//        {
//            var tokenProvider = new AzureServiceTokenProvider();
//            return await tokenProvider.GetAccessTokenAsync("https://storage.azure.com/");
//        }
//        async Task<Stream> GetBlobWithSdk(string accessToken)
//        {
//            var tokenCredential = new TokenCredential(accessToken);
//            var storageCredentials = new TokenCredential(accessToken);
//            //Define the blob to read
//            var blob = new CloudBlockBlob(new Uri($"https://alextorpe.blob.core.windows.net/containimg1/campus.jpg"), storageCredentials);
//            // Open a data stream to the blob
//            return await blob.OpenReadAsync();
//        }
    }
}
