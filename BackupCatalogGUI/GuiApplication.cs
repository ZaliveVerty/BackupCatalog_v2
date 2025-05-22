using System;
using System.Collections.Generic;
using BackupCatalog;
using CommonUtilities;

namespace BackupCatalogGUI {
    public class GuiApplication {
        public UpdateSchemesResource UpdateSchemes { get; set; }
        public IList<Item> CopiedItems { get; set; }

        public GuiApplication(IFileCacheController controller, Group root) {
            UpdateSchemes = new UpdateSchemesResource(controller, root);
            UpdateSchemes.Load();

            UpdateSchemes.ItemDelete += (sender, e) => UpdateSchemes.Save();
        }
    }
}
