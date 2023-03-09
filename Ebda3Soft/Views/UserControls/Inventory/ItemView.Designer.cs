
namespace Ebda3Soft.Views.UserControls.Inventory
{
    partial class ItemView
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
            this.ItemNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemTypeGridLookUpEdit = new Ebda3Soft.Views.Controls.LookUpEditors.ItemTypeGridLookUpEdit();
            this.UnitsGridControl = new DevExpress.XtraGrid.GridControl();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemUnitGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.RepositoryItemUnitGridLookUpEdit();
            this.repositoryItemUnitGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnits = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUnitGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUnitGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.logInfoControl1);
            this.dataLayoutControl1.Controls.Add(this.ItemNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemTypeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitsGridControl);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(610, 294);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // logInfoControl1
            // 
            this.logInfoControl1.Location = new System.Drawing.Point(12, 234);
            this.logInfoControl1.Name = "logInfoControl1";
            this.logInfoControl1.ReferenceGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.logInfoControl1.Size = new System.Drawing.Size(586, 48);
            this.logInfoControl1.TabIndex = 8;
            // 
            // ItemNameTextEdit
            // 
            this.ItemNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "ItemName", true));
            this.ItemNameTextEdit.Location = new System.Drawing.Point(381, 12);
            this.ItemNameTextEdit.Name = "ItemNameTextEdit";
            this.ItemNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ItemNameTextEdit.Size = new System.Drawing.Size(217, 20);
            this.ItemNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ItemNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Inventory.Item);
            // 
            // ItemNumberTextEdit
            // 
            this.ItemNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "ItemNumber", true));
            this.ItemNumberTextEdit.Location = new System.Drawing.Point(86, 12);
            this.ItemNumberTextEdit.Name = "ItemNumberTextEdit";
            this.ItemNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ItemNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ItemNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemNumberTextEdit.Properties.Mask.EditMask = "N0";
            this.ItemNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemNumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ItemNumberTextEdit.Size = new System.Drawing.Size(217, 20);
            this.ItemNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.ItemNumberTextEdit.TabIndex = 5;
            // 
            // ItemTypeGridLookUpEdit
            // 
            this.ItemTypeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "ItemTypeID", true));
            this.ItemTypeGridLookUpEdit.Location = new System.Drawing.Point(86, 36);
            this.ItemTypeGridLookUpEdit.Name = "ItemTypeGridLookUpEdit";
            this.ItemTypeGridLookUpEdit.Size = new System.Drawing.Size(512, 20);
            this.ItemTypeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemTypeGridLookUpEdit.TabIndex = 6;
            // 
            // UnitsGridControl
            // 
            this.UnitsGridControl.DataSource = this.unitBindingSource;
            this.UnitsGridControl.Location = new System.Drawing.Point(12, 76);
            this.UnitsGridControl.MainView = this.gridView1;
            this.UnitsGridControl.Name = "UnitsGridControl";
            this.UnitsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemUnitGridLookUpEdit1});
            this.UnitsGridControl.Size = new System.Drawing.Size(586, 154);
            this.UnitsGridControl.TabIndex = 7;
            this.UnitsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Inventory.ItemUnit);
            this.unitBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.unitBindingSource_AddingNew);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnit,
            this.colUnitQuantity,
            this.colPrice,
            this.colCost,
            this.colIsMain,
            this.colItemID});
            this.gridView1.GridControl = this.UnitsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colUnit
            // 
            this.colUnit.ColumnEdit = this.repositoryItemUnitGridLookUpEdit1;
            this.colUnit.FieldName = "UnitID";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 0;
            // 
            // repositoryItemUnitGridLookUpEdit1
            // 
            this.repositoryItemUnitGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemUnitGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemUnitGridLookUpEdit1.Name = "repositoryItemUnitGridLookUpEdit1";
            this.repositoryItemUnitGridLookUpEdit1.PopupView = this.repositoryItemUnitGridLookUpEdit1View;
            // 
            // repositoryItemUnitGridLookUpEdit1View
            // 
            this.repositoryItemUnitGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemUnitGridLookUpEdit1View.Name = "repositoryItemUnitGridLookUpEdit1View";
            this.repositoryItemUnitGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemUnitGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUnitQuantity
            // 
            this.colUnitQuantity.FieldName = "UnitQuantity";
            this.colUnitQuantity.Name = "colUnitQuantity";
            this.colUnitQuantity.Visible = true;
            this.colUnitQuantity.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            // 
            // colIsMain
            // 
            this.colIsMain.FieldName = "IsMain";
            this.colIsMain.Name = "colIsMain";
            this.colIsMain.Visible = true;
            this.colIsMain.VisibleIndex = 4;
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(610, 294);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemName,
            this.ItemForItemType,
            this.ItemForUnits,
            this.ItemForItemNumber,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(590, 274);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameTextEdit;
            this.ItemForItemName.Location = new System.Drawing.Point(295, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Size = new System.Drawing.Size(295, 24);
            this.ItemForItemName.Text = "Item Name";
            this.ItemForItemName.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForItemType
            // 
            this.ItemForItemType.Control = this.ItemTypeGridLookUpEdit;
            this.ItemForItemType.Location = new System.Drawing.Point(0, 24);
            this.ItemForItemType.Name = "ItemForItemType";
            this.ItemForItemType.Size = new System.Drawing.Size(590, 24);
            this.ItemForItemType.Text = "Item Type";
            this.ItemForItemType.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForUnits
            // 
            this.ItemForUnits.Control = this.UnitsGridControl;
            this.ItemForUnits.Location = new System.Drawing.Point(0, 48);
            this.ItemForUnits.Name = "ItemForUnits";
            this.ItemForUnits.Size = new System.Drawing.Size(590, 174);
            this.ItemForUnits.StartNewLine = true;
            this.ItemForUnits.Text = "Units";
            this.ItemForUnits.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForUnits.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForItemNumber
            // 
            this.ItemForItemNumber.Control = this.ItemNumberTextEdit;
            this.ItemForItemNumber.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemNumber.Name = "ItemForItemNumber";
            this.ItemForItemNumber.Size = new System.Drawing.Size(295, 24);
            this.ItemForItemNumber.Text = "Item Number";
            this.ItemForItemNumber.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.logInfoControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(590, 52);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ItemView";
            this.Size = new System.Drawing.Size(610, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUnitGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUnitGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ItemNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ItemNumberTextEdit;
        private Ebda3Soft.Views.Controls.LookUpEditors.ItemTypeGridLookUpEdit ItemTypeGridLookUpEdit;
        private DevExpress.XtraGrid.GridControl UnitsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnits;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemNumber;
        private Controls.LogInfoControl logInfoControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMain;
        private Controls.LookUpEditors.RepositoryItemUnitGridLookUpEdit repositoryItemUnitGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemUnitGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
    }
}
