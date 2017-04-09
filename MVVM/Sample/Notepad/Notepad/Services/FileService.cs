using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Notepad.Models;

namespace Notepad.Services
{
    public class FileService
    {
        public void Save(string data, string fileName, string fileType)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\{fileName}.{fileType}";
            File.Delete(path);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(data);
            }
        }

        public string Load(string fileName, string fileType)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\{fileName}.{fileType}";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }

    }
}
