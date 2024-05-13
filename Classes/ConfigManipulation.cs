using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileRulette.Classes
{
    internal class ConfigManipulation
    {
        private string rootDir = @"G:\Картинки";

        public string getName
        {
            get
            {
                return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }

        }

        public void configDrop() {
            Directory.CreateDirectory(@"C:\Users\" + getName + @"\AppData\Roaming");
        }
    }
}
