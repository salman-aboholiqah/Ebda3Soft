using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Database.Entities.Financial;
using Ebda3Soft.Core.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ebda3Soft.Views.Controls.LookUpEditors
{
    [UserRepositoryItem("RegisterAccountTypeGridLookUpEdit")]
    public class RepositoryItemAccountTypeGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemAccountTypeGridLookUpEdit()
        {
            RegisterAccountTypeGridLookUpEdit();
        }

        public const string CustomEditName = "AccountTypeGridLookUpEdit";
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private BindingSource bindingSource;
        public RepositoryItemAccountTypeGridLookUpEdit()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode)
            {
                InitializeComponent();
            }
        }
        private void InitializeComponent()
        {
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PopupView = this.gridView;


            bindingSource = new BindingSource();
            bindingSource.DataSource = typeof(AccountType);
            DataSource = bindingSource;
            DisplayMember = nameof(IMemberable.DisplayMember);
            ValueMember = nameof(AccountType.AccountTypeID);


            SQLServerDbContext.Instance.AccountTypes.LoadAsync().ContinueWith(loadTask =>
            {
                    // Bind data to control when loading complete
                    bindingSource.DataSource = SQLServerDbContext.Instance.AccountTypes.Local.ToBindingList();
                DataSource = bindingSource;

            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.OptionsFind.FindDelay = 500;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode && !IsDesignMode)
            {
                if (View.Columns.Count == 0)
                {
                    this.View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(AccountType.TypeName),Visible = true,VisibleIndex=0},
            });
                }
            }

        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterAccountTypeGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(AccountTypeGridLookUpEdit), typeof(RepositoryItemAccountTypeGridLookUpEdit), typeof(AccountTypeGridLookUpEditViewInfo), new AccountTypeGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemAccountTypeGridLookUpEdit source = item as RepositoryItemAccountTypeGridLookUpEdit;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class AccountTypeGridLookUpEdit : GridLookUpEdit
    {
        static AccountTypeGridLookUpEdit()
        {
            RepositoryItemAccountTypeGridLookUpEdit.RegisterAccountTypeGridLookUpEdit();
        }

        public AccountTypeGridLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemAccountTypeGridLookUpEdit Properties => base.Properties as RepositoryItemAccountTypeGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemAccountTypeGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new AccountTypeGridLookUpEditPopupForm(this);
        }
    }

    public class AccountTypeGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public AccountTypeGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class AccountTypeGridLookUpEditPainter : LookUpEditPainter
    {
        public AccountTypeGridLookUpEditPainter()
        {
        }
    }

    public class AccountTypeGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public AccountTypeGridLookUpEditPopupForm(AccountTypeGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
