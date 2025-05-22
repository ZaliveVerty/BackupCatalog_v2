using System;
using System.Windows.Forms;
using BackupCatalog;

namespace BackupCatalogGUI {
    static class Program {
        private static BackupApplication BackupApplication;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BackupApplication = new BackupApplication();
            GuiApplication guiApplication = new GuiApplication(BackupApplication.CacheController, BackupApplication.RootResource.Group);

            BackupApplication.RootResource.Group.ContentChanged += Root_ContentChanged;

            Application.Run(new ItemExplorer(BackupApplication, guiApplication));
        }

        private static void Root_ContentChanged(object sender, EventArgs e) {
            BackupApplication.RootResource.Save();
        }
    }
}
