using System;
using CustomDialogs;

namespace BackupCatalogGUI {
    public class ProgressReportAdapter : IProgressReport {
        public float Percentage { get; }
        public string Message { get; }
        public string ActivityType { get; }

        public ProgressReportAdapter(ItemProgressReport report) {
            Percentage = report.Percentage;
            Message = report.Message;
            ActivityType = report.ActivityType;
        }
    }
}
