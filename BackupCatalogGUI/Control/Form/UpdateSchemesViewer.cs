using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public partial class UpdateSchemesViewer : Form {
        public BackupApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        private IList<object> _selectedItems = new List<object>();

        public UpdateSchemesViewer(BackupApplication cloudApplication, GuiApplication guiApplication) {
            InitializeComponent();

            Application = cloudApplication;
            GuiApplication = guiApplication;
        }

        private void UpdateSchemesViewer_Load(object sender, EventArgs e) {
            LoadDialog();
            GridView.ClearSelection();
        }

        //Load
        private bool _inUpdate = false;
        private void LoadDialog() {
            _inUpdate = true;

            GridView.Rows.Clear();

            for (int i = 0; i < GuiApplication.UpdateSchemes.UpdateSchemes.Count; i++) {
                UpdateScheme scheme = GuiApplication.UpdateSchemes.UpdateSchemes[i];

                GridView.Rows.Add(scheme.Name, scheme.UpdateableItems.Count);

                var row = GridView.Rows[i];
                row.Tag = scheme;
                row.Selected = _selectedItems.Contains(scheme);

                row.DisplayImage(NameCol, Properties.Resources._16pxUpload, 29);
            }

            SetButtonAvailability();

            _inUpdate = false;
        }

        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            SetButtonAvailability();

            _selectedItems.Clear();
            foreach (DataGridViewRow row in GridView.SelectedRows) {
                _selectedItems.Add(row.Tag);
            }
        }
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            OpenScheme(GridView.Rows[e.RowIndex].Tag as UpdateScheme);
            LoadDialog();
        }

        private void SetButtonAvailability() {
            RenameButton.Enabled = GridView.SelectedRows.Count == 1;
            RemoveButton.Enabled = GridView.SelectedRows.Count > 0;
        }

        private void SelectRow(UpdateScheme scheme) {
            foreach (DataGridViewRow row in GridView.Rows) {
                if (row.Tag == scheme) {
                    row.Selected = true;
                    return;
                }
            }
        }

        //Buttons
        private void UpdateButton_Click(object sender, EventArgs e) {
            UpdateSeelctedItems();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            CreateNewScheme();
        }
        private void RenameButton_Click(object sender, EventArgs e) {
            UpdateScheme scheme = GridView.SelectedRows[0].Tag as UpdateScheme;
            RenameScheme(scheme);

            LoadDialog();
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            List<UpdateScheme> schemes = new List<UpdateScheme>(GridView.SelectedRows.Count);

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                schemes.Add(row.Tag as UpdateScheme);
            }

            RemoveSchemes(schemes);
            LoadDialog();
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex < 1) return;

            UpdateScheme item = GridView.SelectedRows[0].Tag as UpdateScheme;
            GuiApplication.UpdateSchemes.SwapChildItems(item, GridView.Rows[rowIndex - 1].Tag as UpdateScheme);

            GuiApplication.UpdateSchemes.Save();
            LoadDialog();
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex >= GridView.Rows.Count - 1) return;

            UpdateScheme item = GridView.SelectedRows[0].Tag as UpdateScheme;
            GuiApplication.UpdateSchemes.SwapChildItems(item, GridView.Rows[rowIndex + 1].Tag as UpdateScheme);

            GuiApplication.UpdateSchemes.Save();
            LoadDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            UpdateMenuItem.Enabled = GridView.SelectedRows.Count > 0;
            RenameMenuItem.Enabled = GridView.SelectedRows.Count == 1;
            RemoveMenuItem.Enabled = GridView.SelectedRows.Count > 0;
        }

        private void NewMenuItem_Click(object sender, EventArgs e) {
            CreateNewScheme();
        }
        private void UpdateMenuItem_Click(object sender, EventArgs e) {
            UpdateSeelctedItems();
        }

        private void RenameMenuItem_Click(object sender, EventArgs e) {
            UpdateScheme scheme = GridView.SelectedRows[0].Tag as UpdateScheme;
            RenameScheme(scheme);

            LoadDialog();
        }
        private void RemoveMenuItem_Click(object sender, EventArgs e) {
            List<UpdateScheme> schemes = new List<UpdateScheme>(GridView.SelectedRows.Count);

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                schemes.Add(row.Tag as UpdateScheme);
            }

            RemoveSchemes(schemes);
            LoadDialog();
        }

        //Functions
        private void CreateNewScheme() {
            UpdateScheme scheme = new UpdateScheme() {
                Name = "New scheme"
            };

            GuiApplication.UpdateSchemes.UpdateSchemes.Add(scheme);
            GuiApplication.UpdateSchemes.Save();

            LoadDialog();

            SelectRow(scheme);
            RenameScheme(scheme);

            LoadDialog();
        }
        private void UpdateSeelctedItems() {
            List<Item> items = new List<Item>();

            foreach (DataGridViewRow row in GridView.SelectedRows) {
                UpdateScheme scheme = row.Tag as UpdateScheme;
                items.AddRange(scheme.UpdateableItems.Cast<Item>());
            }

            ItemUtilities.UpdateItems(items);
            Application.RootResource.Save();
        }

        private void RenameScheme(UpdateScheme scheme) {
            InputResult<string> result = CustomDialog.ShowTextInput("Scheme's name", "Edit the scheme's name.",
                scheme.Name, Properties.Resources._64pxRename);
            if (result.DialogClosed) return;

            if (string.IsNullOrEmpty(result.Value)) {
                CustomDialog.ShowError("Error", "Group's name cannot be empty.");
            } else {
                scheme.Name = result.Value;
                GuiApplication.UpdateSchemes.Save();
            }
        }
        private void RemoveSchemes(IEnumerable<UpdateScheme> schemes) {
            if (CustomDialog.ShowDeletionConfirmation("Remove")) {
                foreach (UpdateScheme scheme in schemes) {
                    GuiApplication.UpdateSchemes.Remove(scheme);
                }

                GuiApplication.UpdateSchemes.Save();
            }
        }

        private void OpenScheme(UpdateScheme scheme) {
            UpdateableItemCollectionEditor editor = new UpdateableItemCollectionEditor(scheme.UpdateableItems, Application.RootResource.Group);
            editor.ShowDialog();

            if (editor.DialogClosed) return;

            scheme.Reset(editor.UpdateableItems);
            GuiApplication.UpdateSchemes.Save();
        }
    }
}
