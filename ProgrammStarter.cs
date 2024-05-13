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
            FileClerk parser = new FileClerk();
            ConfigReader configReader = new ConfigReader();

            

            parser.SearchFolders();
            parser.IndexFiles();
            parser.ExecuteOne();
        }
            
        
    }
}
