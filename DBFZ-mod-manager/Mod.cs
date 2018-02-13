using System;
using System.IO;
using System.Windows.Forms;
using SharpCompress.Readers;
using SharpCompress.Archives;
using System.Collections.Specialized;

namespace ModManager
{
    class Mod
    {
        // Move a mod to a new location
        public static void Move(string source, string dest)
        {
            if (File.Exists(source)) {
                File.Copy(source, dest, true);
                File.Delete(source);
            }
        }

        // Delete a folder and all contained files
        public static void Delete(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles()) {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories()) {
                dir.Delete(true);
            }

            Directory.Delete(path);
        }

        // Gets the details from the mod ini
        public static NameValueCollection Detail(string path)
        {        
            return (File.Exists(path)) ? Ini.Parse(path) : new NameValueCollection();
        }

        // Adds a new mod
        public static bool Add(string path)
        {
            string tempDir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp");
            bool installed = false;

            // Unzip the files to a temp dir
            using (var archive = ArchiveFactory.Open(path)) {
                var reader = archive.ExtractAllEntries();
                while (reader.MoveToNextEntry()) {
                    if (!reader.Entry.IsDirectory) {
                        reader.WriteEntryToDirectory(tempDir, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                    }
                }
            }

            // Hunt the archive for .pak and .sig files
            foreach (string mod in Directory.GetFiles(tempDir, "*.pak", SearchOption.AllDirectories)) {
                installed = true;

                if (File.Exists( System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod) ))) {
                    DialogResult dialogResult = MessageBox.Show("A mod with this name already exists, do you want to overwrite it?", "Overwrite Mod", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        Move(mod, System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod) ));
                        Move(mod.Replace(".pak", ".sig"), System.IO.Path.Combine( Helper.ActiveModDirectory , Path.GetFileName(mod).Replace(".pak", ".sig") ));
                        Move(mod.Replace(".pak", ".ini"), System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod).Replace(".pak", ".ini") ));
                    }
                } else {
                    Move(mod, System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod) ));
                    Move(mod.Replace(".pak", ".sig"), System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod).Replace(".pak", ".sig") ));
                    Move(mod.Replace(".pak", ".ini"), System.IO.Path.Combine( Helper.ActiveModDirectory, Path.GetFileName(mod).Replace(".pak", ".ini") ));
                }
            }

            Delete(tempDir);

            return installed;
        }
    }
}
