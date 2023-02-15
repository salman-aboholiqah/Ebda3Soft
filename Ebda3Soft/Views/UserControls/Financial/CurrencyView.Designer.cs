
namespace Ebda3Soft.Views.UserControls.Financial
{
    partial class CurrencyView
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CurrencyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubCurrencyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountOfDecimalsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsLocalCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.AccountsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCurrencyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsLocal = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccounts = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountOfDecimals = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSubCurrencyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ShortCutTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForShortCut = new DevExpress.XtraLayout.LayoutControlItem();
            this.SignTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForSign = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubCurrencyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDecimalsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLocalCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrencyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountOfDecimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubCurrencyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortCutTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSign)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CurrencyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SubCurrencyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountOfDecimalsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsLocalCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.AccountsGridControl);
            this.dataLayoutControl1.Controls.Add(this.ShortCutTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SignTextEdit);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(521, 233);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CurrencyNameTextEdit
            // 
            this.CurrencyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CurrencyName", true));
            this.CurrencyNameTextEdit.Location = new System.Drawing.Point(119, 12);
            this.CurrencyNameTextEdit.Name = "CurrencyNameTextEdit";
            this.CurrencyNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.CurrencyNameTextEdit.Size = new System.Drawing.Size(139, 20);
            this.CurrencyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrencyNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Financial.Currency);
            // 
            // SubCurrencyNameTextEdit
            // 
            this.SubCurrencyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "SubCurrencyName", true));
            this.SubCurrencyNameTextEdit.Location = new System.Drawing.Point(369, 12);
            this.SubCurrencyNameTextEdit.Name = "SubCurrencyNameTextEdit";
            this.SubCurrencyNameTextEdit.Size = new System.Drawing.Size(140, 20);
            this.SubCurrencyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.SubCurrencyNameTextEdit.TabIndex = 5;
            // 
            // CountOfDecimalsTextEdit
            // 
            this.CountOfDecimalsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CountOfDecimals", true));
            this.CountOfDecimalsTextEdit.Location = new System.Drawing.Point(369, 36);
            this.CountOfDecimalsTextEdit.Name = "CountOfDecimalsTextEdit";
            this.CountOfDecimalsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CountOfDecimalsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CountOfDecimalsTextEdit.Properties.Mask.EditMask = "G";
            this.CountOfDecimalsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CountOfDecimalsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CountOfDecimalsTextEdit.Size = new System.Drawing.Size(140, 20);
            this.CountOfDecimalsTextEdit.StyleController = this.dataLayoutControl1;
            this.CountOfDecimalsTextEdit.TabIndex = 6;
            // 
            // IsLocalCheckEdit
            // 
            this.IsLocalCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsLocal", true));
            this.IsLocalCheckEdit.Location = new System.Drawing.Point(12, 36);
            this.IsLocalCheckEdit.Name = "IsLocalCheckEdit";
            this.IsLocalCheckEdit.Properties.Caption = "Is Local";
            this.IsLocalCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsLocalCheckEdit.Size = new System.Drawing.Size(246, 20);
            this.IsLocalCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsLocalCheckEdit.TabIndex = 7;
            // 
            // AccountsGridControl
            // 
            this.AccountsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Accounts", true));
            this.AccountsGridControl.Location = new System.Drawing.Point(12, 84);
            this.AccountsGridControl.MainView = this.gridView1;
            this.AccountsGridControl.Name = "AccountsGridControl";
            this.AccountsGridControl.Size = new System.Drawing.Size(497, 137);
            this.AccountsGridControl.TabIndex = 8;
            this.AccountsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.AccountsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(521, 233);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCurrencyName,
            this.ItemForIsLocal,
            this.ItemForCountOfDecimals,
            this.ItemForSubCurrencyName,
            this.ItemForShortCut,
            this.ItemForSign,
            this.ItemForAccounts});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(501, 213);
            // 
            // ItemForCurrencyName
            // 
            this.ItemForCurrencyName.Control = this.CurrencyNameTextEdit;
            this.ItemForCurrencyName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCurrencyName.Name = "ItemForCurrencyName";
            this.ItemForCurrencyName.Size = new System.Drawing.Size(250, 24);
            this.ItemForCurrencyName.Text = "Currency Name";
            this.ItemForCurrencyName.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ItemForIsLocal
            // 
            this.ItemForIsLocal.Control = this.IsLocalCheckEdit;
            this.ItemForIsLocal.Location = new System.Drawing.Point(0, 24);
            this.ItemForIsLocal.Name = "ItemForIsLocal";
            this.ItemForIsLocal.Size = new System.Drawing.Size(250, 24);
            this.ItemForIsLocal.Text = "Is Local";
            this.ItemForIsLocal.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsLocal.TextVisible = false;
            // 
            // ItemForAccounts
            // 
            this.ItemForAccounts.Control = this.AccountsGridControl;
            this.ItemForAccounts.Location = new System.Drawing.Point(0, 72);
            this.ItemForAccounts.Name = "ItemForAccounts";
            this.ItemForAccounts.Size = new System.Drawing.Size(501, 141);
            this.ItemForAccounts.StartNewLine = true;
            this.ItemForAccounts.Text = "Accounts";
            this.ItemForAccounts.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForAccounts.TextVisible = false;
            // 
            // ItemForCountOfDecimals
            // 
            this.ItemForCountOfDecimals.Control = this.CountOfDecimalsTextEdit;
            this.ItemForCountOfDecimals.Location = new System.Drawing.Point(250, 24);
            this.ItemForCountOfDecimals.Name = "ItemForCountOfDecimals";
            this.ItemForCountOfDecimals.Size = new System.Drawing.Size(251, 24);
            this.ItemForCountOfDecimals.Text = "Count Of Decimals";
            this.ItemForCountOfDecimals.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ItemForSubCurrencyName
            // 
            this.ItemForSubCurrencyName.Control = this.SubCurrencyNameTextEdit;
            this.ItemForSubCurrencyName.Location = new System.Drawing.Point(250, 0);
            this.ItemForSubCurrencyName.Name = "ItemForSubCurrencyName";
            this.ItemForSubCurrencyName.Size = new System.Drawing.Size(251, 24);
            this.ItemForSubCurrencyName.Text = "Sub Currency Name";
            this.ItemForSubCurrencyName.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ShortCutTextEdit
            // 
            this.ShortCutTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "ShortCut", true));
            this.ShortCutTextEdit.Location = new System.Drawing.Point(119, 60);
            this.ShortCutTextEdit.Name = "ShortCutTextEdit";
            this.ShortCutTextEdit.Size = new System.Drawing.Size(139, 20);
            this.ShortCutTextEdit.StyleController = this.dataLayoutControl1;
            this.ShortCutTextEdit.TabIndex = 9;
            // 
            // ItemForShortCut
            // 
            this.ItemForShortCut.Control = this.ShortCutTextEdit;
            this.ItemForShortCut.Location = new System.Drawing.Point(0, 48);
            this.ItemForShortCut.Name = "ItemForShortCut";
            this.ItemForShortCut.Size = new System.Drawing.Size(250, 24);
            this.ItemForShortCut.Text = "Short Cut";
            this.ItemForShortCut.TextSize = new System.Drawing.Size(95, 13);
            // 
            // SignTextEdit
            // 
            this.SignTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Sign", true));
            this.SignTextEdit.Location = new System.Drawing.Point(369, 60);
            this.SignTextEdit.Name = "SignTextEdit";
            this.SignTextEdit.Size = new System.Drawing.Size(140, 20);
            this.SignTextEdit.StyleController = this.dataLayoutControl1;
            this.SignTextEdit.TabIndex = 10;
            // 
            // ItemForSign
            // 
            this.ItemForSign.Control = this.SignTextEdit;
            this.ItemForSign.Location = new System.Drawing.Point(250, 48);
            this.ItemForSign.Name = "ItemForSign";
            this.ItemForSign.Size = new System.Drawing.Size(251, 24);
            this.ItemForSign.Text = "Sign";
            this.ItemForSign.TextSize = new System.Drawing.Size(95, 13);
            // 
            // CurrencyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "CurrencyView";
            this.Size = new System.Drawing.Size(521, 233);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubCurrencyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDecimalsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLocalCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrencyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountOfDecimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubCurrencyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortCutTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit CurrencyNameTextEdit;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit SubCurrencyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CountOfDecimalsTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsLocalCheckEdit;
        private DevExpress.XtraGrid.GridControl AccountsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrencyName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsLocal;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccounts;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountOfDecimals;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubCurrencyName;
        private DevExpress.XtraEditors.TextEdit ShortCutTextEdit;
        private DevExpress.XtraEditors.TextEdit SignTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShortCut;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSign;
    }
}
