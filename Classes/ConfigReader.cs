using FileRulette.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileRulette
{
    internal class ConfigReader : ConfigManipulation
    {
        string configText;
        public string directory;

        public async void readConfig() {
            using (StreamReader reader = new StreamReader(configFilePathTxt))
            {
                configText = await reader.ReadToEndAsync();
            }
            imgDirectoryExtracter();
        }

        private void imgDirectoryExtracter() {
            ConfigWriter writer = new ConfigWriter();
            if (configText == null)
            {
                writer.writeBasicTemplateAsync();
                MessageBox.Show("Config file has nothing. We maded a new one");
            }
            else
            {
                directory=configText.Remove(0,15);
                directoryOverride();
            }
        }

        private void directoryOverride() { 
            FileClerk fileClerk = new FileClerk();
            fileClerk.rootDir = directory;
        }

    }
}
