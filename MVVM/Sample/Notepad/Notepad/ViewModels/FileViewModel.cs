using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Models;
using Notepad.Services;

namespace Notepad.ViewModels
{
    public class FileViewModel
    {
        public void SaveFile(FileObj file)
        {
            FileService fs = new FileService();
            fs.Save(file.Data, "File", "json");
        }

        public FileObj LoadFile()
        {
            FileService fs = new FileService();
            FileObj file = new FileObj();
            file.Data = fs.Load("File", "json");
            return file;
        }
    }
}
