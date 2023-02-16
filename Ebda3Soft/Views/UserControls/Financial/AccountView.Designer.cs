
namespace Ebda3Soft.Views.UserControls.Financial
{
    partial class AccountView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.logInfoControl1 = new Ebda3Soft.Views.Controls.LogInfoControl();
            this.currencyGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.CurrencyGridLookUpEdit();
            this.currencyGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountTypeGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.AccountTypeGridLookUpEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypeGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccountNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccountNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrenciesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCurrencyGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.RepositoryItemCurrencyGridLookUpEdit();
            this.repositoryItemCurrencyGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsParentCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAccountNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrencies = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccountName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsParent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrenciesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCurrencyGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCurrencyGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsParentCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.logInfoControl1);
            this.dataLayoutControl1.Controls.Add(this.currencyGridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.accountTypeGridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.AccountNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccountNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrenciesGridControl);
            this.dataLayoutControl1.Controls.Add(this.IsParentCheckEdit);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(596, 285);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // logInfoControl1
            // 
            this.logInfoControl1.Location = new System.Drawing.Point(12, 225);
            this.logInfoControl1.Name = "logInfoControl1";
            this.logInfoControl1.ReferenceGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.logInfoControl1.Size = new System.Drawing.Size(572, 48);
            this.logInfoControl1.TabIndex = 11;
            // 
            // currencyGridLookUpEdit1
            // 
            this.currencyGridLookUpEdit1.Location = new System.Drawing.Point(103, 60);
            this.currencyGridLookUpEdit1.Name = "currencyGridLookUpEdit1";
            this.currencyGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Add To Currencies List", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.currencyGridLookUpEdit1.Properties.PopupView = this.currencyGridLookUpEdit1View;
            this.currencyGridLookUpEdit1.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.currencyGridLookUpEdit1_Properties_ButtonClick);
            this.currencyGridLookUpEdit1.Size = new System.Drawing.Size(193, 20);
            this.currencyGridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.currencyGridLookUpEdit1.TabIndex = 10;
            // 
            // currencyGridLookUpEdit1View
            // 
            this.currencyGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.currencyGridLookUpEdit1View.Name = "currencyGridLookUpEdit1View";
            this.currencyGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.currencyGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // accountTypeGridLookUpEdit1
            // 
            this.accountTypeGridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "AccountTypeID", true));
            this.accountTypeGridLookUpEdit1.Location = new System.Drawing.Point(103, 36);
            this.accountTypeGridLookUpEdit1.Name = "accountTypeGridLookUpEdit1";
            this.accountTypeGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountTypeGridLookUpEdit1.Properties.PopupView = this.accountTypeGridLookUpEdit1View;
            this.accountTypeGridLookUpEdit1.Size = new System.Drawing.Size(193, 20);
            this.accountTypeGridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.accountTypeGridLookUpEdit1.TabIndex = 9;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Financial.Account);
            // 
            // accountTypeGridLookUpEdit1View
            // 
            this.accountTypeGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.accountTypeGridLookUpEdit1View.Name = "accountTypeGridLookUpEdit1View";
            this.accountTypeGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.accountTypeGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // AccountNumberTextEdit
            // 
            this.AccountNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "AccountNumber", true));
            this.AccountNumberTextEdit.Location = new System.Drawing.Point(103, 12);
            this.AccountNumberTextEdit.Name = "AccountNumberTextEdit";
            this.AccountNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AccountNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AccountNumberTextEdit.Properties.Mask.EditMask = "N0";
            this.AccountNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AccountNumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AccountNumberTextEdit.Size = new System.Drawing.Size(193, 20);
            this.AccountNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.AccountNumberTextEdit.TabIndex = 4;
            // 
            // AccountNameTextEdit
            // 
            this.AccountNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "AccountName", true));
            this.AccountNameTextEdit.Location = new System.Drawing.Point(391, 12);
            this.AccountNameTextEdit.Name = "AccountNameTextEdit";
            this.AccountNameTextEdit.Size = new System.Drawing.Size(193, 20);
            this.AccountNameTextEdit.StyleController = this.dataLayoutControl1;
            this.AccountNameTextEdit.TabIndex = 5;
            // 
            // CurrenciesGridControl
            // 
            this.CurrenciesGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Currencies", true));
            this.CurrenciesGridControl.Location = new System.Drawing.Point(12, 100);
            this.CurrenciesGridControl.MainView = this.gridView1;
            this.CurrenciesGridControl.Name = "CurrenciesGridControl";
            this.CurrenciesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCurrencyGridLookUpEdit1});
            this.CurrenciesGridControl.Size = new System.Drawing.Size(572, 121);
            this.CurrenciesGridControl.TabIndex = 7;
            this.CurrenciesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrency});
            this.gridView1.GridControl = this.CurrenciesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Currency";
            this.colCurrency.ColumnEdit = this.repositoryItemCurrencyGridLookUpEdit1;
            this.colCurrency.FieldName = "CurrencyID";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 0;
            // 
            // repositoryItemCurrencyGridLookUpEdit1
            // 
            this.repositoryItemCurrencyGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemCurrencyGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCurrencyGridLookUpEdit1.Name = "repositoryItemCurrencyGridLookUpEdit1";
            this.repositoryItemCurrencyGridLookUpEdit1.PopupView = this.repositoryItemCurrencyGridLookUpEdit1View;
            this.repositoryItemCurrencyGridLookUpEdit1.ValueMember = "CurrencyID";
            // 
            // repositoryItemCurrencyGridLookUpEdit1View
            // 
            this.repositoryItemCurrencyGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrencyName});
            this.repositoryItemCurrencyGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemCurrencyGridLookUpEdit1View.Name = "repositoryItemCurrencyGridLookUpEdit1View";
            this.repositoryItemCurrencyGridLookUpEdit1View.OptionsFind.FindDelay = 500;
            this.repositoryItemCurrencyGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemCurrencyGridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemCurrencyGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 0;
            // 
            // IsParentCheckEdit
            // 
            this.IsParentCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsParent", true));
            this.IsParentCheckEdit.Location = new System.Drawing.Point(300, 36);
            this.IsParentCheckEdit.Name = "IsParentCheckEdit";
            this.IsParentCheckEdit.Properties.Caption = "Is Parent";
            this.IsParentCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsParentCheckEdit.Size = new System.Drawing.Size(284, 20);
            this.IsParentCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsParentCheckEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(596, 285);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAccountNumber,
            this.ItemForCurrencies,
            this.ItemForAccountName,
            this.ItemForIsParent,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(576, 265);
            // 
            // ItemForAccountNumber
            // 
            this.ItemForAccountNumber.Control = this.AccountNumberTextEdit;
            this.ItemForAccountNumber.Location = new System.Drawing.Point(0, 0);
            this.ItemForAccountNumber.Name = "ItemForAccountNumber";
            this.ItemForAccountNumber.Size = new System.Drawing.Size(288, 24);
            this.ItemForAccountNumber.Text = "Account Number";
            this.ItemForAccountNumber.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCurrencies
            // 
            this.ItemForCurrencies.Control = this.CurrenciesGridControl;
            this.ItemForCurrencies.Location = new System.Drawing.Point(0, 72);
            this.ItemForCurrencies.Name = "ItemForCurrencies";
            this.ItemForCurrencies.Size = new System.Drawing.Size(576, 141);
            this.ItemForCurrencies.StartNewLine = true;
            this.ItemForCurrencies.Text = "Currencies";
            this.ItemForCurrencies.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCurrencies.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForAccountName
            // 
            this.ItemForAccountName.Control = this.AccountNameTextEdit;
            this.ItemForAccountName.Location = new System.Drawing.Point(288, 0);
            this.ItemForAccountName.Name = "ItemForAccountName";
            this.ItemForAccountName.Size = new System.Drawing.Size(288, 24);
            this.ItemForAccountName.Text = "Account Name";
            this.ItemForAccountName.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForIsParent
            // 
            this.ItemForIsParent.Control = this.IsParentCheckEdit;
            this.ItemForIsParent.Location = new System.Drawing.Point(288, 24);
            this.ItemForIsParent.Name = "ItemForIsParent";
            this.ItemForIsParent.Size = new System.Drawing.Size(288, 24);
            this.ItemForIsParent.Text = "Is Parent";
            this.ItemForIsParent.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsParent.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.accountTypeGridLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem1.Text = "Account Type";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.currencyGridLookUpEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem2.Text = "Currency";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(288, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(288, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.logInfoControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 213);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 52);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(460, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(576, 52);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "AccountView";
            this.Size = new System.Drawing.Size(596, 285);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrenciesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCurrencyGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCurrencyGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsParentCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Controls.LookUpEditors.AccountTypeGridLookUpEdit accountTypeGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView accountTypeGridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit AccountNumberTextEdit;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit AccountNameTextEdit;
        private DevExpress.XtraGrid.GridControl CurrenciesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit IsParentCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrencies;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsParent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Controls.LookUpEditors.RepositoryItemCurrencyGridLookUpEdit repositoryItemCurrencyGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemCurrencyGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private Controls.LookUpEditors.CurrencyGridLookUpEdit currencyGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView currencyGridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Controls.LogInfoControl logInfoControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
    }
}
