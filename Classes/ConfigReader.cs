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

        public void readConfig() {
            
            configText = File.ReadAllText(configFilePathTxt);
            Console.WriteLine(configText);
            imgDirectoryExtracter();
        }

        private void imgDirectoryExtracter() {
            ConfigWriter writer = new ConfigWriter();
            if (configText == null || configText == "")
            {
                writer.writeBasicTemplate();
                MessageBox.Show("Config file has nothing. We maded a new one");
            }
            else
            {
                
                FileClerk.gettedDir = configText.Remove(0, 15);
                Console.WriteLine(FileClerk.gettedDir);
            }
        }


    }
}
