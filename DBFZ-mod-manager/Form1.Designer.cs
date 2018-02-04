namespace DBFZ_mod_manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startGameBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modsList = new System.Windows.Forms.DataGridView();
            this.modsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patchExe = new System.Windows.Forms.Button();
            this.refreshModsListBtn = new System.Windows.Forms.Button();
            this.disableEasyAntiCheatBtn = new System.Windows.Forms.Button();
            this.openModsFolderBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.driveList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startGameBtn.Location = new System.Drawing.Point(10, 510);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(174, 35);
            this.startGameBtn.TabIndex = 1;
            this.startGameBtn.Text = "Save and Play";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(189, 510);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 35);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 506);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modsList);
            this.tabPage1.Controls.Add(this.patchExe);
            this.tabPage1.Controls.Add(this.refreshModsListBtn);
            this.tabPage1.Controls.Add(this.disableEasyAntiCheatBtn);
            this.tabPage1.Controls.Add(this.openModsFolderBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // modsList
            // 
            this.modsList.AllowUserToAddRows = false;
            this.modsList.AllowUserToDeleteRows = false;
            this.modsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modsActive,
            this.modsName});
            this.modsList.Location = new System.Drawing.Point(6, 6);
            this.modsList.Name = "modsList";
            this.modsList.RowHeadersVisible = false;
            this.modsList.RowTemplate.Height = 24;
            this.modsList.Size = new System.Drawing.Size(797, 422);
            this.modsList.TabIndex = 0;
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
            this.modsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modsName.HeaderText = "Name";
            this.modsName.Name = "modsName";
            this.modsName.ReadOnly = true;
            // 
            // patchExe
            // 
            this.patchExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.patchExe.Location = new System.Drawing.Point(629, 435);
            this.patchExe.Name = "patchExe";
            this.patchExe.Size = new System.Drawing.Size(174, 35);
            this.patchExe.TabIndex = 6;
            this.patchExe.Text = "Patch Exe";
            this.patchExe.UseVisualStyleBackColor = true;
            this.patchExe.Click += new System.EventHandler(this.patchExe_Click);
            // 
            // refreshModsListBtn
            // 
            this.refreshModsListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshModsListBtn.Location = new System.Drawing.Point(5, 435);
            this.refreshModsListBtn.Name = "refreshModsListBtn";
            this.refreshModsListBtn.Size = new System.Drawing.Size(174, 35);
            this.refreshModsListBtn.TabIndex = 3;
            this.refreshModsListBtn.Text = "Refresh Mods List";
            this.refreshModsListBtn.UseVisualStyleBackColor = true;
            this.refreshModsListBtn.Click += new System.EventHandler(this.refreshModsList_Click);
            // 
            // disableEasyAntiCheatBtn
            // 
            this.disableEasyAntiCheatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disableEasyAntiCheatBtn.Location = new System.Drawing.Point(449, 435);
            this.disableEasyAntiCheatBtn.Name = "disableEasyAntiCheatBtn";
            this.disableEasyAntiCheatBtn.Size = new System.Drawing.Size(174, 35);
            this.disableEasyAntiCheatBtn.TabIndex = 7;
            this.disableEasyAntiCheatBtn.Text = "Disable EasyAntiCheat";
            this.disableEasyAntiCheatBtn.UseVisualStyleBackColor = true;
            this.disableEasyAntiCheatBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openModsFolderBtn
            // 
            this.openModsFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openModsFolderBtn.Location = new System.Drawing.Point(185, 435);
            this.openModsFolderBtn.Name = "openModsFolderBtn";
            this.openModsFolderBtn.Size = new System.Drawing.Size(174, 35);
            this.openModsFolderBtn.TabIndex = 2;
            this.openModsFolderBtn.Text = "Open Mods Folder";
            this.openModsFolderBtn.UseVisualStyleBackColor = true;
            this.openModsFolderBtn.Click += new System.EventHandler(this.openModsFolderBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.driveList);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // driveList
            // 
            this.driveList.FormattingEnabled = true;
            this.driveList.Location = new System.Drawing.Point(70, 13);
            this.driveList.Name = "driveList";
            this.driveList.Size = new System.Drawing.Size(121, 24);
            this.driveList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drive:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "(change this if the game is installed on a drive besides C:\\)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(753, 524);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBFZ Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modsList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button patchExe;
        private System.Windows.Forms.Button refreshModsListBtn;
        private System.Windows.Forms.Button disableEasyAntiCheatBtn;
        private System.Windows.Forms.Button openModsFolderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modActive;
        private System.Windows.Forms.DataGridView modsList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn modsName;
        private System.Windows.Forms.ComboBox driveList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

