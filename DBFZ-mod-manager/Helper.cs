using System;
using System.Text.RegularExpressions;

namespace ModManager
{
    class Helper
    {
        // Remove html from a string
        public static string StripHtml(string html)
        {
            return Regex.Replace(
                html
                .Replace("</br>", Environment.NewLine)
                .Replace("<br>", Environment.NewLine)
                .Replace("&nbsp;", " "),
                "<.*?>", String.Empty
            );
        }

        /// <summary>
        /// Attempts to read Window's regestry value's data. Returns false if unsuccessfull.
        /// </summary>
        /// <param name="KeyName">Key with HKEY_LOCAL_MACHINE as the base address.</param>
        /// <param name="ValueName">Address value</param>
        /// <param name="data">Address value data</param>
        /// <returns></returns>
        public static bool GetWindowsRegestryValueData(string KeyName, string ValueName, out string data)
        {
            data = null;
            try
            {
                using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyName))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(ValueName);
                        if (o != null)
                        {
                            data = (string)o;
                            return true;
                        }
                    }
                }
            }
            catch { }

            return false;
        }
    }
}
