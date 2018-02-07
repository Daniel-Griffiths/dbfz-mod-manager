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
            this.installModBtn = new System.Windows.Forms.Button();
            this.modsList = new System.Windows.Forms.DataGridView();
            this.modsFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openModsFolderBtn = new System.Windows.Forms.Button();
            this.refreshModsListBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.disableEasyAntiCheatBtn = new System.Windows.Forms.Button();
            this.patchExe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamePathBtn = new System.Windows.Forms.Button();
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
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
            this.startGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.startGameBtn.Depth = 0;
            this.startGameBtn.Icon = null;
            this.startGameBtn.Location = new System.Drawing.Point(22, 690);
            this.startGameBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Primary = true;
            this.startGameBtn.Size = new System.Drawing.Size(179, 36);
            this.startGameBtn.TabIndex = 9;
            this.startGameBtn.Text = "Save and PLay";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Depth = 0;
            this.saveBtn.Icon = null;
            this.saveBtn.Location = new System.Drawing.Point(208, 690);
            this.saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Primary = true;
            this.saveBtn.Size = new System.Drawing.Size(179, 36);
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
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 28);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1106, 61);
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
            this.materialTabControl1.Location = new System.Drawing.Point(12, 102);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1081, 582);
            this.materialTabControl1.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.installModBtn);
            this.tabPage3.Controls.Add(this.modsList);
            this.tabPage3.Controls.Add(this.openModsFolderBtn);
            this.tabPage3.Controls.Add(this.refreshModsListBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1073, 553);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Mods";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // installModBtn
            // 
            this.installModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installModBtn.Location = new System.Drawing.Point(6, 514);
            this.installModBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.installModBtn.Name = "installModBtn";
            this.installModBtn.Size = new System.Drawing.Size(173, 34);
            this.installModBtn.TabIndex = 12;
            this.installModBtn.Text = "Install Mod";
            this.installModBtn.UseVisualStyleBackColor = true;
            this.installModBtn.Click += new System.EventHandler(this.installModBtn_Click);
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
            this.modsList.Location = new System.Drawing.Point(6, 5);
            this.modsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modsList.Name = "modsList";
            this.modsList.RowHeadersVisible = false;
            this.modsList.RowTemplate.Height = 24;
            this.modsList.Size = new System.Drawing.Size(1061, 505);
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
            // openModsFolderBtn
            // 
            this.openModsFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openModsFolderBtn.Location = new System.Drawing.Point(366, 514);
            this.openModsFolderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openModsFolderBtn.Name = "openModsFolderBtn";
            this.openModsFolderBtn.Size = new System.Drawing.Size(173, 34);
            this.openModsFolderBtn.TabIndex = 10;
            this.openModsFolderBtn.Text = "Open Mods Folder";
            this.openModsFolderBtn.UseVisualStyleBackColor = true;
            this.openModsFolderBtn.Click += new System.EventHandler(this.openModsFolderBtn_Click);
            // 
            // refreshModsListBtn
            // 
            this.refreshModsListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshModsListBtn.Location = new System.Drawing.Point(186, 514);
            this.refreshModsListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshModsListBtn.Name = "refreshModsListBtn";
            this.refreshModsListBtn.Size = new System.Drawing.Size(173, 34);
            this.refreshModsListBtn.TabIndex = 11;
            this.refreshModsListBtn.Text = "Refresh Mods List";
            this.refreshModsListBtn.UseVisualStyleBackColor = true;
            this.refreshModsListBtn.Click += new System.EventHandler(this.refreshModsList_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1073, 553);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.disableEasyAntiCheatBtn);
            this.groupBox2.Controls.Add(this.patchExe);
            this.groupBox2.Location = new System.Drawing.Point(7, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1004, 74);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc (Not necessary, but might be required for certain mods)";
            // 
            // disableEasyAntiCheatBtn
            // 
            this.disableEasyAntiCheatBtn.Location = new System.Drawing.Point(189, 25);
            this.disableEasyAntiCheatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disableEasyAntiCheatBtn.Name = "disableEasyAntiCheatBtn";
            this.disableEasyAntiCheatBtn.Size = new System.Drawing.Size(173, 34);
            this.disableEasyAntiCheatBtn.TabIndex = 9;
            this.disableEasyAntiCheatBtn.Text = "Disable EasyAntiCheat";
            this.disableEasyAntiCheatBtn.UseVisualStyleBackColor = true;
            this.disableEasyAntiCheatBtn.Click += new System.EventHandler(this.disableEasyAntiCheatBtn_Click);
            // 
            // patchExe
            // 
            this.patchExe.Location = new System.Drawing.Point(11, 25);
            this.patchExe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patchExe.Name = "patchExe";
            this.patchExe.Size = new System.Drawing.Size(173, 34);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1004, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(change this if the game is installed in a different directory)";
            // 
            // gamePathBtn
            // 
            this.gamePathBtn.Location = new System.Drawing.Point(631, 17);
            this.gamePathBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamePathBtn.Name = "gamePathBtn";
            this.gamePathBtn.Size = new System.Drawing.Size(35, 26);
            this.gamePathBtn.TabIndex = 4;
            this.gamePathBtn.Text = "...";
            this.gamePathBtn.UseVisualStyleBackColor = true;
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Location = new System.Drawing.Point(95, 18);
            this.gamePathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.ReadOnly = true;
            this.gamePathTextBox.Size = new System.Drawing.Size(529, 22);
            this.gamePathTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 738);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1105, 738);
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

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modActive;
        private MaterialSkin.Controls.MaterialRaisedButton startGameBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveBtn;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button installModBtn;
        private System.Windows.Forms.DataGridView modsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDescription;
        private System.Windows.Forms.Button openModsFolderBtn;
        private System.Windows.Forms.Button refreshModsListBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button disableEasyAntiCheatBtn;
        private System.Windows.Forms.Button patchExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gamePathBtn;
        private System.Windows.Forms.TextBox gamePathTextBox;
    }
}

