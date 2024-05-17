using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileRulette.Classes
{
    internal class ConfigManipulation
    {
        /*
         *
         *Добавить строку пути создания файла +
         *Добавить метод проверки имеется ли там файл конфигурации
         *Добавить метод создания файла конфигурации
         *
         *
         */

        public static string configFilePathTemplate = @"C:\Users\" + getSystemName + @"\AppData\Roaming";
        public static string configFilePathDir = configFilePathTemplate + @"\\fileRuletteCfg";
        public static string configFilePath = configFilePathDir + @"\\fileRulletteConfig.txt";

        public static string getSystemName
        {
            get
            {
                return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
        }

        public string getConfigFilePathTemplate
        {
            get
            {
                return configFilePathTemplate;
            }
        }

        public string getConfigFilePath
        {
            get
            {
                return configFilePathDir;
            }
        }

        public bool configDirectoryAvalibilityCheck() {
            if (Directory.Exists(getConfigFilePath))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool configAvalibilityCheck() {
            if (File.Exists(configFilePath))
            {
                return true;
            }
            else {
                return false;
            }
        }


    }
}
