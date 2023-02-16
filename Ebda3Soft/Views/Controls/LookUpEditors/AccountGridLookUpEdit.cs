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

namespace Ebda3Soft.Views.Controls.LookUpEditors
{
    [UserRepositoryItem("RegisterAccountGridLookUpEdit")]
    public class RepositoryItemAccountGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        static RepositoryItemAccountGridLookUpEdit()
        {
            RegisterAccountGridLookUpEdit();
        }
        public bool AutoLoad { get; set; } = false;
        public const string CustomEditName = "AccountGridLookUpEdit";

        public RepositoryItemAccountGridLookUpEdit()
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

            DisplayMember = nameof(IMemberable.DisplayMember);
            ValueMember = nameof(IMemberable.KeyMember);
            LoadData();
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.OptionsFind.FindDelay = 500;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;

            Properties.Buttons.Clear();
            if (Properties.Buttons.Count < 1)
            {
                Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo));
            }
            if (Buttons.Count < 2)
            {
                Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Make Default"));
            }
            if (Buttons.Count < 3)
            {
                Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "Clear Data"));
            }
            if (Buttons.Count < 4)
            {
                Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus,"New Data"));
            }
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
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(Account.AccountNumber),Visible = true,VisibleIndex=1},
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(Account.DisplayMember),Visible = true,VisibleIndex=1},
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(Account.AccountType),Visible = true,VisibleIndex=1},
                            });

                }

            }

        }
        private void LoadData()
        {
            DataSource = SQLServerDbContext.Instance.Accounts.ToList();

        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterAccountGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(AccountGridLookUpEdit), typeof(RepositoryItemAccountGridLookUpEdit), typeof(AccountGridLookUpEditViewInfo), new AccountGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemAccountGridLookUpEdit source = item as RepositoryItemAccountGridLookUpEdit;
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
    public class AccountGridLookUpEdit : GridLookUpEdit
    {
        static AccountGridLookUpEdit()
        {
            RepositoryItemAccountGridLookUpEdit.RegisterAccountGridLookUpEdit();
        }

        public AccountGridLookUpEdit()
        {

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemAccountGridLookUpEdit Properties => base.Properties as RepositoryItemAccountGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemAccountGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new AccountGridLookUpEditPopupForm(this);
        }
    }

    public class AccountGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public AccountGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class AccountGridLookUpEditPainter : LookUpEditPainter
    {
        public AccountGridLookUpEditPainter()
        {
        }
    }

    public class AccountGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public AccountGridLookUpEditPopupForm(AccountGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
