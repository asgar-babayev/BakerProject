using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace BakerProject.Utility.Extension
{
    public static class FileExtension
    {
        public static string rootPath = "";

        public static string SaveFile(this IFormFile file, string folders, string fileName)
        {
            using (FileStream fs = new FileStream(Path.Combine(rootPath, folders, fileName), FileMode.Create))
            {
                fileName = Guid.NewGuid().ToString() + file.FileName;
                file.CopyTo(fs);
            }
            return fileName;
        }

        public static bool CheckType(this IFormFile file, string type)
        {
            if (file.ContentType.Contains(type)) return true;
            return false;
        }

        public static bool CheckSize(this IFormFile file, int size)
        {
            if (file.Length / 1024 > size) return true;
            return false;
        }

        public static void FileNameChange(this IFormFile file)
        {
            if (file.FileName.Length > 64)
            {
                file.FileName.Substring(file.FileName.Length - 64, 64);
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(Path.Combine(rootPath, path)))
            {
                File.Delete(Path.Combine(rootPath, path));
            }
        }
    }
}
