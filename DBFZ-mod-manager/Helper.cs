using System;
using System.Text.RegularExpressions;

namespace ModManager
{
    class Helper
    {
        public static string ActiveModDirectory { get { return System.IO.Path.Combine(new string[] { UserConfig.ConfigSingleton.Instance.Config.GameDirectory, "RED", "Content", "Paks", "~mods" }); } }
        public static string InactiveModDirectory { get { return System.IO.Path.Combine( UserConfig.ConfigSingleton.Instance.Config.GameDirectory, "inactive-mods" ); } }
        public static string CurrentGameEXEPath { get { return System.IO.Path.Combine(new string[] { UserConfig.ConfigSingleton.Instance.Config.GameDirectory, "DBFighterZ.exe" }); } }
        public static string EasyAntiCheatDirectory { get { return System.IO.Path.Combine(new string[] { UserConfig.ConfigSingleton.Instance.Config.GameDirectory, "EasyAntiCheat" }); } }
        public static string EasyAntiCheatEXEPath { get { return System.IO.Path.Combine(new string[] { UserConfig.ConfigSingleton.Instance.Config.GameDirectory, "EasyAntiCheat", "EasyAntiCheat_Setup.exe" }); } }

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

        /// <summary>
        /// Checks to see if the current game directory exists
        /// and is the valid directory for DragonBall FighterZ.
        /// </summary>
        /// <returns></returns>
        public static bool IsValidGameDirectory(string newGameDirectory)
        {
            //Basic Check could be improved in the future
            if (System.IO.Directory.Exists(newGameDirectory))
                if (System.IO.File.Exists( System.IO.Path.Combine(newGameDirectory, "DBFighterZ.exe") ))
                    return true;

            return false;
        }


        /// <summary>
        /// Attempts to find and set the game directory using the Windows regestry.
        /// Returns false if unsuccessfull.
        /// </summary>
        /// <returns></returns>
        public static bool AttemptToFindAndSetGameDirectoryWithoutUserInteraction()
        {
            //Check if path is already valid first
            if (Helper.IsValidGameDirectory( UserConfig.ConfigSingleton.Instance.Config.GameDirectory ))
                return true;

            //temp vars
            string newGameDirectory = string.Empty;

            //Attempt to find install location
            if (Helper.GetWindowsRegestryValueData(Properties.Settings.Default.steamWindows64BitRegistryKey, "InstallPath", out string steamClientDirectory))
            {
                newGameDirectory = System.IO.Path.Combine(new string[] { steamClientDirectory, "steamapps", "common", "DRAGON BALL FighterZ" });
                if (Helper.IsValidGameDirectory( newGameDirectory ))
                {
                    UserConfig.ConfigSingleton.Instance.Config.GameDirectory = newGameDirectory;//Update config (will also update UserConfig.json file)
                    return true;
                }
                    
            }

            return false;//failed to find anything
        }
    }
}
