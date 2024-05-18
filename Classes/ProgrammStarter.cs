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
    internal class ProgrammStarter
    {
        
        public void Run() {
            ConfigCreator creator = new ConfigCreator();
            if (!creator.configDirectoryAvalibilityCheck() && !creator.configAvalibilityCheck())
            {
                FirstTimeStart();
            }else
            { 
                ConfigReader configReader = new ConfigReader();
                configReader.readConfig();

            }

        }

        public void FirstTimeStart()
        {
            ConfigCreator creator = new ConfigCreator();

            creator.configDirectoryCreate();
            creator.configFileCreate();
            MessageBox.Show("Configuration file was created in %appdata%");
        
        }

        public void ClerkWorker() { 
        FileClerk fileClerk = new FileClerk();
            fileClerk.SearchFolders();
            fileClerk.IndexFiles();
            fileClerk.ExecuteOne();
        }
    }
}
