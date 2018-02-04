using SharpCompress.Readers;
using System;
using System.IO;
using System.Windows.Forms;

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

        // Adds a new mod
        public static void Add(string path)
        {
            string tempDir = AppDomain.CurrentDomain.BaseDirectory + @"\temp";

            // Unzip the files to a temp dir
            using (Stream stream = File.OpenRead(path))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        reader.WriteEntryToDirectory(tempDir, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                    }
                }
            }

            // Hunt the archive for .pak and .sig files
            foreach (string mod in Directory.GetFiles(tempDir, "*.pak", SearchOption.AllDirectories)) {
                // Move the mod file
                Move(mod, Properties.Settings.Default.gamePath + @"RED\Content\Paks\~mods\" + Path.GetFileName(mod));
                // Pretty hacky way of getting .sig, need to change this.
                Move(mod.Replace(".pak", ".sig"), Properties.Settings.Default.gamePath + @"RED\Content\Paks\~mods\" + Path.GetFileName(mod).Replace(".pak",".sig"));
            }

            // Delete the temp files
            Delete(tempDir);
        }

        // Delete a folder and all contained files
        public static void Delete(string path)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            Directory.Delete(path);
        }
    }
}
