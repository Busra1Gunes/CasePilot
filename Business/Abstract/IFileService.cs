using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(IFormFile file, string subFolder = "");
        Task<bool> DeleteFileAsync(string filePath);
        Task<byte[]> ReadFileAsync(string filePath);
        bool FileExists(string filePath);
        string GetUniqueFileName(string originalFileName);
    }
}
