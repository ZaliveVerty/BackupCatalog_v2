using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using CustomDialogs;
using BackupCatalog;

namespace BackupCatalogGUI {
    public partial class ProgressBundleView : Form {
        public IList<UpdateableItem> UpdateableItems { get; set; }
        private bool _canClose = false;

        public bool UpdateSuccessfull { get; private set; } = false;

        public ProgressBundleView(IList<Item> updateableItems) {
            InitializeComponent();

            UpdateableItems = new List<UpdateableItem>();
            updateableItems.GetUpdateableItems(UpdateableItems);

            UploadingTimer.Interval = 400;
            UploadingTimer.Start();
        }

        private void ProgressBundleView_Load(object sender, EventArgs e) {
            BeginUpdate();
        }

        private void BeginUpdate() {
            IProgress<ItemProgressReport> itemProgress = new Progress<ItemProgressReport>();
            ((Progress<ItemProgressReport>)itemProgress).ProgressChanged += ItemUpdateProgress;

            Thread thread = new Thread(() => {
                for (int i = 0; i < UpdateableItems.Count; i++) {
                    UpdateableItem item = UpdateableItems[i];

                    itemProgress.Report(new ItemProgressReport() {
                        Percentage = i / (float)UpdateableItems.Count,
                        Message = $"{i} / {UpdateableItems.Count}",
                        ActivityType = $"Updating {item.DisplayName}",
                    });

                    UpdateItem(item);
                }

                itemProgress.Report(new ItemProgressReport() {
                    Percentage = 1,
                    Message = "",
                    ActivityType = "Updating finished",
                    State = ProgressState.Finished
                });
            });

            thread.Start();
        }
        private void UpdateItem(UpdateableItem item) {
            Invoke(new Action(() => {
                SubProgressPanel.SetText("Discovering");
                SubProgressPanel.Update(new ProgressReport() {
                    Percentage = 0,
                    ActivityType = "Discovering"
                });
            }));

            Progress<UpdateProgressReport> progress = new Progress<UpdateProgressReport>();
            progress.ProgressChanged += UpdateProgress;

            item.Update(progress);
            UpdateSuccessfull = true;
        }

        private void ItemUpdateProgress(object sender, ItemProgressReport progress) {
            Invoke(new Action(() => {
                if (progress.ActivityType != MainProgressPanel.OriginalActivityTypeText) {
                    MainProgressPanel.SetText(progress.ActivityType);
                }

                MainProgressPanel.Update(new ProgressReportAdapter(progress));

                if (progress.State == ProgressState.Finished) {
                    _canClose = true;
                    Close();
                }
            }));
        }

        private DateTime _prevUpdate = DateTime.MinValue;
        private void UpdateProgress(object sender, UpdateProgressReport progress) {
            if (progress.ProgressState != ProgressState.Finished && (DateTime.Now - _prevUpdate) < TimeSpan.FromMilliseconds(50)) return;
            _prevUpdate = DateTime.Now;

            Invoke(new Action(() => {    
                double percentage = 1D / (progress.TotalFiles == 0 ? 1 : progress.TotalFiles) * progress.CurrentFileIndex;

                ProgressReport report = new ProgressReport() {
                    Percentage = (float)percentage,
                    ActivityType = Path.GetFileName(progress.CurrentFilePath),
                    Message = $"{progress.CurrentFileIndex}/{progress.TotalFiles}"
                };

                SubProgressPanel.Update(report);
                SubProgressPanel.SetText(report.ActivityType);
            }));
        }

        private void UploadingTimer_Tick(object sender, EventArgs e) {
            UpdateText(MainProgressPanel);
            UpdateText(SubProgressPanel);

            Text = MainProgressPanel.ActivityTypeText;
        }
        private void UpdateText(ProgressPanel panel) {
            if (panel.ActivityTypeText.Length - panel.OriginalActivityTypeText.Length < 3) {
                panel.SetText(panel.ActivityTypeText + ".");
            } else {
                panel.SetText(panel.OriginalActivityTypeText);
            }
        }

        private void ProgressBundleView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }
    }
}
