using Business.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FileManager : IFileService
    {
        private readonly string _uploadPath;

        public FileManager(string uploadPath)
        {
            _uploadPath = uploadPath;

            // Klasör yoksa oluştur
            if (!Directory.Exists(_uploadPath))
            {
                Directory.CreateDirectory(_uploadPath);
            }
        }

        /// <summary>
        /// Dosyayı kaydeder ve yolunu döner
        /// </summary>
        public async Task<string> SaveFileAsync(IFormFile file, string subFolder = "")
        {
            try
            {
                // Benzersiz dosya adı oluştur
                string uniqueFileName = GetUniqueFileName(file.FileName);

                // Alt klasör varsa oluştur
                string fullPath = string.IsNullOrEmpty(subFolder)
                    ? _uploadPath
                    : Path.Combine(_uploadPath, subFolder);

                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }

                // Tam dosya yolu
                string filePath = Path.Combine(fullPath, uniqueFileName);

                // Dosyayı kaydet
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Relative path döndür (database için)
                return string.IsNullOrEmpty(subFolder)
                    ? Path.Combine("uploads", "documents", uniqueFileName)
                    : Path.Combine("uploads", "documents", subFolder, uniqueFileName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya kaydedilirken hata: {ex.Message}");
            }
        }

        /// <summary>
        /// Dosyayı siler
        /// </summary>
        public async Task<bool> DeleteFileAsync(string filePath)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filePath);

                if (File.Exists(fullPath))
                {
                    await Task.Run(() => File.Delete(fullPath));
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Dosyayı okur (byte array olarak)
        /// </summary>
        public async Task<byte[]> ReadFileAsync(string filePath)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filePath);

                if (!File.Exists(fullPath))
                    throw new FileNotFoundException("Dosya bulunamadı.");

                return await File.ReadAllBytesAsync(fullPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya okunurken hata: {ex.Message}");
            }
        }

        /// <summary>
        /// Dosya var mı kontrol eder
        /// </summary>
        public bool FileExists(string filePath)
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filePath);
            return File.Exists(fullPath);
        }

        /// <summary>
        /// Benzersiz dosya adı oluşturur
        /// </summary>
        public string GetUniqueFileName(string originalFileName)
        {
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFileName);
            string extension = Path.GetExtension(originalFileName);

            // Timestamp + GUID + orijinal ad (ilk 20 karakter)
            string safeName = fileNameWithoutExt.Length > 20
                ? fileNameWithoutExt.Substring(0, 20)
                : fileNameWithoutExt;

            safeName = safeName.Replace(" ", "_");

            return $"{DateTime.Now:yyyyMMddHHmmss}_{Guid.NewGuid().ToString().Substring(0, 8)}_{safeName}{extension}";
        }
    }
}
