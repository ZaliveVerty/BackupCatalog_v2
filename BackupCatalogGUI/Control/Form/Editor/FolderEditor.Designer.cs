
namespace BackupCatalogGUI {
    partial class FolderEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderEditor));
            this.FolderTextBox = new CustomDialogs.DarkTextBox();
            this.BrowseFolderButton = new CustomDialogs.DarkButton();
            this.FolderLabel = new System.Windows.Forms.Label();
            this.DestinationFolderLabel = new System.Windows.Forms.Label();
            this.BrowseDestinationFolderButton = new CustomDialogs.DarkButton();
            this.DestinationFolderTextBox = new CustomDialogs.DarkTextBox();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FolderPictureBox = new System.Windows.Forms.PictureBox();
            this.DestinationFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FolderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationFolderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderTextBox.Location = new System.Drawing.Point(120, 28);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.FolderTextBox.PasswordChar = '\0';
            this.FolderTextBox.ReadOnly = false;
            this.FolderTextBox.Size = new System.Drawing.Size(306, 25);
            this.FolderTextBox.TabIndex = 0;
            this.FolderTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderTextBox.XOffset = 0;
            this.FolderTextBox.YOffset = 0;
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseFolderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseFolderButton.Location = new System.Drawing.Point(15, 28);
            this.BrowseFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseFolderButton.TabIndex = 1;
            this.BrowseFolderButton.Text = "Browse";
            this.BrowseFolderButton.UseVisualStyleBackColor = true;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderLabel.Location = new System.Drawing.Point(11, 11);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(117, 15);
            this.FolderLabel.TabIndex = 2;
            this.FolderLabel.Text = "Browse for the folder";
            // 
            // DestinationFolderLabel
            // 
            this.DestinationFolderLabel.AutoSize = true;
            this.DestinationFolderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DestinationFolderLabel.Location = new System.Drawing.Point(11, 71);
            this.DestinationFolderLabel.Name = "DestinationFolderLabel";
            this.DestinationFolderLabel.Size = new System.Drawing.Size(179, 15);
            this.DestinationFolderLabel.TabIndex = 3;
            this.DestinationFolderLabel.Text = "Browse for the destination folder";
            // 
            // BrowseDestinationFolderButton
            // 
            this.BrowseDestinationFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseDestinationFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseDestinationFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseDestinationFolderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseDestinationFolderButton.Location = new System.Drawing.Point(15, 88);
            this.BrowseDestinationFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseDestinationFolderButton.Name = "BrowseDestinationFolderButton";
            this.BrowseDestinationFolderButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseDestinationFolderButton.TabIndex = 4;
            this.BrowseDestinationFolderButton.Text = "Browse";
            this.BrowseDestinationFolderButton.UseVisualStyleBackColor = true;
            this.BrowseDestinationFolderButton.Click += new System.EventHandler(this.BrowseDestinationFolderButton_Click);
            // 
            // DestinationFolderTextBox
            // 
            this.DestinationFolderTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DestinationFolderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DestinationFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationFolderTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DestinationFolderTextBox.Location = new System.Drawing.Point(120, 88);
            this.DestinationFolderTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DestinationFolderTextBox.Name = "DestinationFolderTextBox";
            this.DestinationFolderTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.DestinationFolderTextBox.PasswordChar = '\0';
            this.DestinationFolderTextBox.ReadOnly = false;
            this.DestinationFolderTextBox.Size = new System.Drawing.Size(306, 25);
            this.DestinationFolderTextBox.TabIndex = 5;
            this.DestinationFolderTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationFolderTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.DestinationFolderTextBox.XOffset = 0;
            this.DestinationFolderTextBox.YOffset = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(351, 143);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(120, 142);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(200, 25);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(80, 148);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // FolderPictureBox
            // 
            this.FolderPictureBox.Image = global::BackupCatalogGUI.Properties.Resources._64pxDirectory;
            this.FolderPictureBox.Location = new System.Drawing.Point(93, 28);
            this.FolderPictureBox.Name = "FolderPictureBox";
            this.FolderPictureBox.Size = new System.Drawing.Size(23, 23);
            this.FolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FolderPictureBox.TabIndex = 9;
            this.FolderPictureBox.TabStop = false;
            // 
            // DestinationFolderPictureBox
            // 
            this.DestinationFolderPictureBox.Image = global::BackupCatalogGUI.Properties.Resources._64pxDirectory;
            this.DestinationFolderPictureBox.Location = new System.Drawing.Point(93, 88);
            this.DestinationFolderPictureBox.Name = "DestinationFolderPictureBox";
            this.DestinationFolderPictureBox.Size = new System.Drawing.Size(23, 23);
            this.DestinationFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DestinationFolderPictureBox.TabIndex = 10;
            this.DestinationFolderPictureBox.TabStop = false;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::BackupCatalogGUI.Properties.Resources._64pxDirectory;
            this.IconPictureBox.Location = new System.Drawing.Point(9, 127);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 11;
            this.IconPictureBox.TabStop = false;
            // 
            // FolderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(438, 184);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.DestinationFolderPictureBox);
            this.Controls.Add(this.FolderPictureBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DestinationFolderTextBox);
            this.Controls.Add(this.BrowseDestinationFolderButton);
            this.Controls.Add(this.DestinationFolderLabel);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.BrowseFolderButton);
            this.Controls.Add(this.FolderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FolderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FolderEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FolderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationFolderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkTextBox FolderTextBox;
        private CustomDialogs.DarkButton BrowseFolderButton;
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.Label DestinationFolderLabel;
        private CustomDialogs.DarkButton BrowseDestinationFolderButton;
        private CustomDialogs.DarkTextBox DestinationFolderTextBox;
        private CustomDialogs.DarkButton SaveButton;
        private CustomDialogs.DarkTextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox FolderPictureBox;
        private System.Windows.Forms.PictureBox DestinationFolderPictureBox;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}