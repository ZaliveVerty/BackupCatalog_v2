using System;
using BackupCatalog;

namespace BackupCatalogGUI {
    public class ItemProgressReport {
        public float Percentage { get; set; }
        public string Message { get; set; }
        public string ActivityType { get; set; }
        public ProgressState State { get; set; } = ProgressState.NotStarted;
    }
}
