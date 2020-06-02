using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FunctionSAS2020
{
    public class GetSas
    {
        public string Do()
        {
            //var sas = string.Empty;
            //var sas = "Esto no está vacio";

            //var sas = "es una frase";
            var storageAccount = new Connection().Create();
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("containimg1");

            SharedAccessBlobPolicy adHocPolicy = new SharedAccessBlobPolicy()
            {
                SharedAccessExpiryTime = System.DateTime.UtcNow.AddHours(1),
                Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.List
            };

            var sas = container.GetSharedAccessSignature(adHocPolicy, "containimg1");

            return sas;
        }
    }
}
