namespace SteamMetadata
{
    partial class GUI
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
            this.searchTbx = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.dwnBtn = new System.Windows.Forms.Button();
            this.pathTbx = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // searchTbx
            // 
            this.searchTbx.Location = new System.Drawing.Point(13, 13);
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.Size = new System.Drawing.Size(433, 20);
            this.searchTbx.TabIndex = 0;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(452, 11);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            // 
            // dwnBtn
            // 
            this.dwnBtn.Location = new System.Drawing.Point(13, 395);
            this.dwnBtn.Name = "dwnBtn";
            this.dwnBtn.Size = new System.Drawing.Size(514, 43);
            this.dwnBtn.TabIndex = 2;
            this.dwnBtn.Text = "Download";
            this.dwnBtn.UseVisualStyleBackColor = true;
            // 
            // pathTbx
            // 
            this.pathTbx.Location = new System.Drawing.Point(13, 369);
            this.pathTbx.Name = "pathTbx";
            this.pathTbx.ReadOnly = true;
            this.pathTbx.Size = new System.Drawing.Size(454, 20);
            this.pathTbx.TabIndex = 3;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(473, 369);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(54, 21);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTbx);
            this.Controls.Add(this.dwnBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.searchTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Steam Metadata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTbx;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button dwnBtn;
        private System.Windows.Forms.TextBox pathTbx;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
    }
}

