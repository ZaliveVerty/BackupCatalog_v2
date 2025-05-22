using System;
using BinaryObjectFormat;

namespace BackupCatalog {
    public class FolderItem : UpdateableItem {
        public string Folder {
            get => _folder;
            set {
                if (value == null) return;

                _folder = value;
                CallContentChanged();
            }
        }
        private string _folder = "";

        public FolderItem(string folder) : base(ItemID.Folder) {
            Folder = folder;
        }

        public override string[][] ProvideItems() {
            return new string[][] { new string[] { Folder }, new string[0] };
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();
            output.Add("Folder", Folder);

            return output;
        }
        public static FolderItem Deserialize(ObjectTag obj) {
            FolderItem output = new FolderItem(obj["Folder"]);
            Deserialize(obj, output);

            return output;
        }

        public override Item Clone() {
            FolderItem item = new FolderItem(Folder);
            Copy(item);

            return item;
        }
    }
}
