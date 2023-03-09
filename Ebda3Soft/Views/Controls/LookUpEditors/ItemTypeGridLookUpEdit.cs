using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Database.Entities.Inventory;
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
    [UserRepositoryItem("RegisterItemTypeGridLookUpEdit")]
    public class RepositoryItemItemTypeGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemItemTypeGridLookUpEdit()
        {
            RegisterItemTypeGridLookUpEdit();
        }

        public const string CustomEditName = "ItemTypeGridLookUpEdit";

        public RepositoryItemItemTypeGridLookUpEdit()
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


            SQLServerDbContext.Instance.ItemTypes.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                bindingSource.DataSource = SQLServerDbContext.Instance.ItemTypes.Local.ToBindingList();
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
                new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(ItemType.TypeName),Visible = true,VisibleIndex=0},
            });
                }
            }

        }
        public override string EditorTypeName => CustomEditName;

        public static void RegisterItemTypeGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(ItemTypeGridLookUpEdit), typeof(RepositoryItemItemTypeGridLookUpEdit), typeof(ItemTypeGridLookUpEditViewInfo), new ItemTypeGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemItemTypeGridLookUpEdit source = item as RepositoryItemItemTypeGridLookUpEdit;
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
    public class ItemTypeGridLookUpEdit : GridLookUpEdit
    {
        static ItemTypeGridLookUpEdit()
        {
            RepositoryItemItemTypeGridLookUpEdit.RegisterItemTypeGridLookUpEdit();
        }

        public ItemTypeGridLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemItemTypeGridLookUpEdit Properties => base.Properties as RepositoryItemItemTypeGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemItemTypeGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new ItemTypeGridLookUpEditPopupForm(this);
        }
    }

    public class ItemTypeGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public ItemTypeGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class ItemTypeGridLookUpEditPainter : LookUpEditPainter
    {
        public ItemTypeGridLookUpEditPainter()
        {
        }
    }

    public class ItemTypeGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public ItemTypeGridLookUpEditPopupForm(ItemTypeGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
