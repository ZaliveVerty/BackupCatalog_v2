using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BinaryObjectFormat;

namespace BackupCatalog {
    public class ItemBundle : UpdateableItem {
        public ObservableCollection<string> Folders { get; private set; }
        public ObservableCollection<string> Files { get; private set; }

        public ItemBundle() : base(ItemID.ItemBundle) {
            Folders = new ObservableCollection<string>();
            Files = new ObservableCollection<string>();
        }
        public ItemBundle(IEnumerable<string> folders, IEnumerable<string> files) : base(ItemID.ItemBundle) {
            Folders = new ObservableCollection<string>(folders);
            Files = new ObservableCollection<string>(files);

            Folders.CollectionChanged += CallContentsChanged;
            Files.CollectionChanged += CallContentsChanged;
        }

        private void CallContentsChanged(object sender, EventArgs e) {
            CallContentChanged();
        }

        public override string[][] ProvideItems() {
            return new string[][] { Folders.ToArray(), Files.ToArray() };
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();

            output.Add("Folders", Folders.ToArray());
            output.Add("Files", Files.ToArray());

            return output;
        }
        public static ItemBundle Deserialize(ObjectTag obj) {
            ItemBundle output = new ItemBundle();
            Deserialize(obj, output);

            output.Folders = new ObservableCollection<string>(((ArrayTag)obj["Folders"]).As<string>());
            output.Files = new ObservableCollection<string>(((ArrayTag)obj["Files"]).As<string>());

            output.Folders.CollectionChanged += output.CallContentsChanged;
            output.Files.CollectionChanged += output.CallContentsChanged;

            return output;
        }

        public override Item Clone() {
            ItemBundle output = new ItemBundle(Folders, Files);
            Copy(output);

            return output;
        }
    }
}
