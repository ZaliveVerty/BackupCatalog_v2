using System;
using System.Drawing;
using System.Windows.Forms;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public class DataGridViewVisualController {
        public ViewController ViewController { get; set; }
        private DataGridViewColumn[] _columns;

        public DataGridViewVisualController(ViewController viewController) {
            ViewController = viewController;
        }

        public DataGridViewColumn[] CreateColumns() {
            _columns = new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 190
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Original path",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Destination folder",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Last Updated",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0, 0, 5, 0)
                    },
                    MinimumWidth = 100
                }
            };

            return _columns;
        }

        //Update
        private ImageCache _imageCache = new ImageCache() { 
            InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
        };

        public bool SetRow(DataGridViewRow row, object item) {
            if (((Item)item).ID == ItemID.Group) SetGroupRow(row, item as Group);
            else SetUpdateableItemRow(row, item as UpdateableItem);

            return true;
        }

        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.SetValues(group.DisplayName);
            row.DisplayImage(_columns[0], _imageCache.GetImage(group.GetImageChacheKey(), group.GetIcon(), 22, 22), 27);
        }
        private void SetUpdateableItemRow(DataGridViewRow row, UpdateableItem item) {
            row.SetValues(item.DisplayName, item is FolderItem f ? f.Folder : "", item.DestinationFolder, item.GetLastUpdatedString());
            row.DisplayImage(_columns[0], _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 22, 22), 27);
        }
    }
}
