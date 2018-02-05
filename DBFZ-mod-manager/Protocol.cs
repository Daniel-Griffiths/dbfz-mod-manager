using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ModManager
{
    class Protocol
    {
        public static string ProtocolName = "dbfmm";

        public static void Register()
        {
            try
            {
                RegistryKey Key = Registry.ClassesRoot.CreateSubKey(ProtocolName);
                Key.CreateSubKey("DefaultIcon").SetValue("", System.Reflection.Assembly.GetEntryAssembly().Location + ",1");
                Key.SetValue("", ProtocolName + ":Protocol");
                Key.SetValue("URL Protocol", "");
                Key.CreateSubKey(@"shell\open\command");
                Key.SetValue("", System.Reflection.Assembly.GetEntryAssembly().Location + " %1");
                Key.Close();
            }
            catch (Exception)
            {
        
            }       
        }
    }
}
