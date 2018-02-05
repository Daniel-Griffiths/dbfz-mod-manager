using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            modDescription.Text = ParseHtml(values[1].Value) + ParseHtml(values[2].Value);
            //string modUserId = values[3].Value;
            modImage.Load(values[4].Value);
            
        }

        public string ParseHtml(string html)
        {
            return Regex.Replace(
                html
                .Replace("</br>", Environment.NewLine)
                .Replace("<br>", Environment.NewLine)
                .Replace("&nbsp;", " "), 
            "<.*?>", String.Empty);
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
            try
            {
                WebClient wc = new WebClient();

                string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\temp\temp.zip";

                wc.DownloadFile(this.downloadUrl, fileName);

                if (Mod.Add(fileName))
                {
                    MessageBox.Show("Mod successfully installed!");
                }
                else
                {
                    MessageBox.Show("No mods could be found in this zip file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
