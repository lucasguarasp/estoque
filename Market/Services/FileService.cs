using Market.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Market.Services
{
    public class FileService
    {
        private static string CriarPath()
        {
            string path = Directory.GetCurrentDirectory() + @"\Arquivos";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //set CurrentDirectory
            string currentDirectory = Environment.CurrentDirectory = (path);

            return currentDirectory;
        }

        public static string InserirArquivo(IFormFile arquivo)
        {
            string path = CriarPath();

            return Upload(arquivo, path).Result;
        }

        private static async Task<string> Upload(IFormFile file, string path)
        {
            string filePath = Path.Combine(path, file.FileName);
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }

            return await Task.Run(() => filePath);
        }

        public static string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private static Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

    }
}
