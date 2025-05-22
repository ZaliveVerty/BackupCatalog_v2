using System;
using System.Collections.Generic;
using System.Linq;
using BackupCatalog;
using BinaryObjectFormat;

namespace BackupCatalogGUI {
    public class UpdateScheme {
        public string Name { get; set; }
        public IReadOnlyCollection<UpdateableItem> UpdateableItems => _updateableItems.AsReadOnly();

        private List<UpdateableItem> _updateableItems = new List<UpdateableItem>();

        public event EventHandler ItemDelete;

        private void OnItemDelete(object sender, EventArgs e) {
            _updateableItems.Remove(sender as UpdateableItem);
            if (ItemDelete != null) ItemDelete(sender, e);
        }

        public void AddRange(IEnumerable<UpdateableItem> items) {
            _updateableItems.AddRange(items);

            foreach (var item in items) {
                item.Deleted += OnItemDelete;
            }
        }
        public void RemoveRange(IEnumerable<UpdateableItem> items) {
            foreach (var item in items) {
                _updateableItems.Remove(item);
                item.Deleted -= OnItemDelete;
            }
        }
        public void Reset(IEnumerable<UpdateableItem> items) {
            foreach (var item in _updateableItems) {
                item.Deleted -= OnItemDelete;
            }
            _updateableItems.Clear();

            AddRange(items);
        }

        public bool Update() {
            return ItemUtilities.UpdateItems(UpdateableItems.Cast<Item>().ToList());
        }

        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "Name", Name },
                { "UpdateableItemIDs", UpdateableItems.Select(x => x.UniqueID).ToArray() }
            };
        }
        public static UpdateScheme Deserialize(ObjectTag obj, IDictionary<string, UpdateableItem> items) {
            string name = obj["Name"];
            string[] ids = obj["UpdateableItemIDs"];

            UpdateScheme scheme = new UpdateScheme() {
                Name = name,
                _updateableItems = new List<UpdateableItem>(ids.Length)
            };

            foreach (string id in ids) {
                if (items.TryGetValue(id, out UpdateableItem item)) {
                    scheme._updateableItems.Add(item);

                    item.Deleted += scheme.OnItemDelete;
                }
            }

            return scheme;
        }
    }
}
