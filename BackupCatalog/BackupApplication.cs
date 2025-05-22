using System;
using CommonUtilities;

namespace BackupCatalog {
    public class BackupApplication {
        public GroupResource RootResource { get; set; }

        public string StoragePath => $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage";
        public IFileCacheController CacheController { get; set; }

        public BackupApplication() {
            CacheController = new FileCacheController() { 
                Directory = StoragePath
            };

            RootResource = new GroupResource(CacheController);
            RootResource.Load();
        }
    }
}
