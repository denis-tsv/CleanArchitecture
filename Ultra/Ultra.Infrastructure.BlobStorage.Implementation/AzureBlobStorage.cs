using System;
using System.IO;
using System.Threading.Tasks;
using Ultra.Common.Infrastructure.BlobStorage.Interfaces;

namespace Ultra.Common.Infrastructure.BlobStorage.Implementation.Azure
{
    public class AzureBlobStorage : IBlobStorage
    {
        public Task UploadAsync(string path, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
