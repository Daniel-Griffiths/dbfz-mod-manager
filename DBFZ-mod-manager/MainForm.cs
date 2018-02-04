using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace ModManager
{
    public partial class MainForm : Form
    {
        private string GamePath;
        private string ActiveModPath;
        private string InactiveModPath; 

        public MainForm()
        {
            InitializeComponent();
            this.GamePath = Properties.Settings.Default.gamePath;
            this.ActiveModPath = this.GamePath + @"RED\Content\Paks\~mods\";
            this.InactiveModPath = this.GamePath + @"RED\Content\Paks\inactive-mods\";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePathTextBox.Text = this.GamePath;

            // Register custom URL protocol
            


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

        private void LoadModsList()
        {
            modsList.DataSource = null;
            modsList.Rows.Clear();

            this.LoadMods(this.ActiveModPath);
            this.LoadMods(this.InactiveModPath);
        }

        private void LoadMods(string path)
        {
            bool active = (path == this.ActiveModPath);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string[] files = Directory.GetFiles(path, "*.pak");

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                this.modsList.Rows.Add(active, fileInfo.Name.Replace(".pak", ""), file);
            }
        }

        private void refreshModsList_Click(object sender, EventArgs e)
        {
            this.LoadModsList();
        }

        private void openModsFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", this.ActiveModPath);
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
                    Mod.Move(this.InactiveModPath + name + ".pak", this.ActiveModPath + name + ".pak");
                    Mod.Move(this.InactiveModPath + name + ".sig", this.ActiveModPath + name + ".sig");
                }
                else
                {
                    Mod.Move(this.ActiveModPath + name + ".pak", this.InactiveModPath + name + ".pak");
                    Mod.Move(this.ActiveModPath + name + ".sig", this.InactiveModPath + name + ".sig");
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
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog1.SelectedPath + @"\DBFighterZ.exe"))
                {
                    this.gamePathTextBox.Text = folderBrowserDialog1.SelectedPath + @"\";
                    this.GamePath = folderBrowserDialog1.SelectedPath + @"\";              
                    this.ActiveModPath = this.GamePath + @"RED\Content\Paks\~mods\";
                    this.InactiveModPath = this.GamePath + @"RED\Content\Paks\inactive-mods\";
                    this.LoadModsList();
                }
                else
                {
                    MessageBox.Show("Error, could not find DBFighterZ.exe in this folder. Are you sure you chose the correct folder?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
