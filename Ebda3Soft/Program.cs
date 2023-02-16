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
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.SelectedSkin))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Properties.Settings.Default.SelectedSkin;
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.SelectedPallete))
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.SelectedSkin, Properties.Settings.Default.SelectedPallete);
                    //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle = Properties.Settings.Default.SkinPalette;

                }
            }
            var locale = "en";
            string selectedLange = Properties.Settings.Default.Lanuage;
            if (selectedLange == "Arabic")
                locale = "ar";

            //Properties.Settings.Default.Lanuage = LanguageComboBox.Text;
            var culture = System.Globalization.CultureInfo.CreateSpecificCulture(locale);
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
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
