using System.Collections.Generic;
using System.Threading.Tasks;

namespace Conversor.Business.Interfaces;

public interface IAws3Services
{
	System.Threading.Tasks.Task<bool> UploadFileAsync(string bucketName, string folderName);

	System.Threading.Tasks.Task<List<string>> DownloadFileAsync(string bucketName, string objectKey);

	System.Threading.Tasks.Task<List<string>> ListBucketsAsync(string bucketName);
}
