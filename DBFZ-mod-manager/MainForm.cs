using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;
using MaterialSkin;

namespace ModManager
{
    public partial class MainForm : MaterialForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            // register the custom protocol for gamebanana
            Protocol.Register();

            // Check if the exe was opened from gamebanana
            GameBanana.Process(Environment.GetCommandLineArgs());

            // check if the user has the game installed on thier primary drive 
            if (Helper.AttemptToFindAndSetGameDirectoryWithoutUserInteraction())
            {
                //Success
                this.LoadModsList();
            } else {
                //Failure (Defaults to path set in application settings)
                MessageBox.Show("Could not find DragonBallFighterZ install location. Please go to 'Options' and choose the correct game path!");
            }

            // Update settings textbox
            gamePathTextBox.Text = UserConfig.ConfigSingleton.Instance.Config.GameDirectory;
        }

        private void LoadModsList()
        {
            modsList.DataSource = null;
            modsList.Rows.Clear();

            this.LoadMods(Helper.ActiveModDirectory);
            this.LoadMods(Helper.InactiveModDirectory);
        }

        private void LoadMods(string path)
        {
            bool active = (path == Helper.ActiveModDirectory);

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }

            foreach (string file in Directory.GetFiles(path, "*.pak")) {
                FileInfo fileInfo = new FileInfo(file);
                string name = Path.GetFileNameWithoutExtension(fileInfo.Name);

                // Load mod details if an ini exists
                var details = Mod.Detail( System.IO.Path.Combine(path, name + ".ini") );

                this.modsList.Rows.Add(
                    name,
                    active,
                    (string.IsNullOrEmpty(details["Name"]))
                        ? Regex.Replace(name, "(^[a-z]+|[A-Z]+(?![a-z])|[A-Z][a-z]+)", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim()  // fallback to file name if no ini is present
                        : details["Name"], 
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
            Process.Start("explorer.exe", Helper.ActiveModDirectory);
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
            UserConfig.ConfigSingleton.Instance.Config.GameDirectory = gamePathTextBox.Text;
            Properties.Settings.Default.gamePath = gamePathTextBox.Text;
            Properties.Settings.Default.Save();

            foreach (DataGridViewRow row in this.modsList.Rows) {
                string active = row.Cells["modsActive"].Value.ToString();
                string name = row.Cells["modsFileName"].Value.ToString();

                if (active == "True") {
                    Mod.Move( System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".pak") , System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".pak") );
                    Mod.Move( System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".sig") , System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".sig") );
                    Mod.Move( System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".ini") , System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".ini") );
                } else {
                    Mod.Move( System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".pak") , System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".pak") );
                    Mod.Move( System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".sig") , System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".sig") );
                    Mod.Move( System.IO.Path.Combine(Helper.ActiveModDirectory, name + ".ini") , System.IO.Path.Combine(Helper.InactiveModDirectory, name + ".ini") );
                }
            }
        }

        private void patchExe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to patch DragonBallFighterZ.exe? \n\n (This can be reverted at any time by going into Steam and choosing 'Verify Integrity of Game Files')", "Patch DragonBallFighterZ.exe", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    File.WriteAllBytes(UserConfig.ConfigSingleton.Instance.Config.GameDirectory + "DBFighterZ.exe", Properties.Resources.DBFighterZ);
                    MessageBox.Show("DragonBallFighterZ.exe has been successfully patched!");
                } catch (Exception exception) {
                    MessageBox.Show("The following error occurred when patching the game: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void disableEasyAntiCheatBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Once EasyAntiCheat opens, choose 'Dragon Ball Fighter Z' and click uninstall.");
            Process.Start( Helper.EasyAntiCheatEXEPath );
        }

        private void gamePathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK) {
                if ( Helper.IsValidGameDirectory( folderBrowser.SelectedPath ) ) {
                    this.gamePathTextBox.Text = folderBrowser.SelectedPath;
                    UserConfig.ConfigSingleton.Instance.Config.GameDirectory = folderBrowser.SelectedPath;
                    this.LoadModsList();
                } else {
                    MessageBox.Show("Error, could not find DBFighterZ.exe in this folder. Are you sure you chose the correct folder?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void installModBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "ZIP (*.ZIP,*.zip,*.RAR,*.rar,*.7Z,*.7z)|*.ZIP;*.zip;*.RAR;*.rar;*.7Z;*.7z";
            if (file.ShowDialog() == DialogResult.OK) {
                if (Mod.Add(file.FileName)) {
                    this.LoadModsList();
                    MessageBox.Show("Mod successfully installed!");
                } else {
                    MessageBox.Show("No mods could be found in this zip file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /* private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             Process.Start(linkLabel1.Text);
         }*/
    }
}
