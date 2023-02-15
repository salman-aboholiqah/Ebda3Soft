using DevExpress.Skins;
using DevExpress.UserSkins;
using Ebda3Soft.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace Ebda3Soft
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Database.SetInitializer(new CreateDatabaseIfNotExists<SQLServerDbContext>());
            WindowsFormsSettings.LoadApplicationSettings();
            var font = Properties.Settings.Default.DefaultFont;
            if (font != null)
            {
                WindowsFormsSettings.DefaultFont = font;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
