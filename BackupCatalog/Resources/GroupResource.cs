using System;
using BinaryObjectFormat;
using CommonUtilities;

namespace BackupCatalog {
    public class GroupResource : Serializeable {
        public Group Group { get; set; }
        public override string ResourceName { get; set; } = "items";

        public GroupResource(IFileCacheController controller) : base(controller) { }

        public override ObjectTag Serialize() {
            return Group.Serialize();
        }

        public override void SetDefaultState() {
            Group = new Group() { 
                DisplayName = "Root"
            };
        }
        public override void SetState(ObjectTag obj) {
            Group = Group.Deserialize(obj);
        }
    }
}
