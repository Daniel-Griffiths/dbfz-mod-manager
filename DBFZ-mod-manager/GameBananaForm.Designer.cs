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
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.modImage = new System.Windows.Forms.PictureBox();
            this.installModBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).BeginInit();
            this.SuspendLayout();
            // 
            // modDescription
            // 
            this.modDescription.BackColor = System.Drawing.Color.White;
            this.modDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modDescription.Location = new System.Drawing.Point(12, 83);
            this.modDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.Size = new System.Drawing.Size(353, 254);
            this.modDescription.TabIndex = 1;
            this.modDescription.Text = "Mod Description Here";
            // 
            // modImage
            // 
            this.modImage.BackColor = System.Drawing.Color.Black;
            this.modImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modImage.InitialImage = null;
            this.modImage.Location = new System.Drawing.Point(381, 83);
            this.modImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modImage.Name = "modImage";
            this.modImage.Size = new System.Drawing.Size(447, 254);
            this.modImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modImage.TabIndex = 2;
            this.modImage.TabStop = false;
            // 
            // installModBtn
            // 
            this.installModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installModBtn.Location = new System.Drawing.Point(12, 347);
            this.installModBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.installModBtn.Name = "installModBtn";
            this.installModBtn.Size = new System.Drawing.Size(173, 34);
            this.installModBtn.TabIndex = 9;
            this.installModBtn.Text = "Install Mod";
            this.installModBtn.UseVisualStyleBackColor = true;
            this.installModBtn.Click += new System.EventHandler(this.installModBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(192, 347);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(173, 34);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GameBananaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 392);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.installModBtn);
            this.Controls.Add(this.modImage);
            this.Controls.Add(this.modDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBananaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBFZ Mod Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBananaForm_FormClosing);
            this.Load += new System.EventHandler(this.GameBananaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.PictureBox modImage;
        private System.Windows.Forms.Button installModBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}