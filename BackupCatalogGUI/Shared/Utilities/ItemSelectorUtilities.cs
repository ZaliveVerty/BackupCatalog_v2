using System;
using System.Collections.Generic;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    public static class ItemSelectorUtilities {
        public static InputResult<IList<object>> ShowSelector(Group group, ItemSelectorProfile profile, Func<object, bool> viewableItemValidator) {
            using (ViewController viewController = new ViewController(new GroupViewNode(group))) {
                ItemSelectionGridControl gridViewControl = new ItemSelectionGridControl(viewableItemValidator) {
                    ViewController = viewController
                };

                return CustomDialog.ShowItemSelector(viewController, gridViewControl, profile);
            }
        }
    }
}
