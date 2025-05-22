using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BinaryObjectFormat;

namespace BackupCatalog {
    public abstract class UpdateableItem : Item {
        public string UniqueID { get; private set; }
        public IList<DateTime> UpdateHistory { get; set; } = new List<DateTime>();
        
        public string DestinationFolder {
            get => _destinationFolder;
            set {
                if (value == null) return;

                _destinationFolder = value;
                CallContentChanged();
            }
        }
        private string _destinationFolder = "";

        public UpdateableItem(ItemID id) : base(id) {
            UniqueID = $"{Guid.NewGuid()}-{DateTime.Now.Ticks}";
        }

        public void Update(IProgress<UpdateProgressReport> progress) {
            string[][] items = ProvideItems();

            progress.Report(new UpdateProgressReport() {
                ProgressState = ProgressState.InProcess
            });

            RemoveAllItems(items);

            List<(string, string[])> allFiles = new List<(string, string[])>();
            foreach (var folder in items[0]) {
                allFiles.Add((Path.GetDirectoryName(folder), Directory.GetFiles(folder, "*", SearchOption.AllDirectories)));

                CreateAllDirectories(folder, Directory.GetDirectories(folder, "*", SearchOption.AllDirectories));
            }

            foreach (var file in items[1]) {
                allFiles.Add((Path.GetDirectoryName(file), new string[] { file }));
            }

            CreateAllFiles(allFiles, progress);

            progress.Report(new UpdateProgressReport() {
                ProgressState = ProgressState.Finished
            });

            UpdateHistory.Add(DateTime.Now);
        }
        public abstract string[][] ProvideItems();

        private void RemoveAllItems(string[][] items) {
            foreach (var folder in items[0]) {
                string dest = $"{DestinationFolder}\\{Path.GetFileName(folder)}";
                if (Directory.Exists(dest)) Directory.Delete(dest, true);
            }

            foreach (var file in items[1]) {
                string dest = $"{DestinationFolder}\\{Path.GetFileName(file)}";
                if (File.Exists(dest)) File.Delete(dest);
            }
        }

        private void CreateAllDirectories(string baseDirectory, IEnumerable<string> directories) {
            Directory.CreateDirectory($"{DestinationFolder}\\{Path.GetFileName(baseDirectory)}");
            string baseParent = Path.GetDirectoryName(baseDirectory);

            foreach (string folder in directories) {
                string dest = GetDestination(folder, baseParent);
                Directory.CreateDirectory(dest);
            }
        }
        private void CreateAllFiles(List<(string, string[])> files, IProgress<UpdateProgressReport> progress) {
            long amount = files.Sum(x => x.Item2.Length);
            long index = 0;

            foreach (var bundle in files) {
                foreach (var file in bundle.Item2) {
                    string dest = GetDestination(file, bundle.Item1);

                    progress.Report(new UpdateProgressReport() { 
                        TotalFiles = amount,
                        ProgressState = ProgressState.InProcess,
                        CurrentFileIndex = index,
                        CurrentFilePath = file
                    });

                    File.Copy(file, dest);
                    index++;
                }
            }
        }

        private string GetDestination(string main, string baseDirectory) { 
            return $"{DestinationFolder}\\{GetUncommonString(main, baseDirectory)}";
        }
        private static string GetUncommonString(string main, string baseString) {
            if (main == baseString) return main;

            StringBuilder builder = new StringBuilder(main);

            int min = Math.Min(main.Length, baseString.Length);
            for (int i = 0; i < min; i++) {
                if (main[i] != baseString[i]) {
                    return builder.ToString();
                }
                
                builder.Remove(0, 1);
            }

            return builder.ToString();
        }

        public bool Delete() {
            Parent.Items.Remove(this);

            return true;
        }

        public override ObjectTag Serialize() {
            ObjectTag output = base.Serialize();
            output.Add("UniqueID", UniqueID);
            output.Add("DestinationFolder", DestinationFolder);
            output.Add("UpdateHistory", UpdateHistory.ToArray());

            return output;
        }
        public static void Deserialize(ObjectTag obj, UpdateableItem output) {
            Item.Deserialize(obj, output);
            output.UniqueID = obj["UniqueID"];
            output.DestinationFolder = obj["DestinationFolder"];
            output.UpdateHistory = ((ArrayTag)obj["UpdateHistory"]).As<DateTime>().ToList();
        }

        public UpdateableItem Copy(UpdateableItem item) {
            base.Copy(item);
            item.DestinationFolder = DestinationFolder;
            
            return item;
        }
    }
}
