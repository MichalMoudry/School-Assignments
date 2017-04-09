using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Models
{
    public class FileObj
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        private string _data;
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

    }
}
