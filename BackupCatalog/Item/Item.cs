using System;
using BinaryObjectFormat;

namespace BackupCatalog {
    public abstract class Item : ICloneable {
        public ItemID ID { get; private set; }
        public Group Parent { get; internal set; }

        public string DisplayName {
            get => _displayName;
            set {
                if (value == null) return;

                _displayName = value;
                CallContentChanged();
            }
        }
        private string _displayName = "";

        public event EventHandler ContentChanged;
        public event EventHandler Deleted;

        private bool _changeMode = false;
        private bool _updateInChangeMode = false;

        internal Item(ItemID id) {
            ID = id;
        }

        internal void CallContentChanged() {
            if (_changeMode) {
                _updateInChangeMode = true;
                return;
            }

            ContentChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void CallDeleted() {
            Deleted?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyChangeMode() {
            _changeMode = true;
            _updateInChangeMode = false;
        }
        public void SuspendChangeMode() {
            _changeMode = false;

            if (_updateInChangeMode) {
                _updateInChangeMode = false;
                CallContentChanged();
            }
        }

        public virtual ObjectTag Serialize() {
            return new ObjectTag() {
                { "ID", (byte)ID },
                { "DisplayName", DisplayName }
            };
        }
        public static void Deserialize(ObjectTag obj, Item output) {
            output.ID = (ItemID)(byte)obj["ID"];
            output.DisplayName = obj["DisplayName"];
        }

        public abstract object Clone();
        protected virtual void Copy(Item output) {
            output.DisplayName = DisplayName;
        }
    }
}
