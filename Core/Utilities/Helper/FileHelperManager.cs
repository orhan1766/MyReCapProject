using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile formFile, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Upload(formFile, root);
        }

        public string Upload(IFormFile formFile, string root)
        {
            if (formFile.Length>0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(formFile.FileName);
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    formFile.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }
        
    }
}
