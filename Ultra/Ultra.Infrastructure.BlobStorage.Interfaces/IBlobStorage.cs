using System.IO;
using System.Threading.Tasks;

namespace Ultra.Common.Infrastructure.BlobStorage.Interfaces
{
    public interface IBlobStorage
    {
        Task UploadAsync(string path, Stream stream);
    }
}
