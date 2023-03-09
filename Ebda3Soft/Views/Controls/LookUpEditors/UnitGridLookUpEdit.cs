using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Ebda3Soft.Core.Database;
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
    [UserRepositoryItem("RegisterUnitGridLookUpEdit")]
    public class RepositoryItemUnitGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemUnitGridLookUpEdit()
        {
            RegisterUnitGridLookUpEdit();
        }

        public const string CustomEditName = "UnitGridLookUpEdit";

        public RepositoryItemUnitGridLookUpEdit()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode && !IsDesignMode)
                InitializeComponent();
        }
        private BindingSource bindingSource;
        private void InitializeComponent()
        {

            bindingSource = new BindingSource();
            DataSource = bindingSource;
            DisplayMember = nameof(IMemberable.DisplayMember);
            ValueMember = nameof(IMemberable.KeyMember);


            SQLServerDbContext.Instance.Units.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                bindingSource.DataSource = SQLServerDbContext.Instance.Units.Local.ToBindingList();
                DataSource = bindingSource;

            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
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
                new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(IMemberable.DisplayMember),Visible = true,VisibleIndex=0},
            });
                }
            }

        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterUnitGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(UnitGridLookUpEdit), typeof(RepositoryItemUnitGridLookUpEdit), typeof(UnitGridLookUpEditViewInfo), new UnitGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemUnitGridLookUpEdit source = item as RepositoryItemUnitGridLookUpEdit;
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
    public class UnitGridLookUpEdit : GridLookUpEdit
    {
        static UnitGridLookUpEdit()
        {
            RepositoryItemUnitGridLookUpEdit.RegisterUnitGridLookUpEdit();
        }

        public UnitGridLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemUnitGridLookUpEdit Properties => base.Properties as RepositoryItemUnitGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemUnitGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new UnitGridLookUpEditPopupForm(this);
        }
    }

    public class UnitGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public UnitGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class UnitGridLookUpEditPainter : LookUpEditPainter
    {
        public UnitGridLookUpEditPainter()
        {
        }
    }

    public class UnitGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public UnitGridLookUpEditPopupForm(UnitGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
