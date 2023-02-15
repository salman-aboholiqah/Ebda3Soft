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
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ebda3Soft.Views.Controls.LookUpEditors
{
    [UserRepositoryItem("RegisterJournalTypeGridLookUpEdit")]
    public class RepositoryItemJournalTypeGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemJournalTypeGridLookUpEdit()
        {
            RegisterJournalTypeGridLookUpEdit();
        }

        public const string CustomEditName = "JournalTypeGridLookUpEdit";
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;

        public RepositoryItemJournalTypeGridLookUpEdit()
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

            InitButtons();
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.OptionsFind.FindDelay = 500;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
        }

        private void InitButtons()
        {
            Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            });
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
                        new DevExpress.XtraGrid.Columns.GridColumn{FieldName = nameof(IMemberable.DisplayMember),Visible = true,VisibleIndex=1},
                 });

                }

            }

        }
        public override string EditorTypeName => CustomEditName;
       
        public static void RegisterJournalTypeGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(JournalTypeGridLookUpEdit), typeof(RepositoryItemJournalTypeGridLookUpEdit), typeof(JournalTypeGridLookUpEditViewInfo), new JournalTypeGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemJournalTypeGridLookUpEdit source = item as RepositoryItemJournalTypeGridLookUpEdit;
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
    public class JournalTypeGridLookUpEdit : GridLookUpEdit
    {
        static JournalTypeGridLookUpEdit()
        {
            RepositoryItemJournalTypeGridLookUpEdit.RegisterJournalTypeGridLookUpEdit();
        }

        public JournalTypeGridLookUpEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemJournalTypeGridLookUpEdit Properties => base.Properties as RepositoryItemJournalTypeGridLookUpEdit;

        public override string EditorTypeName => RepositoryItemJournalTypeGridLookUpEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            return new JournalTypeGridLookUpEditPopupForm(this);
        }
    }

    public class JournalTypeGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public JournalTypeGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class JournalTypeGridLookUpEditPainter : LookUpEditPainter
    {
        public JournalTypeGridLookUpEditPainter()
        {
        }
    }

    public class JournalTypeGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public JournalTypeGridLookUpEditPopupForm(JournalTypeGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
