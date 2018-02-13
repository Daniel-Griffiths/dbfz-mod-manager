namespace ModManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startGameBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.modsList = new System.Windows.Forms.DataGridView();
            this.modsFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.disableEasyAntiCheatBtn = new System.Windows.Forms.Button();
            this.patchExe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.gamePathBtn = new System.Windows.Forms.Button();
            this.installModBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.refreshModsBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openModsBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modName
            // 
            this.modName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modName.FillWeight = 200F;
            this.modName.HeaderText = "Name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            // 
            // modActive
            // 
            this.modActive.FillWeight = 70F;
            this.modActive.HeaderText = "Active";
            this.modActive.Name = "modActive";
            this.modActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modActive.Width = 70;
            // 
            // startGameBtn
            // 
            this.startGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startGameBtn.AutoSize = true;
            this.startGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startGameBtn.Depth = 0;
            this.startGameBtn.Icon = null;
            this.startGameBtn.Location = new System.Drawing.Point(13, 566);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startGameBtn.MinimumSize = new System.Drawing.Size(161, 29);
            this.startGameBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Primary = true;
            this.startGameBtn.Size = new System.Drawing.Size(161, 36);
            this.startGameBtn.TabIndex = 9;
            this.startGameBtn.Text = "Save and PLay";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.AutoSize = true;
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.Depth = 0;
            this.saveBtn.Icon = null;
            this.saveBtn.Location = new System.Drawing.Point(181, 566);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.MinimumSize = new System.Drawing.Size(161, 29);
            this.saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Primary = true;
            this.saveBtn.Size = new System.Drawing.Size(161, 36);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 23);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(866, 50);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(9, 83);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(842, 474);
            this.materialTabControl1.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.modsList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(834, 448);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Mods";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // modsList
            // 
            this.modsList.AllowUserToAddRows = false;
            this.modsList.AllowUserToDeleteRows = false;
            this.modsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modsFileName,
            this.modsActive,
            this.modsName,
            this.modAuthor,
            this.modVersion,
            this.modDescription});
            this.modsList.Location = new System.Drawing.Point(4, 4);
            this.modsList.Margin = new System.Windows.Forms.Padding(2);
            this.modsList.Name = "modsList";
            this.modsList.RowHeadersVisible = false;
            this.modsList.RowTemplate.Height = 24;
            this.modsList.Size = new System.Drawing.Size(826, 443);
            this.modsList.TabIndex = 9;
            // 
            // modsFileName
            // 
            this.modsFileName.HeaderText = "FileName";
            this.modsFileName.Name = "modsFileName";
            this.modsFileName.Visible = false;
            // 
            // modsActive
            // 
            this.modsActive.FillWeight = 70F;
            this.modsActive.HeaderText = "Active";
            this.modsActive.Name = "modsActive";
            this.modsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modsActive.Width = 70;
            // 
            // modsName
            // 
            this.modsName.HeaderText = "Name";
            this.modsName.Name = "modsName";
            this.modsName.ReadOnly = true;
            this.modsName.Width = 200;
            // 
            // modAuthor
            // 
            this.modAuthor.HeaderText = "Author";
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.ReadOnly = true;
            // 
            // modVersion
            // 
            this.modVersion.HeaderText = "Version";
            this.modVersion.Name = "modVersion";
            this.modVersion.ReadOnly = true;
            // 
            // modDescription
            // 
            this.modDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modDescription.HeaderText = "Description";
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(834, 448);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.disableEasyAntiCheatBtn);
            this.groupBox2.Controls.Add(this.patchExe);
            this.groupBox2.Location = new System.Drawing.Point(5, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 60);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc (Not necessary, but might be required for certain mods)";
            // 
            // disableEasyAntiCheatBtn
            // 
            this.disableEasyAntiCheatBtn.Location = new System.Drawing.Point(142, 20);
            this.disableEasyAntiCheatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.disableEasyAntiCheatBtn.Name = "disableEasyAntiCheatBtn";
            this.disableEasyAntiCheatBtn.Size = new System.Drawing.Size(130, 28);
            this.disableEasyAntiCheatBtn.TabIndex = 9;
            this.disableEasyAntiCheatBtn.Text = "Disable EasyAntiCheat";
            this.disableEasyAntiCheatBtn.UseVisualStyleBackColor = true;
            this.disableEasyAntiCheatBtn.Click += new System.EventHandler(this.disableEasyAntiCheatBtn_Click);
            // 
            // patchExe
            // 
            this.patchExe.Location = new System.Drawing.Point(8, 20);
            this.patchExe.Margin = new System.Windows.Forms.Padding(2);
            this.patchExe.Name = "patchExe";
            this.patchExe.Size = new System.Drawing.Size(130, 28);
            this.patchExe.TabIndex = 8;
            this.patchExe.Text = "Patch Exe";
            this.patchExe.UseVisualStyleBackColor = true;
            this.patchExe.Click += new System.EventHandler(this.patchExe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gamePathTextBox);
            this.groupBox1.Controls.Add(this.gamePathBtn);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 71);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(change this if the game is installed in a different directory)";
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Location = new System.Drawing.Point(71, 15);
            this.gamePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.ReadOnly = true;
            this.gamePathTextBox.Size = new System.Drawing.Size(398, 20);
            this.gamePathTextBox.TabIndex = 3;
            // 
            // gamePathBtn
            // 
            this.gamePathBtn.Location = new System.Drawing.Point(473, 14);
            this.gamePathBtn.Margin = new System.Windows.Forms.Padding(2);
            this.gamePathBtn.Name = "gamePathBtn";
            this.gamePathBtn.Size = new System.Drawing.Size(26, 21);
            this.gamePathBtn.TabIndex = 4;
            this.gamePathBtn.Text = "...";
            this.gamePathBtn.UseVisualStyleBackColor = true;
            this.gamePathBtn.Click += new System.EventHandler(this.gamePathBtn_Click);
            // 
            // installModBtn
            // 
            this.installModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installModBtn.AutoSize = true;
            this.installModBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installModBtn.Depth = 0;
            this.installModBtn.Icon = null;
            this.installModBtn.Location = new System.Drawing.Point(350, 566);
            this.installModBtn.Margin = new System.Windows.Forms.Padding(2);
            this.installModBtn.MinimumSize = new System.Drawing.Size(161, 29);
            this.installModBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.installModBtn.Name = "installModBtn";
            this.installModBtn.Primary = true;
            this.installModBtn.Size = new System.Drawing.Size(161, 36);
            this.installModBtn.TabIndex = 13;
            this.installModBtn.Text = "Install Mod";
            this.installModBtn.UseVisualStyleBackColor = true;
            this.installModBtn.Click += new System.EventHandler(this.installModBtn_Click);
            // 
            // refreshModsBtn
            // 
            this.refreshModsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshModsBtn.AutoSize = true;
            this.refreshModsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshModsBtn.Depth = 0;
            this.refreshModsBtn.Icon = null;
            this.refreshModsBtn.Location = new System.Drawing.Point(518, 566);
            this.refreshModsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshModsBtn.MinimumSize = new System.Drawing.Size(161, 29);
            this.refreshModsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshModsBtn.Name = "refreshModsBtn";
            this.refreshModsBtn.Primary = true;
            this.refreshModsBtn.Size = new System.Drawing.Size(161, 36);
            this.refreshModsBtn.TabIndex = 14;
            this.refreshModsBtn.Text = "Refresh Mods List";
            this.refreshModsBtn.UseVisualStyleBackColor = true;
            this.refreshModsBtn.Click += new System.EventHandler(this.refreshModsList_Click);
            // 
            // openModsBtn
            // 
            this.openModsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openModsBtn.AutoSize = true;
            this.openModsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openModsBtn.Depth = 0;
            this.openModsBtn.Icon = null;
            this.openModsBtn.Location = new System.Drawing.Point(686, 566);
            this.openModsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openModsBtn.MinimumSize = new System.Drawing.Size(161, 29);
            this.openModsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openModsBtn.Name = "openModsBtn";
            this.openModsBtn.Primary = true;
            this.openModsBtn.Size = new System.Drawing.Size(161, 36);
            this.openModsBtn.TabIndex = 15;
            this.openModsBtn.Text = "Open Mods Folder";
            this.openModsBtn.UseVisualStyleBackColor = true;
            this.openModsBtn.Click += new System.EventHandler(this.openModsFolderBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 614);
            this.Controls.Add(this.refreshModsBtn);
            this.Controls.Add(this.installModBtn);
            this.Controls.Add(this.openModsBtn);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(829, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modActive;
        private MaterialSkin.Controls.MaterialRaisedButton startGameBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveBtn;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView modsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDescription;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button disableEasyAntiCheatBtn;
        private System.Windows.Forms.Button patchExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gamePathBtn;
        private System.Windows.Forms.TextBox gamePathTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton installModBtn;
        private MaterialSkin.Controls.MaterialRaisedButton refreshModsBtn;
        private MaterialSkin.Controls.MaterialRaisedButton openModsBtn;
    }
}

