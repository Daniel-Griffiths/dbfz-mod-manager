using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DBFZ_mod_manager
{
    public partial class Form1 : Form
    {
        private string drive;
        private string gamePath;
        private string activeModPath;
        private string inactiveModPath;

        public Form1()
        {
            InitializeComponent();
            this.drive = Properties.Settings.Default.drive;
            this.gamePath = this.drive + @"Program Files (x86)\Steam\steamapps\common\DRAGON BALL FighterZ\";
            this.activeModPath = this.gamePath +  @"RED\Content\Paks\~mods\";
            this.inactiveModPath = this.gamePath + @"RED\Content\Paks\inactive-mods\";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadDrives();

            // check if the user has the game installed on thier primary drive 
            if (Directory.Exists(this.gamePath)){
                this.loadModsList();
            } else {
                MessageBox.Show("DragonBallFighterZ is not installed on your C:\\ drive! Please go to 'Options' and choose the correct drive.");
            }
        }

        private void loadModsList()
        {
            modsList.DataSource = null;
            modsList.Rows.Clear();

            this.loadMods(this.activeModPath);
            this.loadMods(this.inactiveModPath);
        }

        private void loadMods(string path) 
        {
            bool active = (path == this.activeModPath);

            if (!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }

            string[] files = Directory.GetFiles(path, "*.pak");

            foreach (string file in files){
                FileInfo fileInfo = new FileInfo(file);
                this.modsList.Rows.Add(active, fileInfo.Name.Replace(".pak", ""), file);
            }
        }

        private void refreshModsList_Click(object sender, EventArgs e)
        {
            this.loadModsList();
        }

        private void openModsFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", this.activeModPath);
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            this.saveMods();
            Process.Start("steam://rungameid/678950");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.saveMods();
            MessageBox.Show("Changes saved!");
        }

        private void moveFile(string source, string dest)
        {
            if (File.Exists(source)){
                File.Copy(source, dest, true);
                File.Delete(source);
            }
        }

        private void saveMods()
        {
            Properties.Settings.Default.drive = driveList.Text;
            Properties.Settings.Default.Save();

            foreach (DataGridViewRow row in this.modsList.Rows){
                string active = row.Cells["modsActive"].Value.ToString();
                string name = row.Cells["modsName"].Value.ToString();

                if (active == "True"){
                    this.moveFile(this.inactiveModPath + name + ".pak", this.activeModPath + name + ".pak");
                    this.moveFile(this.inactiveModPath + name + ".sig", this.activeModPath + name + ".sig");
                } else {
                    this.moveFile(this.activeModPath + name + ".pak", this.inactiveModPath + name + ".pak");
                    this.moveFile(this.activeModPath + name + ".sig", this.inactiveModPath + name + ".sig");
                }                
            }
        }

        private void patchExe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to patch DragonBallFighterZ.exe? \n\n (This is required to use mods and can be reverted at any time by going into Steam and choosing 'Verify Integrity of Game Files')", "Patch DragonBallFighterZ.exe", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes){
                try{
                    File.WriteAllBytes(this.gamePath + "DBFighterZ.exe", Properties.Resources.DBFighterZ);
                    MessageBox.Show("DragonBallFighterZ.exe has been successfully patched!");
                }
                catch (Exception exception){
                    MessageBox.Show("The following error occurred when patching the game: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Once EasyAntiCheat opens, choose 'Dragon Ball Fighter Z' and click uninstall.");
            Process.Start(this.gamePath + @"EasyAntiCheat\EasyAntiCheat_Setup.exe");
        }

        private void loadDrives()
        {
            foreach(var drive in DriveInfo.GetDrives()){
               driveList.Items.Add(drive.Name);
            }

            driveList.SelectedIndex = driveList.FindStringExact(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)));
        }
    }
}
