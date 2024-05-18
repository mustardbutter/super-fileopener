﻿using System;
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

        public static string configFilePathTemplate = @"C:\Users\" + getSystemName + @"\AppData\Roaming"; //C:\Users\musta\AppData\Roaming
        public static string configFilePathDir = configFilePathTemplate + @"\fileRuletteCfg";
        public static string configFilePath = configFilePathDir + @"\fileRulletteConfig.txt";

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
