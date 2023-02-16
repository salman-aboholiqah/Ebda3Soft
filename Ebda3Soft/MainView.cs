using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using Ebda3Soft.Core;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Views.Core.Dialogs;
using Ebda3Soft.Views.Dashboard;
using Ebda3Soft.Views.UserControls;
using Ebda3Soft.Views.UserControls.Financial;
using Ebda3Soft.Views.UserControls.GeneralSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DashboardUserControl dashboard;
        public MainView()
        {
            InitializeComponent();
            string selectedLange = Properties.Settings.Default.Lanuage;
            if (selectedLange == "Arabic")
            {

                RightToLeft
                  = RightToLeft.Yes;
                RightToLeftLayout = true;

            }
        }

        private void bbiAccountTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new AccountTypeCollectionView(), "Account Types");
        }

        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectPage(e.MergedChild.Pages.First());
        }

        private void bbiCurrencies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new CurrencyCollectionView(), "Currencies");

        }

        private void bbiAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new AccountCollectionView(), "Accounts");

        }
        private void Login()
        {
            this.Enabled = false;
            documentManager1.View.Controller.CloseAll();
            using (var dbContext = SQLServerDbContext.Instance)
            {
                var usersCount = dbContext.Users.Where(a => a.IsSuperAdmin).Count();
                if (usersCount == 0)
                {
                    dbContext.Users.LoadAsync().ContinueWith(loadTask =>
                    {
                        var bindingSource = new BindingSource();
                        // Bind data to control when loading complete
                        bindingSource.DataSource = dbContext.Users.Local.ToBindingList();
                        var dialogResult = SharedView.ShowUserControlDialog(new UserView(bindingSource, Core.Enums.TransactionType.Adding, true));

                    }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
                }
                var loginForm = new LoginForm();
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    bsiUserFullName.Caption = SharedView.User.FullName;
                    bsiDatabase.Caption = dbContext.Database.Connection.Database;
                    bsiServerName.Caption = dbContext.Database.Connection.DataSource;
                    if (CultureInfo.CurrentCulture.Name.Contains("ar"))
                    {
                        RightToLeft
                            
                            = ribbonControl1.RightToLeft
                            = RightToLeft.Yes;
                        RightToLeftLayout = true;
                    }
                    else
                    {
                        ribbonControl1.RightToLeft
                        = RightToLeft
                        = RightToLeft.No;
                    }
                    this.Enabled = true;
                }
                else
                {
                    Application.Exit();
                }
            }

        }
        private void MainView_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void bbiUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new UserCollectionView(), "Users");

        }

        private void bbiJournalTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalTypeCollectionView(), "Journal Types");

        }

        private void bbiJournals_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalCollectionView(), "All Journals");
        }

        private void bbiReceipts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalCollectionView(Core.Enums.JournalFormView.Recetip), "Receipts");

        }
        private void bbiPayments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalCollectionView(Core.Enums.JournalFormView.Payment), "Payement");
        }

        private void bbiCultureSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new SystemStyleDialog().ShowDialog();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SelectedSkin = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.SelectedPallete = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName;
        }

        private void bbiSimpleJournal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            tabbedView1.AddDocument(new JournalCollectionView(
                Core.Enums.JournalFormView.SimpleJournal
                ), "Simple Journal");

        }

        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

        }

        private void bbiDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dashboard == null || dashboard.IsDisposed)
                dashboard = new DashboardUserControl();
            tabbedView1.AddDocument(dashboard, "Dashboard");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bsiDatetime.Caption = DateTime.Now.ToString();
        }

        private void bbiLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login();
        }
    }
}
