namespace ModManager
{
    partial class GameBananaForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBananaForm));
            this.modName = new System.Windows.Forms.Label();
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.modImage = new System.Windows.Forms.PictureBox();
            this.installModBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).BeginInit();
            this.SuspendLayout();
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modName.Location = new System.Drawing.Point(13, 7);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(131, 18);
            this.modName.TabIndex = 0;
            this.modName.Text = "Mod Name Here";
            // 
            // modDescription
            // 
            this.modDescription.BackColor = System.Drawing.Color.White;
            this.modDescription.Location = new System.Drawing.Point(16, 30);
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.Size = new System.Drawing.Size(354, 254);
            this.modDescription.TabIndex = 1;
            this.modDescription.Text = "Mod Description Here";
            // 
            // modImage
            // 
            this.modImage.BackColor = System.Drawing.Color.Black;
            this.modImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modImage.InitialImage = null;
            this.modImage.Location = new System.Drawing.Point(376, 30);
            this.modImage.Name = "modImage";
            this.modImage.Size = new System.Drawing.Size(448, 254);
            this.modImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modImage.TabIndex = 2;
            this.modImage.TabStop = false;
            // 
            // installModBtn
            // 
            this.installModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installModBtn.Location = new System.Drawing.Point(16, 292);
            this.installModBtn.Name = "installModBtn";
            this.installModBtn.Size = new System.Drawing.Size(174, 35);
            this.installModBtn.TabIndex = 9;
            this.installModBtn.Text = "Install Mod";
            this.installModBtn.UseVisualStyleBackColor = true;
            this.installModBtn.Click += new System.EventHandler(this.installModBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(196, 292);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(174, 35);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GameBananaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 337);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.installModBtn);
            this.Controls.Add(this.modImage);
            this.Controls.Add(this.modDescription);
            this.Controls.Add(this.modName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBananaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Mod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBananaForm_FormClosing);
            this.Load += new System.EventHandler(this.GameBananaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modName;
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.PictureBox modImage;
        private System.Windows.Forms.Button installModBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}