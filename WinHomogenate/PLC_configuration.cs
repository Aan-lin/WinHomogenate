
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.IO;

namespace WinHomogenate
{
    public class PLC_configuration
    {
        public static IniFile iniFile = new IniFile(Application.StartupPath + "\\PlcPointsConfig.ini");

        string readPlcStatusAddress = "DB340.100";
    }
}
