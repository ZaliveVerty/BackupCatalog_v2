using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using BackupCatalog;
using CustomDialogs;

namespace BackupCatalogGUI {
    static class ItemExtensions {
        public static Image GetIcon(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return Properties.Resources._64pxGroup;
                case ItemID.Folder:
                    return Properties.Resources._22pxDirectory;
                case ItemID.ItemBundle:
                default:
                    return Properties.Resources._22pxDirectoryBundle;
            }
        }
        public static string GetTypeString(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return "Group";
                case ItemID.Folder:
                    return "Folder";
                case ItemID.ItemBundle:
                default:
                    return "Item bundle";
            }
        }
        public static string GetImageChacheKey(this Item item) {
            return $"type.item.{item.GetType().FullName}";
        }

        public static string GetLastUpdatedString(this UpdateableItem item) {
            if (item.UpdateHistory.Count == 0) return "Never";

            return (DateTime.Now - item.UpdateHistory.Last()).ToRelativeTimeString();
        }

        public static string GetPath(this Item item) {
            if (item == null) return "";

            string parents = GetPath(item.Parent);
            if (string.IsNullOrEmpty(parents)) return item.DisplayName;

            return $"{parents}\\{item.DisplayName}";
        }
        public static void GetUpdateableItems(this IEnumerable<Item> items, IList<UpdateableItem> output) {
            foreach (Item item in items) {
                if (item.IsUpdateable()) {
                    output.Add(item as UpdateableItem);
                } else if (item.ID == ItemID.Group) {
                    GetUpdateableItems((item as Group).Items, output);
                }
            }
        }

        public static bool IsUpdateable(this Item item) {
            return typeof(UpdateableItem).IsAssignableFrom(item.GetType());
        }
    }
}
