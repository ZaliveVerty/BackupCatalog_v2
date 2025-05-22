
namespace BackupCatalogGUI {
    partial class ItemBundleEditor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBundleEditor));
            this.DoneButton = new CustomDialogs.DarkButton();
            this.FolderGridView = new CustomDialogs.DarkDataGridView();
            this.FolderCol = new CustomDialogs.TextAndImageColumn();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.FileGridView = new CustomDialogs.DarkDataGridView();
            this.FileCol = new CustomDialogs.TextAndImageColumn();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddFolderButton = new CustomDialogs.DarkButton();
            this.AddFileButton = new CustomDialogs.DarkButton();
            this.FolderZoomButton = new System.Windows.Forms.Button();
            this.FileZoomButton = new System.Windows.Forms.Button();
            this.RemoveFolderLink = new System.Windows.Forms.LinkLabel();
            this.RemoveFileLink = new System.Windows.Forms.LinkLabel();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(13, 272);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 25);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // FolderGridView
            // 
            this.FolderGridView.AllowUserToAddRows = false;
            this.FolderGridView.AllowUserToDeleteRows = false;
            this.FolderGridView.AllowUserToOrderColumns = true;
            this.FolderGridView.AllowUserToResizeRows = false;
            this.FolderGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FolderGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FolderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FolderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FolderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FolderGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FolderGridView.EnableHeadersVisualStyles = false;
            this.FolderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.Location = new System.Drawing.Point(12, 12);
            this.FolderGridView.Name = "FolderGridView";
            this.FolderGridView.ReadOnly = true;
            this.FolderGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FolderGridView.RowTemplate.Height = 25;
            this.FolderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FolderGridView.Size = new System.Drawing.Size(289, 150);
            this.FolderGridView.TabIndex = 1;
            // 
            // FolderCol
            // 
            this.FolderCol.AlignmentToRight = false;
            this.FolderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FolderCol.HeaderText = "Folders";
            this.FolderCol.Image = null;
            this.FolderCol.Name = "FolderCol";
            this.FolderCol.ReadOnly = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(13, 225);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(285, 25);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // FileGridView
            // 
            this.FileGridView.AllowUserToAddRows = false;
            this.FileGridView.AllowUserToDeleteRows = false;
            this.FileGridView.AllowUserToOrderColumns = true;
            this.FileGridView.AllowUserToResizeRows = false;
            this.FileGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.FileGridView.EnableHeadersVisualStyles = false;
            this.FileGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.Location = new System.Drawing.Point(310, 12);
            this.FileGridView.Name = "FileGridView";
            this.FileGridView.ReadOnly = true;
            this.FileGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.FileGridView.RowTemplate.Height = 25;
            this.FileGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileGridView.Size = new System.Drawing.Size(289, 150);
            this.FileGridView.TabIndex = 3;
            // 
            // FileCol
            // 
            this.FileCol.AlignmentToRight = false;
            this.FileCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileCol.HeaderText = "Files";
            this.FileCol.Image = null;
            this.FileCol.Name = "FileCol";
            this.FileCol.ReadOnly = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(103, 272);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(9, 208);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFolderButton.Location = new System.Drawing.Point(13, 167);
            this.AddFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(87, 25);
            this.AddFolderButton.TabIndex = 6;
            this.AddFolderButton.Text = "Add folders";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFileButton.Location = new System.Drawing.Point(311, 167);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(87, 25);
            this.AddFileButton.TabIndex = 7;
            this.AddFileButton.Text = "Add files";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // FolderZoomButton
            // 
            this.FolderZoomButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FolderZoomButton.BackgroundImage = global::BackupCatalogGUI.Properties.Resources._16pxZoom;
            this.FolderZoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FolderZoomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FolderZoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderZoomButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FolderZoomButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderZoomButton.Location = new System.Drawing.Point(106, 170);
            this.FolderZoomButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.FolderZoomButton.Name = "FolderZoomButton";
            this.FolderZoomButton.Size = new System.Drawing.Size(23, 23);
            this.FolderZoomButton.TabIndex = 15;
            this.FolderZoomButton.UseVisualStyleBackColor = false;
            this.FolderZoomButton.Click += new System.EventHandler(this.FolderZoomButton_Click);
            // 
            // FileZoomButton
            // 
            this.FileZoomButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FileZoomButton.BackgroundImage = global::BackupCatalogGUI.Properties.Resources._16pxZoom;
            this.FileZoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FileZoomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileZoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileZoomButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileZoomButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileZoomButton.Location = new System.Drawing.Point(404, 170);
            this.FileZoomButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.FileZoomButton.Name = "FileZoomButton";
            this.FileZoomButton.Size = new System.Drawing.Size(23, 23);
            this.FileZoomButton.TabIndex = 16;
            this.FileZoomButton.UseVisualStyleBackColor = false;
            this.FileZoomButton.Click += new System.EventHandler(this.FileZoomButton_Click);
            // 
            // RemoveFolderLink
            // 
            this.RemoveFolderLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.RemoveFolderLink.AutoSize = true;
            this.RemoveFolderLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFolderLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFolderLink.Location = new System.Drawing.Point(248, 165);
            this.RemoveFolderLink.Name = "RemoveFolderLink";
            this.RemoveFolderLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveFolderLink.TabIndex = 17;
            this.RemoveFolderLink.TabStop = true;
            this.RemoveFolderLink.Text = "Remove";
            this.RemoveFolderLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFolderLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFolderLink_LinkClicked);
            // 
            // RemoveFileLink
            // 
            this.RemoveFileLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.RemoveFileLink.AutoSize = true;
            this.RemoveFileLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFileLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFileLink.Location = new System.Drawing.Point(546, 165);
            this.RemoveFileLink.Name = "RemoveFileLink";
            this.RemoveFileLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveFileLink.TabIndex = 18;
            this.RemoveFileLink.TabStop = true;
            this.RemoveFileLink.Text = "Remove";
            this.RemoveFileLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFileLink_LinkClicked);
            // 
            // ItemBundleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(611, 312);
            this.Controls.Add(this.RemoveFileLink);
            this.Controls.Add(this.RemoveFolderLink);
            this.Controls.Add(this.FileZoomButton);
            this.Controls.Add(this.FolderZoomButton);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FileGridView);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FolderGridView);
            this.Controls.Add(this.DoneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemBundleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item bundle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemBundleEditor_FormClosing);
            this.Load += new System.EventHandler(this.ItemBundleEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkButton DoneButton;
        private CustomDialogs.DarkDataGridView FolderGridView;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.TextAndImageColumn FolderCol;
        private CustomDialogs.DarkDataGridView FileGridView;
        private CustomDialogs.TextAndImageColumn FileCol;
        private CustomDialogs.DarkButton CancelButton;
        private System.Windows.Forms.Label NameLabel;
        private CustomDialogs.DarkButton AddFolderButton;
        private CustomDialogs.DarkButton AddFileButton;
        private System.Windows.Forms.Button FolderZoomButton;
        private System.Windows.Forms.Button FileZoomButton;
        private System.Windows.Forms.LinkLabel RemoveFolderLink;
        private System.Windows.Forms.LinkLabel RemoveFileLink;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}