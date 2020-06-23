using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Ultra.Infrastructure.BlobStorage.Interfaces;

namespace Ultra.Infrastructure.BlobStorage.Implementation.Azure
{
    public class AzureBlobStorage : IBlobStorage
    {
        public Task UploadAsync(string path, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
