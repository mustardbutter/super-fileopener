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
        public async Task writeBasicTemplateAsync() {
            using (StreamWriter writer = new StreamWriter(configFilePathTxt, false))
            {
                await writer.WriteLineAsync("use directory =");
            }
        }
    }
}
