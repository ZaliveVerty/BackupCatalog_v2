
namespace BackupCatalogGUI {
    partial class ProgressView {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressView));
            this.ProgressPanel = new CustomDialogs.ProgressPanel();
            this.UploadingTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressPanel.Location = new System.Drawing.Point(9, 13);
            this.ProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.OriginalActivityTypeText = "";
            this.ProgressPanel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(181)))), ((int)(((byte)(85)))));
            this.ProgressPanel.Size = new System.Drawing.Size(383, 59);
            this.ProgressPanel.TabIndex = 0;
            // 
            // UploadingTitleTimer
            // 
            this.UploadingTitleTimer.Tick += new System.EventHandler(this.UploadingTitleTimer_Tick);
            // 
            // ProgressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(401, 81);
            this.Controls.Add(this.ProgressPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressView";
            this.Padding = new System.Windows.Forms.Padding(9, 13, 9, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.ProgressPanel ProgressPanel;
        private System.Windows.Forms.Timer UploadingTitleTimer;
    }
}