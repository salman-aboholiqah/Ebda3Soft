using DevExpress.XtraEditors;
using Ebda3Soft.Core.Database.Entities.Financial;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Database.Interfaces;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Core.Models;
using Ebda3Soft.Views.Controls;
using Ebda3Soft.Views.Core.Dialogs;
using Ebda3Soft.Views.UserControls;
using Ebda3Soft.Views.UserControls.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Core
{
    public class SharedView
    {
        private static List<ViewInfo> views = new List<ViewInfo>
        {
            new ViewInfo
            {
                ViewID = Guid.Parse("005C866F-C4DB-431B-9805-F078DCDF574C"),
                ViewCaption = "Account Types",
                EntityType = nameof(AccountType),
                ViewName = nameof(AccountTypeCollectionView),
                EditFormName= nameof(AccountTypeView),
                SystemInfo = SystemInfo.Financial,
                ViewType = TransactionType.Viewing | TransactionType.Adding | TransactionType.Modifying | TransactionType.Deleting | TransactionType.Printing
            },
            new ViewInfo
            {
                ViewID = Guid.Parse("105C866F-C4DB-431B-9805-F078DCDF574C"),
                ViewCaption = "Currencies",
                EntityType = nameof(Currency),
                ViewName = nameof(CurrencyCollectionView),
                EditFormName= nameof(CurrencyView),
                SystemInfo = SystemInfo.Financial,
                ViewType = TransactionType.Viewing | TransactionType.Adding | TransactionType.Modifying | TransactionType.Deleting | TransactionType.Printing
            },
            new ViewInfo
            {
                ViewID = Guid.Parse("205C866F-C4DB-431B-9805-F078DCDF574C"),
                ViewCaption = "Accounts",
                EntityType = nameof(Account),
                ViewName = nameof(AccountCollectionView),
                EditFormName= nameof(AccountView),
                SystemInfo = SystemInfo.Financial,
                ViewType = TransactionType.Viewing | TransactionType.Adding | TransactionType.Modifying | TransactionType.Deleting | TransactionType.Printing
            },
            //new ViewInfo
            //{
            //    ViewCaption = "Account Types",
            //    ViewName = nameof(AccountTypeCollectionView),
            //    EditFormName= nameof(AccountTypeView),
            //    SystemInfo = SystemInfo.Financial,
            //    ViewType = ViewType.Viewing | ViewType.Adding | ViewType.Modifying | ViewType.Deleting | ViewType.Printing
            //},
        };
        internal static ViewInfo GetViewByID(Guid viewID)
        {
            return views.FirstOrDefault(v => v.ViewID == viewID);
        }


        private static User user;
        public static User User { get => user; set => user = value; }



        internal static void ShowUserControlForm(XtraUserControl control)
        {
            var frm = new UserControlForm(control);
            frm.Show();
        }
        internal static DialogResult ShowUserControlDialog(XtraUserControl control)
        {
            var frm = new UserControlForm(control);
            return frm.ShowDialog();
        }
        internal static List<ViewInfo> GetAllViews()
        {
            return views;
        }
    }
}
