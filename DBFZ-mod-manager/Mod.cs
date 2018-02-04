using System.IO;

namespace ModManager
{
    class Mod
    {
        // Move a mod to a new location
        public static void Move(string source, string dest)
        {
            if (File.Exists(source))
            {
                File.Copy(source, dest, true);
                File.Delete(source);
            }
        }
    }
}
