using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Settings
{
    public class FileStorageSettings
    {
        public string UploadPath { get; set; }
        public int MaxFileSizeMB { get; set; }
        public List<string> AllowedExtensions { get; set; }
    }
}
