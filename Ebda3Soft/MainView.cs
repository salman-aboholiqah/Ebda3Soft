using DevExpress.XtraEditors;
using Ebda3Soft.Core;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Views.Core.Dialogs;
using Ebda3Soft.Views.UserControls;
using Ebda3Soft.Views.UserControls.Financial;
using Ebda3Soft.Views.UserControls.GeneralSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ebda3Soft
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
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
                        var dialogResult = SharedView.ShowUserControlDialog(new UserView(bindingSource, Core.Enums.TransactionType.Adding,true)) ;

                    }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
                }
                var loginForm = new LoginForm();
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    bsiUserFullName.Caption = SharedView.User.FullName;
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
            tabbedView1.AddDocument(new JournalCollectionView(Core.Enums.JournalView.SimpleJournal), "Journals");
        }

        private void bbiReceipts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalCollectionView(Core.Enums.JournalView.Recetip), "Receipts");

        }
        private void bbiPayments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbedView1.AddDocument(new JournalCollectionView(Core.Enums.JournalView.Payment), "Payement");
        }

        private void bbiCultureSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new SystemStyleDialog().ShowDialog();
        }
    }
}
