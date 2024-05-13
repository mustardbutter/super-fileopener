using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRulette
{
    internal class ProgrammStarter
    {
        public void Run() { 
            FileClerk fileClerk = new FileClerk();
            ConfigReader configReader = new ConfigReader();

            fileClerk.SearchFolders();
            fileClerk.IndexFiles();
            fileClerk.ExecuteOne();
        }
            
        
    }
}
