
namespace Ebda3Soft.Views.UserControls.Financial
{
    partial class AccountTypeView
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
            this.TypeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IsCashCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccounts = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsCash = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsCashCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsCash)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.TypeNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccountsGridControl);
            this.dataLayoutControl1.Controls.Add(this.IsCashCheckEdit);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(566, 286);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // TypeNameTextEdit
            // 
            this.TypeNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TypeName", true));
            this.TypeNameTextEdit.Location = new System.Drawing.Point(78, 12);
            this.TypeNameTextEdit.Name = "TypeNameTextEdit";
            this.TypeNameTextEdit.Size = new System.Drawing.Size(203, 20);
            this.TypeNameTextEdit.StyleController = this.dataLayoutControl1;
            this.TypeNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Financial.AccountType);
            // 
            // AccountsGridControl
            // 
            this.AccountsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Accounts", true));
            this.AccountsGridControl.Location = new System.Drawing.Point(12, 61);
            this.AccountsGridControl.MainView = this.gridView1;
            this.AccountsGridControl.Name = "AccountsGridControl";
            this.AccountsGridControl.Size = new System.Drawing.Size(542, 213);
            this.AccountsGridControl.TabIndex = 5;
            this.AccountsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.AccountsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // IsCashCheckEdit
            // 
            this.IsCashCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsCash", true));
            this.IsCashCheckEdit.Location = new System.Drawing.Point(285, 12);
            this.IsCashCheckEdit.Name = "IsCashCheckEdit";
            this.IsCashCheckEdit.Properties.Caption = "Is Cash";
            this.IsCashCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsCashCheckEdit.Size = new System.Drawing.Size(269, 20);
            this.IsCashCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsCashCheckEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(566, 286);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTypeName,
            this.ItemForAccounts,
            this.ItemForIsCash});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(546, 266);
            // 
            // ItemForTypeName
            // 
            this.ItemForTypeName.Control = this.TypeNameTextEdit;
            this.ItemForTypeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForTypeName.Name = "ItemForTypeName";
            this.ItemForTypeName.Size = new System.Drawing.Size(273, 24);
            this.ItemForTypeName.Text = "Type Name";
            this.ItemForTypeName.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForAccounts
            // 
            this.ItemForAccounts.Control = this.AccountsGridControl;
            this.ItemForAccounts.Location = new System.Drawing.Point(0, 24);
            this.ItemForAccounts.Name = "ItemForAccounts";
            this.ItemForAccounts.Size = new System.Drawing.Size(546, 242);
            this.ItemForAccounts.StartNewLine = true;
            this.ItemForAccounts.Text = "Accounts";
            this.ItemForAccounts.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForAccounts.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForIsCash
            // 
            this.ItemForIsCash.Control = this.IsCashCheckEdit;
            this.ItemForIsCash.Location = new System.Drawing.Point(273, 0);
            this.ItemForIsCash.Name = "ItemForIsCash";
            this.ItemForIsCash.Size = new System.Drawing.Size(273, 24);
            this.ItemForIsCash.Text = "Is Cash";
            this.ItemForIsCash.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsCash.TextVisible = false;
            // 
            // AccountTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "AccountTypeView";
            this.Size = new System.Drawing.Size(566, 286);
            this.Load += new System.EventHandler(this.AccountTypeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsCashCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TypeNameTextEdit;
        private DevExpress.XtraGrid.GridControl AccountsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTypeName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccounts;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.CheckEdit IsCashCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsCash;
    }
}