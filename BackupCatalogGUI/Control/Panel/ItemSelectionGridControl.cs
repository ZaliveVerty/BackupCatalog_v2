using System;
using System.Windows.Forms;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public class ItemSelectionGridControl : IDataGridViewSelectionControl {
        public DataGridView DataGridView { get; set; }
        public ViewController ViewController { get; set; }
        public Func<object, bool> ViewableItemValidator { get; }

        public ItemSelectionGridControl(Func<object, bool> viewableItemValidator) {
            ViewableItemValidator = viewableItemValidator;
        }

        public DataGridViewColumn[] CreateColumns() {
            return new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                }
            };
        }

        public void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            }
        }

        //Update
        private ImageCache _imageCache = new ImageCache() { 
            InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
        };
        public void SetRow(DataGridViewRow row, object item) {
            if (((Item)item).ID == ItemID.Group) SetGroupRow(row, item as Group);
            else SetUpdateableItemRow(row, item as UpdateableItem);
        }

        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.SetValues(group.DisplayName);
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(group.GetImageChacheKey(), group.GetIcon(), 22, 22), 27);
        }
        private void SetUpdateableItemRow(DataGridViewRow row, UpdateableItem item) {
            row.SetValues(item.DisplayName);
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 22, 22), 27);
        }
    }
}
