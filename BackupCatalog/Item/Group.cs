using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BinaryObjectFormat;

namespace BackupCatalog {
    public class Group : Item {
        public ObservableCollection<Item> Items { get; private set; }

        public Group() : base(ItemID.Group) {
            Items = new ObservableCollection<Item>();
            Items.CollectionChanged += CallCollectionContentsChanged;

            Deleted += OnDeletion;
        }

        private bool _updateEventSuspended = false;

        private void CallItemContentsChanged(object sender, EventArgs e) {
            CallContentChanged();
        }
        private void CallCollectionContentsChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if (_updateEventSuspended) return;

            if (e.Action != NotifyCollectionChangedAction.Move) {
                if (e.OldItems != null) {
                    e.OldItems.ForEach<Item>(x => {
                        x.ContentChanged -= CallItemContentsChanged;
                        x.Parent = null;

                        x.CallDeleted();
                    });
                }
                if (e.NewItems != null) {
                    e.NewItems.ForEach<Item>(x => {
                        x.ContentChanged += CallItemContentsChanged;
                        x.Parent = this;
                    });
                }
            }

            CallContentChanged();
        }

        private void OnDeletion(object sender, EventArgs e) {
            foreach (var item in Items) {
                item.CallDeleted();
            }
        }

        public void Move(IEnumerable<Item> children, Group group) {
            foreach (var child in children) {
                Items.Remove(child);

                child.Parent = group;
                group.Items.Add(child);
            }
        }
        public void SwapChildItems(Item child, Item otherChild) {
            Items.Move(Items.IndexOf(child), Items.IndexOf(otherChild));
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();

            ObjectTag[] items = new ObjectTag[Items.Count];
            for (int i = 0; i < Items.Count; i++) {
                items[i] = Items[i].Serialize();
            }

            output.Add("Items", items);

            return output;
        }
        public static Group Deserialize(ObjectTag obj) {
            Group output = new Group();
            Deserialize(obj, output);

            Tag[] tags = ((ArrayTag)obj["Items"]).As<Tag>();

            for (int i = 0; i < tags.Length; i++) {
                ObjectTag tag = tags[i] as ObjectTag;

                Item item;
                switch ((ItemID)(byte)tag["ID"]) {
                    case ItemID.Group:
                        item = Deserialize(tag);
                        break;
                    case ItemID.Folder:
                        item = FolderItem.Deserialize(tag);
                        break;
                    case ItemID.ItemBundle:
                    default:
                        item = ItemBundle.Deserialize(tag);
                        break;
                }

                output.Items.Add(item);
            }

            return output;
        }

        public override Item Clone() {
            Group item = new Group();
            base.Copy(item);

            foreach (Item thisItem in Items) {
                item.Items.Add(thisItem.Clone() as Item);
            }

            return item;
        }
    }
}
