using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRulette.Classes
{
    internal class ConfigCreator : ConfigManipulation
    {
        public void configDirectoryCreate() {
                Directory.CreateDirectory(configFilePathDir);
        }

        public void configFileCreate() {
            ConfigWriter writer = new ConfigWriter();
                File.Create(configFilePathTxt);
                writer.writeBasicTemplate();
        }
    }
}
