using System;
using System.Collections.Generic;
using System.Linq;
using BackupCatalog;
using BinaryObjectFormat;
using CommonUtilities;

namespace BackupCatalogGUI {
    public class UpdateSchemesResource : Serializeable {
        public IList<UpdateScheme> UpdateSchemes { get; set; }
        public override string ResourceName { get; set; } = "UpdateSchemes";

        public Group Root { get; set; }

        public event EventHandler ItemDelete;

        public UpdateSchemesResource(IFileCacheController controller, Group root) : base(controller) {
            Root = root;
        }

        private void OnItemDelete(object sender, EventArgs e) {
            if (ItemDelete != null) ItemDelete(sender, e);
        }

        public void Remove(UpdateScheme scheme) {
            UpdateSchemes.Remove(scheme);
            scheme.ItemDelete -= ItemDelete;
        }
        public void SwapChildItems(UpdateScheme child, UpdateScheme otherChild) {
            int index = UpdateSchemes.IndexOf(child);
            int otherIndex = UpdateSchemes.IndexOf(otherChild);

            UpdateSchemes[index] = otherChild;
            UpdateSchemes[otherIndex] = child;
        }

        public override ObjectTag Serialize() {
            return new ObjectTag() {
                { "UpdateSchemes", UpdateSchemes.Select(x => x.Serialize()).ToArray() }
            };
        }

        public override void SetDefaultState() {
            UpdateSchemes = new List<UpdateScheme>();
        }
        public override void SetState(ObjectTag obj) {
            List<UpdateableItem> items = new List<UpdateableItem>();
            Root.Items.GetUpdateableItems(items);
            IDictionary<string, UpdateableItem> itemDictionary = items.ToDictionary(x => x.UniqueID);

            UpdateSchemes = ((ObjectTag[])obj["UpdateSchemes"]).Select(x => {
                UpdateScheme scheme = UpdateScheme.Deserialize(x, itemDictionary);
                scheme.ItemDelete += OnItemDelete;

                return scheme;
            }).ToList();
        }
    }
}
