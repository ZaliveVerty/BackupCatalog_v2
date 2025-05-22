using System;
using System.Windows.Forms;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public class ItemExplorerGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }
        public DataGridViewVisualController GridViewController { get; set; }

        public BackupApplication Application { get; set; }

        public ItemExplorerGridControl(ViewController viewController) {
            ViewController = viewController;
            GridViewController = new DataGridViewVisualController(ViewController);

            Initialize();
        }

        public override DataGridViewColumn[] CreateColumns() {
            return GridViewController.CreateColumns();
        }
        protected override bool SetRow(DataGridViewRow row, object item) {
            return GridViewController.SetRow(row, item);
        }
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            } else if (id == ItemID.ItemBundle) {
                ItemUtilities.EditItemBundle(item as ItemBundle, Application);
            } else {
                ItemUtilities.EditFolder(item as FolderItem, Application);
            }
        }
    }
}
