
namespace Ebda3Soft.Views.UserControls.Inventory
{
    partial class ItemTypeView
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
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItems = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.TypeNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemsGridControl);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(590, 240);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TypeNameTextEdit
            // 
            this.TypeNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TypeName", true));
            this.TypeNameTextEdit.Location = new System.Drawing.Point(78, 12);
            this.TypeNameTextEdit.Name = "TypeNameTextEdit";
            this.TypeNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TypeNameTextEdit.Size = new System.Drawing.Size(500, 20);
            this.TypeNameTextEdit.StyleController = this.dataLayoutControl1;
            this.TypeNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Inventory.ItemType);
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Items", true));
            this.ItemsGridControl.Location = new System.Drawing.Point(12, 36);
            this.ItemsGridControl.MainView = this.gridView1;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.Size = new System.Drawing.Size(566, 192);
            this.ItemsGridControl.TabIndex = 5;
            this.ItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ItemsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(590, 240);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTypeName,
            this.ItemForItems});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(570, 220);
            // 
            // ItemForTypeName
            // 
            this.ItemForTypeName.Control = this.TypeNameTextEdit;
            this.ItemForTypeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForTypeName.Name = "ItemForTypeName";
            this.ItemForTypeName.Size = new System.Drawing.Size(570, 24);
            this.ItemForTypeName.Text = "Type Name";
            this.ItemForTypeName.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForItems
            // 
            this.ItemForItems.Control = this.ItemsGridControl;
            this.ItemForItems.Location = new System.Drawing.Point(0, 24);
            this.ItemForItems.Name = "ItemForItems";
            this.ItemForItems.Size = new System.Drawing.Size(570, 196);
            this.ItemForItems.StartNewLine = true;
            this.ItemForItems.Text = "Items";
            this.ItemForItems.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForItems.TextVisible = false;
            // 
            // ItemTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ItemTypeView";
            this.Size = new System.Drawing.Size(590, 240);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit TypeNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTypeName;
        private DevExpress.XtraGrid.GridControl ItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItems;
    }
}
