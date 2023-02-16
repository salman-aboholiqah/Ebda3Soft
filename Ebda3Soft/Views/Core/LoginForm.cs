using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using Ebda3Soft.Core;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Views.UserControls
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {

            InitializeComponent();
            LanguageComboBox.Text = Properties.Settings.Default.Lanuage;
            string selectedLange = Properties.Settings.Default.Lanuage;
            if (selectedLange == "Arabic")
            {

                RightToLeft
                  = RightToLeft.Yes;
                RightToLeftLayout = true;

            }

        }


        private void Login()
        {

            string password = PasswordEditText.Text;
            string loginID = LoginIDEditText.Text;
            password = User.HashFunction(password);
            var user = SQLServerDbContext.Instance.Users.Where(a => a.LoginID == loginID && a.HashedPassword == password).FirstOrDefault();
            if (user == null)
            {
                FlyoutDialog.Show(this, "Error", "The password or login id incorrect!", MessageBoxButtons.OK);

                return;
            }
            if (!user.IsEnabled)
            {
                FlyoutDialog.Show(this, "Error", "This user has been disabled!", MessageBoxButtons.OK);
                return;
            }

            SharedView.User = user;
            DialogResult = DialogResult.OK;
            var locale = "en";
            if (LanguageComboBox.Text == "Arabic")
                locale = "ar";

            Properties.Settings.Default.Lanuage = LanguageComboBox.Text;
            var culture = System.Globalization.CultureInfo.CreateSpecificCulture(locale);
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;


        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}