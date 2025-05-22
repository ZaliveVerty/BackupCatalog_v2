using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CustomDialogs;
using BackupCatalog;

namespace BackupCatalogGUI {
    public partial class ItemBundleEditor : Form {
        public BackupApplication Application { get; set; }
        public ItemBundle ItemBundle { get; set; }

        private HashSet<string> _folders;
        private HashSet<string> _files;

        private Func<string, Image> _getFolderIconFunction;
        private Func<string, Image> _getFileIconFunction;

        public ItemBundleEditor(ItemBundle itemBundle, BackupApplication application) {
            InitializeComponent();

            Application = application;
            ItemBundle = itemBundle;

            _folders = new HashSet<string>(ItemBundle.Folders);
            _files = new HashSet<string>(ItemBundle.Files);

            _getFolderIconFunction = (value) => {
                return Properties.Resources._22pxDirectory.Resize(20, 20);
            };
            _getFileIconFunction = (value) => {
                return Icon.ExtractAssociatedIcon(value).ToBitmap().Resize(20, 20);
            };

            LoadEditor();
        }

        private void ItemBundleEditor_Load(object sender, EventArgs e) {
            FolderGridView.ClearSelection();
            FileGridView.ClearSelection();
        }

        private void LoadEditor() {
            NameTextBox.Text = ItemBundle.DisplayName;

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }
        private void LoadGridView(DataGridView gridView, IEnumerable<string> items, Func<string, Image> getIconFunction) {
            gridView.Rows.Clear();

            foreach (var item in items) {
                gridView.Rows.Add(item);
                gridView.Rows[gridView.Rows.Count - 1].DisplayImage(gridView.Columns[0], getIconFunction(item), 25);
            }

            gridView.ClearSelection();
        }

        private void AddFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return;

            _folders.Add(FolderBrowserDialog.SelectedPath);
            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void AddFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileNames.Length < 1) return;

            foreach (var file in OpenFileDialog.FileNames) {
                if (File.Exists(file)) _files.Add(file);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void FolderZoomButton_Click(object sender, EventArgs e) {
            Icon icon = ImageToIconConverter.Convert(Properties.Resources._22pxDirectory, 22, 22);

            Func<IEnumerable<string>> addFunction = () => {
                FolderBrowserDialog.ShowDialog();
                if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return new string[0];

                return new string[] { FolderBrowserDialog.SelectedPath };
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_folders, "Folders", addFunction, _getFolderIconFunction, icon);
            if (results.DialogClosed) return;

            _folders = new HashSet<string>(results.Value);

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void FileZoomButton_Click(object sender, EventArgs e) {
            Func<IEnumerable<string>> addFunction = () => {
                OpenFileDialog.ShowDialog();

                List<string> fileNames = new List<string>(OpenFileDialog.FileNames.Length);
                foreach (var file in OpenFileDialog.FileNames) {
                    if (File.Exists(file)) fileNames.Add(file);
                }

                return fileNames;
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_files, "Files", addFunction, _getFileIconFunction, Properties.Resources._64pxDocumentIcon);
            if (results.DialogClosed) return;

            _files = new HashSet<string>(results.Value);

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void RemoveFolderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow folder in FolderGridView.SelectedRows) {
                _folders.Remove((string)folder.Cells[0].Value);
            }

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void RemoveFileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow file in FileGridView.SelectedRows) {
                _files.Remove((string)file.Cells[0].Value);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveContents();

            _close = true;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private bool _close = false;

        private void ItemBundleEditor_FormClosing(object sender, FormClosingEventArgs e) {
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

        private bool ContentsChanged() {
            if (NameTextBox.Text != ItemBundle.DisplayName) return true;

            if (!_folders.SetEquals(new HashSet<string>(ItemBundle.Folders))) return true;
            return !_files.SetEquals(new HashSet<string>(ItemBundle.Files));
        }
        private void SaveContents() {
            ItemBundle.ApplyChangeMode();

            ItemBundle.DisplayName = NameTextBox.Text;

            ItemBundle.Folders.Clear();
            foreach (var folder in _folders) {
                ItemBundle.Folders.Add(folder);
            }

            ItemBundle.Files.Clear();
            foreach (var file in _files) {
                ItemBundle.Files.Add(file);
            }

            ItemBundle.SuspendChangeMode();
        }

        private bool ValidateContent() {
            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                CustomDialog.ShowError("Error", "Item bundle's name cannot be empty.");
                return false;
            }

            return true;
        }
    }
}
