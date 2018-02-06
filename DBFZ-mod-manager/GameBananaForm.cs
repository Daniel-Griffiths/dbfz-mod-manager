using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ModManager
{
    public partial class GameBananaForm : Form
    {
        public string downloadUrl;

        public GameBananaForm()
        {
            InitializeComponent();
        }

        public void SetContent(List<System.Xml.Linq.XElement> values)
        {
            modName.Text = values[0].Value;
            modDescription.Text = Helper.StripHtml(values[1].Value) + Helper.StripHtml(values[2].Value);
            modImage.Load(values[4].Value);
        }

        private void GameBananaForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void installModBtn_Click(object sender, EventArgs e)
        {
            try {
                WebClient wc = new WebClient();
                string tempDir = AppDomain.CurrentDomain.BaseDirectory + @"\temp\";
                string fileName = tempDir + "temp.zip";

                if (!Directory.Exists(tempDir)) {
                    Directory.CreateDirectory(tempDir);
                }

                wc.DownloadFile(this.downloadUrl, fileName);

                if (Mod.Add(fileName)) {
                    MessageBox.Show("Mod successfully installed!");
                    Application.Exit();
                } else {
                    MessageBox.Show("No mods could be found in this zip file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameBananaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
