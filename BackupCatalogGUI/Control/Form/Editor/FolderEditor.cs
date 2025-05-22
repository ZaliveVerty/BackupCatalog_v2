using System;
using System.Windows.Forms;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public partial class FolderEditor : Form {
        public FolderItem Folder { get; set; }
        public BackupApplication Application { get; set; }

        public FolderEditor(FolderItem folder, BackupApplication application) {
            InitializeComponent();

            Folder = folder;
            Application = application;

            LoadEditor();
        }

        private void LoadEditor() {
            FolderTextBox.Text = Folder.Folder;
            DestinationFolderTextBox.Text = Folder.DestinationFolder;
            NameTextBox.Text = Folder.DisplayName;
        }

        private void BrowseFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            FolderTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void BrowseDestinationFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            DestinationFolderTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private bool ContentsChanged() {
            if (FolderTextBox.Text != Folder.Folder ||
                DestinationFolderTextBox.Text != Folder.DestinationFolder) return true;
            return NameTextBox.Text != Folder.DisplayName;
        }
        private void SaveContents() {
            Folder.ApplyChangeMode();

            Folder.Folder = FolderTextBox.Text;
            Folder.DestinationFolder = DestinationFolderTextBox.Text;
            Folder.DisplayName = NameTextBox.Text;

            Folder.SuspendChangeMode();
        }

        private bool ValidateContent() {
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                CustomDialog.ShowError("Error", "Folder's name cannot be empty.");
                return false;
            }

            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveContents();

            _close = true;
            Close();
        }

        private bool _close = false;
        private void FolderEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (_close || !ContentsChanged()) return;

            string result = CustomDialog.ShowSaveConfirmation();
            if (result == "Close" || result == "Cancel") {
                e.Cancel = true;
                return;
            }
            if (result == "Don't Save") return;

            if (!ValidateContent()) {
                e.Cancel = true;
                return;
            }

            SaveContents();
        }
    }
}
