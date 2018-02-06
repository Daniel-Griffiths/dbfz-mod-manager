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
            try {
                // Create new key for desired URL protocol
                RegistryKey key = Registry.ClassesRoot.CreateSubKey(Uri);

                // Assign protocol
                key.SetValue(null, Uri);
                key.SetValue("URL Protocol", string.Empty);

                // Register Shell values
                Registry.ClassesRoot.CreateSubKey(Uri + "\\Shell");
                Registry.ClassesRoot.CreateSubKey(Uri + "\\Shell\\open");
                key = Registry.ClassesRoot.CreateSubKey(Uri + "\\Shell\\open\\command");

                // Specify application handling the URL protocol
                key.SetValue(null, "\"" + System.Reflection.Assembly.GetEntryAssembly().Location + "\" %1");
            } catch (Exception exception) {
                //MessageBox.Show(exception.Message);
            }            
        }
    }
}
