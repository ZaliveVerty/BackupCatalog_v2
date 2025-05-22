using System;
using System.Windows.Forms;
using System.IO;
using CustomDialogs;
using BackupCatalog;

namespace BackupCatalogGUI {
    public partial class ProgressView : Form {
        private Progress<UpdateProgressReport> _progress;
        private bool _canClose = false;
        private bool _setPanelText = false;

        public ProgressView(Progress<UpdateProgressReport> progress) {
            InitializeComponent();

            _progress = progress;
            _progress.ProgressChanged += UpdateProgress;

            UploadingTitleTimer.Interval = 400;
            UploadingTitleTimer.Start();
        }

        public void SetText(string text, bool setPanelText = true) {
            if (_title.StartsWith(text)) return;

            Text = text;
            _title = text;

            if(setPanelText) ProgressPanel.SetText(Text);
            _setPanelText = setPanelText;
        }

        private DateTime _prevUpdate = DateTime.MinValue;
        private void UpdateProgress(object sender, UpdateProgressReport progress) {
            if (progress.ProgressState != ProgressState.Finished && (DateTime.Now - _prevUpdate) < TimeSpan.FromMilliseconds(50)) return;
            _prevUpdate = DateTime.Now;

            SetText("Copying", false);

            double percentage = 1D / (progress.TotalFiles == 0 ? 1 : progress.TotalFiles) * progress.CurrentFileIndex;

            ProgressReport report = new ProgressReport() {
                Percentage = (float)percentage,
                ActivityType = Path.GetFileName(progress.CurrentFilePath),
                Message = $"{progress.CurrentFileIndex}/{progress.TotalFiles}"
            };

            ProgressPanel.Update(report);
            ProgressPanel.SetText(report.ActivityType);

            if (progress.ProgressState == ProgressState.Finished) {
                _canClose = true;
                Close();
            }
        }

        private void ProgressView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }

        private string _title = "";
        private void UploadingTitleTimer_Tick(object sender, EventArgs e) {
            if (Text.Length - _title.Length < 3) {
                Text += ".";
            } else {
                Text = _title;
            }

            if(_setPanelText) ProgressPanel.SetText(Text);
        }
    }
}
