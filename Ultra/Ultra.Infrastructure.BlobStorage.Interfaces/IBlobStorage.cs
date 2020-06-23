using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ultra.Infrastructure.BlobStorage.Interfaces
{
    public interface IBlobStorage
    {
        Task UploadAsync(string path, Stream stream);
    }
}
