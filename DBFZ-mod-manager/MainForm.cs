using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using SharpCompress.Readers;
using System.Text.RegularExpressions;

namespace ModManager
{
    public partial class MainForm : Form
    {
        private string GamePath = Properties.Settings.Default.gamePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePathTextBox.Text = this.GamePath;

            // Register custom URL protocol
            /*try
            {
                RegistryKey Key = Registry.ClassesRoot.CreateSubKey("dbfmm");
                Key.CreateSubKey("DefaultIcon").SetValue("", System.Reflection.Assembly.GetEntryAssembly().Location + ",1");
                Key.SetValue("", "dbfmm:Protocol");
                Key.SetValue("URL Protocol", "");
                Key.CreateSubKey(@"shell\open\command").SetValue("", System.Reflection.Assembly.GetEntryAssembly().Location + " % 1");
            }
            catch (Exception)
            {
        
            }*/

            // check if the user has the game installed on thier primary drive 
            if (Directory.Exists(this.GamePath))
            {
                this.LoadModsList();
            }
            else
            {
                MessageBox.Show("DragonBallFighterZ is not installed in the default location. Please go to 'Options' and choose the correct game path!");
            }
        }

        public string ActiveModPath() {
            return this.GamePath + @"RED\Content\Paks\~mods\";
        }

        public string InactiveModPath()
        {
            return this.GamePath + @"RED\Content\Paks\inactive-mods\";
        }

        private void LoadModsList()
        {
            modsList.DataSource = null;
            modsList.Rows.Clear();

            this.LoadMods(ActiveModPath());
            this.LoadMods(InactiveModPath());
        }

        private void LoadMods(string path)
        {
            bool active = (path == ActiveModPath());

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string[] files = Directory.GetFiles(path, "*.pak");

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string name = Path.GetFileNameWithoutExtension(fileInfo.Name);
                
                // Load mod details if an ini exists
                var details = Mod.Detail(path + name + ".ini");

                this.modsList.Rows.Add(
                    active, 
                    (string.IsNullOrEmpty(details["Name"])) 
                        ? Regex.Replace(name, "(^[a-z]+|[A-Z]+(?![a-z])|[A-Z][a-z]+)", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim() 
                        : details["Name"],  // fallback to file name if no ini is present
                    details["Author"], 
                    details["Version"], 
                    details["Description"]
                );
            }
        }

        private void refreshModsList_Click(object sender, EventArgs e)
        {
            this.LoadModsList();
        }

        private void openModsFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ActiveModPath());
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            this.SaveMods();
            Process.Start("steam://rungameid/678950");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.SaveMods();
            MessageBox.Show("Changes saved!");
        }

        private void SaveMods()
        {
            this.GamePath = gamePathTextBox.Text;
            Properties.Settings.Default.gamePath = gamePathTextBox.Text;
            Properties.Settings.Default.Save();

            foreach (DataGridViewRow row in this.modsList.Rows)
            {
                string active = row.Cells["modsActive"].Value.ToString();
                string name = row.Cells["modsName"].Value.ToString();

                if (active == "True")
                {
                    Mod.Move(InactiveModPath() + name + ".pak", ActiveModPath() + name + ".pak");
                    Mod.Move(this.InactiveModPath() + name + ".sig", ActiveModPath() + name + ".sig");
                    Mod.Move(this.InactiveModPath() + name + ".ini", ActiveModPath() + name + ".ini");
                }
                else
                {
                    Mod.Move(ActiveModPath() + name + ".pak", InactiveModPath() + name + ".pak");
                    Mod.Move(ActiveModPath() + name + ".sig", InactiveModPath() + name + ".sig");
                    Mod.Move(this.InactiveModPath() + name + ".ini", ActiveModPath() + name + ".ini");
                }
            }
        }

        private void patchExe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to patch DragonBallFighterZ.exe? \n\n (This is required to use mods and can be reverted at any time by going into Steam and choosing 'Verify Integrity of Game Files')", "Patch DragonBallFighterZ.exe", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.WriteAllBytes(this.GamePath + "DBFighterZ.exe", Properties.Resources.DBFighterZ);
                    MessageBox.Show("DragonBallFighterZ.exe has been successfully patched!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("The following error occurred when patching the game: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Once EasyAntiCheat opens, choose 'Dragon Ball Fighter Z' and click uninstall.");
            Process.Start(this.GamePath + @"EasyAntiCheat\EasyAntiCheat_Setup.exe");
        }

        private void gamePathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowser.SelectedPath + @"\DBFighterZ.exe"))
                {
                    this.gamePathTextBox.Text = folderBrowser.SelectedPath + @"\";
                    this.GamePath = folderBrowser.SelectedPath + @"\";              
                    this.LoadModsList();
                }
                else
                {
                    MessageBox.Show("Error, could not find DBFighterZ.exe in this folder. Are you sure you chose the correct folder?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void installModBtn_Click(object sender, EventArgs e)
        {
            // Browse for the mod zip
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "ZIP (*.ZIP,*.zip,*.RAR,*.rar)|*.ZIP;*.zip;*.RAR;*.rar";
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (Mod.Add(file.FileName))
                {
                    // Reload mod list
                    this.LoadModsList();

                    MessageBox.Show("Mod successfully installed!");
                }
                else
                {
                    MessageBox.Show("No mods could be found in this zip file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
