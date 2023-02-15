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
    [UserRepositoryItem("RegisterCurrencyGridLookUpEdit")]
    public class RepositoryItemCurrencyGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemCurrencyGridLookUpEdit()
        {
            RegisterCurrencyGridLookUpEdit();
        }

        public const string CustomEditName = "CurrencyGridLookUpEdit";

        public RepositoryItemCurrencyGridLookUpEdit()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode)
            {
                InitializeComponent();
            }
        }
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;

        private void InitializeComponent()
        {

            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PopupView = this.gridView;

            DisplayMember = nameof(IMemberable.DisplayMember);
            ValueMember = nameof(Currency.CurrencyID);


            SQLServerDbContext.Instance.Currencies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                DataSource = SQLServerDbContext.Instance.Currencies.Local.ToBindingList();
                //DataSource = bindingSource;

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
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(Currency.CurrencyName),Visible = true,VisibleIndex=0},
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(Currency.Sign),Visible = true,VisibleIndex=0},
                    });
                }
            }
        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterCurrencyGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CurrencyGridLookUpEdit), typeof(RepositoryItemCurrencyGridLookUpEdit), typeof(CurrencyGridLookUpEditViewInfo), new CurrencyGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCurrencyGridLookUpEdit source = item as RepositoryItemCurrencyGridLookUpEdit;
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
    public class CurrencyGridLookUpEdit : GridLookUpEdit
    {
        static CurrencyGridLookUpEdit()
        {
            RepositoryItemCurrencyGridLookUpEdit.RegisterCurrencyGridLookUpEdit();
        }

        public CurrencyGridLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCurrencyGridLookUpEdit Properties => base.Properties as RepositoryItemCurrencyGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemCurrencyGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new CurrencyGridLookUpEditPopupForm(this);
        }
    }

    public class CurrencyGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public CurrencyGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class CurrencyGridLookUpEditPainter : LookUpEditPainter
    {
        public CurrencyGridLookUpEditPainter()
        {
        }
    }

    public class CurrencyGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public CurrencyGridLookUpEditPopupForm(CurrencyGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
