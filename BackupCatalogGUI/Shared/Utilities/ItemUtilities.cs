using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using CustomDialogs;
using BackupCatalog;

namespace BackupCatalogGUI {
    public static class ItemUtilities {
        public static bool UpdateItems(IList<Item> items) {
            if (items.Count == 1) {
                if (items[0].ID == ItemID.Group) {
                    return UpdateManyItems((items[0] as Group).Items);
                } else {
                    return UpdateUpdateableItem(items[0] as UpdateableItem);
                }
            } else {
                return UpdateManyItems(items);
            }
        }
        public static bool UpdateUpdateableItem(UpdateableItem item) {
            Progress<UpdateProgressReport> progress = new Progress<UpdateProgressReport>();

            Thread thread = new Thread(() => {
                item.Update(progress);
            });
            thread.Start();

            ProgressView progressForm = new ProgressView(progress);
            progressForm.SetText("Discovering");
            progressForm.ShowDialog();

            return true;
        }
        public static bool UpdateManyItems(IList<Item> items) {
            ProgressBundleView progressForm = new ProgressBundleView(items);
            progressForm.ShowDialog();

            return progressForm.UpdateSuccessfull;
        }

        public static void EditItem(Item item, BackupApplication application) {
            if (item.ID == ItemID.Group) {
                EditGroup(item as Group);
            } else if (item.ID == ItemID.ItemBundle) {
                EditItemBundle(item as ItemBundle, application);
            } else {
                EditFolder(item as FolderItem, application);
            }
        }
        public static void EditGroup(Group group) {
            InputResult<string> result = CustomDialog.ShowTextInput("Group's name", "Edit the group's name.",
                group.DisplayName, Properties.Resources._64pxRename);

            if (result.DialogClosed) return;

            if (string.IsNullOrEmpty(result.Value)) {
                CustomDialog.ShowError("Error", "Group's name cannot be empty.");
            } else {
                group.DisplayName = result.Value;
            }
        }
        public static void EditFolder(FolderItem folder, BackupApplication application) {
            FolderEditor dialog = new FolderEditor(folder, application);
            dialog.ShowDialog();
        }
        public static void EditItemBundle(ItemBundle itemBundle, BackupApplication application) {
            ItemBundleEditor dialog = new ItemBundleEditor(itemBundle, application);
            dialog.ShowDialog();
        }

        public static void Paste(IEnumerable<Item> items, Group parent) {
            parent.ApplyChangeMode();

            foreach (var thisItem in items) {
                parent.Items.Add(thisItem.Clone() as Item);
            }

            parent.SuspendChangeMode();
        }

        public static void Move(IList<Item> items, Group currentGroup) {
            Func<object, bool> validator = thisItem => {
                if (((Item)thisItem).ID != ItemID.Group || items.Contains((Item)thisItem)) return false;
                return true;
            };

            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(currentGroup, new ItemSelectorProfile() {
                SelectedItemValidator = i => !items.Contains(i as Item) && i != currentGroup
            }, validator);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;

            currentGroup.ApplyChangeMode();

            currentGroup.Move(items, selectionResult.Value[0] as Group);

            currentGroup.SuspendChangeMode();
        }
        public static void Delete(IList<Item> items, Group parent) {
            string result = CustomDialog.ShowMessage("Delete", "Are you sure you want to delete this?",
                Properties.Resources._64pxTrash, SystemSounds.Hand, "Delete", "No");

            if (result == "Delete") {
                DeleteGroupContents(parent, items);
            }
        }
        public static bool DeleteGroupContents(Group parent, IList<Item> items) {
            bool errorFree = true;

            parent.ApplyChangeMode();

            for (int i = 0; i < items.Count; i++) {
                Item item = items[i];

                if (item.ID != ItemID.Group) {
                    if (!(item as UpdateableItem).Delete()) {
                        errorFree = false;
                    }
                } else {
                    if (DeleteGroupContents(item as Group, (item as Group).Items)) {
                        parent.Items.Remove(item);
                    } else {
                        errorFree = false;
                    }
                }
            }

            parent.SuspendChangeMode();

            return errorFree;
        }

        public static void SetDestinationFolder(Item item) {
            UpdateableItem updateableItem = item as UpdateableItem;

            InputResult<string> result = CustomDialog.ShowBrowser(BrowseType.BrowseFolder, "", updateableItem.DestinationFolder);
            if (result.DialogClosed) return;

            updateableItem.DestinationFolder = result.Value;
        }
    }
}
