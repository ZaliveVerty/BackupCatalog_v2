using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public partial class ItemExplorer : Form {
        public BackupApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        public IView CurrentView => ViewControl.ViewController.CurrentView;
        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public ItemExplorer(BackupApplication application, GuiApplication guiApplication) {
            InitializeComponent();

            Application = application;
            GuiApplication = guiApplication;

            ViewController viewController = new ViewController(new GroupViewNode(Application.RootResource.Group));
            GridControl = new ItemExplorerGridControl(viewController) { 
                Application = Application
            };

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            GridView.ContextMenuStrip = MenuStrip;

            ViewControl.Updated += View_Update;
        }

        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private void View_Update(object sender, EventArgs e) {
            AmountOfItemsLabel.Text = $"Items: {CurrentView.ViewNode.Items.Count}";
        }

        //Bottom buttons
        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex < 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapChildItems(item, GridView.Rows[rowIndex - 1].Tag as Item);
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex >= GridView.Rows.Count - 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapChildItems(item, GridView.Rows[rowIndex + 1].Tag as Item);
        }

        private void UpdateSchemesButton_Click(object sender, EventArgs e) {
            UpdateSchemesViewer viewer = new UpdateSchemesViewer(Application, GuiApplication);
            viewer.ShowDialog();
        }

        private void DeselectButton_Click(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            UpdateMenuItem.Enabled = GridView.SelectedRows.Count > 0;

            SetDestinationFolderMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count == 1;

            CopyMenuItem.Enabled = item != null;
            PasteMenuItem.Enabled = GuiApplication.CopiedItems?.Any() ?? false;

            MoveMenuItem.Enabled = item != null && CurrentView.SelectedItems.Any();
            EditMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count == 1;
            DeleteMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;

            ViewUpdateHistoryMenuItem.Enabled = item?.IsUpdateable() ?? false;

            if (item != null) {
                EditMenuItem.Text = item.ID == ItemID.Group ? "Rename" : "Edit";
                EditMenuItem.Image = item.ID == ItemID.Group ? Properties.Resources._64pxRename : Properties.Resources._16pxEdit;
            }
        }

        private void NewGroupMenuitem_Click(object sender, EventArgs e) {
            Group group = new Group() {
                DisplayName = "New group"
            };

            CurrentGroup.Items.Add(group);
            GridControl.SelectRow(group);

            ItemUtilities.EditGroup(group);
        }
        private void NewFolderMenuItem_Click(object sender, EventArgs e) {
            FolderItem folder = new FolderItem("") {
                DisplayName = "New folder"
            };

            CurrentGroup.Items.Add(folder);
            GridControl.SelectRow(folder);

            ItemUtilities.EditFolder(folder, Application);
        }
        private void NewItemBundleMenuItem_Click(object sender, EventArgs e) {
            ItemBundle itemBundle = new ItemBundle() {
                DisplayName = "New item bundle"
            };

            CurrentGroup.Items.Add(itemBundle);
            GridControl.SelectRow(itemBundle);

            ItemUtilities.EditItemBundle(itemBundle, Application);
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e) {
            if (ItemUtilities.UpdateItems(CurrentView.SelectedItems.Cast<Item>().ToList())) {
                Application.RootResource.Save();
                ViewControl.UpdateView();
            }
        }

        private void SetDestinationFolderMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.SetDestinationFolder(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e) {
            GuiApplication.CopiedItems = new List<Item>(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void PasteMenuItem_Click(object sender, EventArgs e) {
            Group parent = CurrentGroup;

            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;
            if (item != null && item.ID == ItemID.Group) parent = item as Group;

            ItemUtilities.Paste(GuiApplication.CopiedItems, parent);
        }

        private void MoveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Move(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }
        private void EditMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item, Application);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Delete(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }

        private void ViewUpdateHistoryMenuItem_Click(object sender, EventArgs e) {
            CustomDialog.ShowDateListViewer((GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem).UpdateHistory, Properties.Resources._64pxCalendar, "Update history", "Update date");
        }
    }
}
