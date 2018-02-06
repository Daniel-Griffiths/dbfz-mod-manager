using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ModManager
{
    class Protocol
    {
        public static string Uri = "dbfmm";

        public static void Register()
        {
            try
            {
                RegistryKey Key = Registry.ClassesRoot.CreateSubKey(Uri);
                Key.CreateSubKey("DefaultIcon").SetValue("", System.Reflection.Assembly.GetEntryAssembly().Location + ",1");
                Key.SetValue("", Uri + ":Protocol");
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
