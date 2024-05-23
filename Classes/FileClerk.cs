using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileRulette
{
    internal class FileClerk
    {
        private List<string> iternal_directories = new List<string>();
        private List<string> files = new List<string>();
        public static string gettedDir {get; set;}

        public void SearchFolders()
        {
            foreach (string folders in Directory.EnumerateDirectories(gettedDir))
            {
                 iternal_directories.Add(folders);
            }
            
        }

        public void IndexFiles()
        {

            Random ran = new Random();

            foreach (string files in Directory.EnumerateFiles(iternal_directories[ran.Next(iternal_directories.Count)]))
            {
                this.files.Add(files);
            }

            foreach (string files in Directory.EnumerateFiles(gettedDir))
            {
                this.files.Add(files);
            }
        }

        public void ExecuteOne()
        {
            Random ran = new Random();
            Process.Start(files[ran.Next(files.Count)]);
        }
    }
}
