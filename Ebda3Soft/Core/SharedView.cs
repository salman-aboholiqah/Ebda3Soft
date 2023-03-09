using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Ebda3Soft.Core.CustomAttributes;
using Ebda3Soft.Core.Database.Entities.Financial;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Core.Models;
using Ebda3Soft.Views.Core.Dialogs;
using Ebda3Soft.Views.UserControls.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ebda3Soft.Core
{
    public class SharedView
    {
        public static void SetTranslate(RibbonPageCollection pages)
        {
            foreach (RibbonPage page in pages)
            {
                var pageTranslation = new LocalizableDisplayNameAttribute(page.Text.Replace(" ", ""))?.DisplayName;
                if (pageTranslation != null)
                {
                    page.Text = pageTranslation;
                }
                foreach (RibbonPageGroup group in page.Groups)
                {
                    var groupTranslation = new LocalizableDisplayNameAttribute(group.Text.Replace(" ", ""))?.DisplayName;
                    if (groupTranslation != null)
                    {
                        group.Text = groupTranslation;
                    }
                    
                    foreach (BarButtonItemLink item in group.ItemLinks)
                    {
                        var itemTranslation = new LocalizableDisplayNameAttribute(item.Caption.Replace(" ", ""))?.DisplayName;
                        if (itemTranslation != null)
                        {
                            item.Caption = itemTranslation;
                        }
                    }
                }
            }
        }
        public static void SetTranslate(BaseEdit item)
        {
            var translation = new LocalizableDisplayNameAttribute(item.Text.Replace(" ",""))?.DisplayName;
            if (translation != null)
            {
                item.Text = translation;
            }
        }
        public static void SetTranslate(DevExpress.XtraDataLayout.DataLayoutControl control)
        {
            foreach (BaseLayoutItem item in control.Items)
            {
                if (!item.Visible || !item.TextVisible)
                    continue;

                var layoutItem = item as LayoutControlItem;
                if (layoutItem == null)
                    continue;

                string propertyName = layoutItem.Name.Replace("itemFor","");
                
                if (layoutItem.Control != null && layoutItem.Control.DataBindings.Count > 0)
                {
                    var bind = layoutItem.Control.DataBindings[0].BindingMemberInfo.BindingField;
                    if (bind.EndsWith("ID"))
                        bind = bind.Replace("ID", "Name");
                    propertyName = bind;

                }
                var translation = new LocalizableDisplayNameAttribute(propertyName)?.DisplayName;
                if (translation != null)
                {
                    layoutItem.Text = translation;
                }
            }
        }
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
