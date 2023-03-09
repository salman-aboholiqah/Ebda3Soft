
namespace Ebda3Soft.Views.UserControls.Inventory
{
    partial class UnitView
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
            this.logInfoControl1 = new Ebda3Soft.Views.Controls.LogInfoControl();
            this.UnitNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUnitName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItems = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.logInfoControl1);
            this.dataLayoutControl1.Controls.Add(this.UnitNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemsGridControl);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(499, 271);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // logInfoControl1
            // 
            this.logInfoControl1.Location = new System.Drawing.Point(12, 211);
            this.logInfoControl1.Name = "logInfoControl1";
            this.logInfoControl1.ReferenceGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.logInfoControl1.Size = new System.Drawing.Size(475, 48);
            this.logInfoControl1.TabIndex = 6;
            // 
            // UnitNameTextEdit
            // 
            this.UnitNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "UnitName", true));
            this.UnitNameTextEdit.Location = new System.Drawing.Point(73, 12);
            this.UnitNameTextEdit.Name = "UnitNameTextEdit";
            this.UnitNameTextEdit.Size = new System.Drawing.Size(414, 20);
            this.UnitNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Inventory.Unit);
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Items", true));
            this.ItemsGridControl.Location = new System.Drawing.Point(12, 52);
            this.ItemsGridControl.MainView = this.gridView1;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.Size = new System.Drawing.Size(475, 155);
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
            this.Root.Size = new System.Drawing.Size(499, 271);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUnitName,
            this.ItemForItems,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(479, 251);
            // 
            // ItemForUnitName
            // 
            this.ItemForUnitName.Control = this.UnitNameTextEdit;
            this.ItemForUnitName.Location = new System.Drawing.Point(0, 0);
            this.ItemForUnitName.Name = "ItemForUnitName";
            this.ItemForUnitName.Size = new System.Drawing.Size(479, 24);
            this.ItemForUnitName.Text = "Unit Name";
            this.ItemForUnitName.TextSize = new System.Drawing.Size(49, 13);
            // 
            // ItemForItems
            // 
            this.ItemForItems.Control = this.ItemsGridControl;
            this.ItemForItems.Location = new System.Drawing.Point(0, 24);
            this.ItemForItems.Name = "ItemForItems";
            this.ItemForItems.Size = new System.Drawing.Size(479, 175);
            this.ItemForItems.StartNewLine = true;
            this.ItemForItems.Text = "Items";
            this.ItemForItems.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForItems.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.logInfoControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(479, 52);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UnitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "UnitView";
            this.Size = new System.Drawing.Size(499, 271);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bindingSource;
        private Controls.LogInfoControl logInfoControl1;
        private DevExpress.XtraEditors.TextEdit UnitNameTextEdit;
        private DevExpress.XtraGrid.GridControl ItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItems;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
