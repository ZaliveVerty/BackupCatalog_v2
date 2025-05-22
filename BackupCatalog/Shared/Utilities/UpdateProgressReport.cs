using System;

namespace BackupCatalog {
    public class UpdateProgressReport {
        public long TotalFiles { get; init; } = 0;
        public ProgressState ProgressState { get; init; } = ProgressState.NotStarted;

        public long CurrentFileIndex { get; init; } = 0;
        public string CurrentFilePath { get; init; } = string.Empty;
    }
}
