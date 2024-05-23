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
                if (Directory.Exists(ConfigManipulation.configFilePathDir) && File.Exists(ConfigManipulation.configFilePathTxt))
                {
                    ConfigReader configReader = new ConfigReader();
                    configReader.readConfig();
                   
                        ClerkWorker();
                    
                    
                }
                else
                {
                    ConfigCreator config = new ConfigCreator();
                    config.configDirectoryCreate();
                    creator.configFileCreate();

                }
                
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
            if (FileClerk.gettedDir != null || FileClerk.gettedDir != "")
            {
                fileClerk.SearchFolders();
                fileClerk.IndexFiles();
                fileClerk.ExecuteOne();
            }
            else
            {
                MessageBox.Show("Config is empty");
            }
            
        }
    }
}
