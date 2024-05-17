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
            if (!configDirectoryAvalibilityCheck())
            {
                Directory.CreateDirectory(configFilePathDir);
            }
        }

        public void configFileCreate() {
            if (configAvalibilityCheck()) {
                File.Create(configFilePath);
            }
        }
    }
}
