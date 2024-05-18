using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileRulette.Classes
{
    internal class ConfigWriter : ConfigManipulation
    {
        public async Task writeBasicTemplateAsync(string directory) {
            using (StreamWriter writer = new StreamWriter(configFilePath, false))
            {
                await writer.WriteLineAsync("use directory =" + directory);
            }
        }
    }
}
