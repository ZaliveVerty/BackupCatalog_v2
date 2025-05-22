using System;
using CustomDialogs;

namespace BackupCatalogGUI {
    public class ProgressReport : IProgressReport {
        public float Percentage { get; set; }
        public string Message { get; set; }
        public string ActivityType { get; set; }
    }
}
