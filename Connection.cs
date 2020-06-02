using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionSAS2020
{
    public class Connection
    {
        public CloudStorageAccount Create()
        {

            var connectionString = "DefaultEndpointsProtocol=https;AccountName=alextorre;AccountKey=O8nwOWtm/XWyxDOeaD16J7QgFILBtdq7EOtft9a0mqVe+e6/xq5WUDT0KoTkYJwI8HIHimGng6PxE+KGb6+Bjw==;EndpointSuffix=core.windows.net";
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            // var storageAccount
            return storageAccount;
        }
    }
}
