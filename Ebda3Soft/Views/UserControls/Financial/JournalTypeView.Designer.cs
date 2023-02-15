
namespace Ebda3Soft.Views.UserControls.Financial
{
    partial class JournalTypeView
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
            this.JournalTypeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JournalFormImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.JournalsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForJournalTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJournals = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJournalForm = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalTypeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalFormImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.JournalTypeNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.JournalFormImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.JournalsGridControl);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(531, 219);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // JournalTypeNameTextEdit
            // 
            this.JournalTypeNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalTypeName", true));
            this.JournalTypeNameTextEdit.Location = new System.Drawing.Point(116, 12);
            this.JournalTypeNameTextEdit.Name = "JournalTypeNameTextEdit";
            this.JournalTypeNameTextEdit.Size = new System.Drawing.Size(147, 20);
            this.JournalTypeNameTextEdit.StyleController = this.dataLayoutControl1;
            this.JournalTypeNameTextEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Financial.JournalType);
            // 
            // JournalFormImageComboBoxEdit
            // 
            this.JournalFormImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalForm", true));
            this.JournalFormImageComboBoxEdit.Location = new System.Drawing.Point(371, 12);
            this.JournalFormImageComboBoxEdit.Name = "JournalFormImageComboBoxEdit";
            this.JournalFormImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.JournalFormImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JournalFormImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JournalFormImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.JournalFormImageComboBoxEdit.Size = new System.Drawing.Size(148, 20);
            this.JournalFormImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.JournalFormImageComboBoxEdit.TabIndex = 5;
            // 
            // JournalsGridControl
            // 
            this.JournalsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "Journals", true));
            this.JournalsGridControl.Location = new System.Drawing.Point(12, 36);
            this.JournalsGridControl.MainView = this.gridView1;
            this.JournalsGridControl.Name = "JournalsGridControl";
            this.JournalsGridControl.Size = new System.Drawing.Size(507, 171);
            this.JournalsGridControl.TabIndex = 6;
            this.JournalsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.JournalsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(531, 219);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForJournalTypeName,
            this.ItemForJournals,
            this.ItemForJournalForm});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(511, 199);
            // 
            // ItemForJournalTypeName
            // 
            this.ItemForJournalTypeName.Control = this.JournalTypeNameTextEdit;
            this.ItemForJournalTypeName.Location = new System.Drawing.Point(0, 0);
            this.ItemForJournalTypeName.Name = "ItemForJournalTypeName";
            this.ItemForJournalTypeName.Size = new System.Drawing.Size(255, 24);
            this.ItemForJournalTypeName.Text = "Journal Type Name";
            this.ItemForJournalTypeName.TextSize = new System.Drawing.Size(92, 13);
            // 
            // ItemForJournals
            // 
            this.ItemForJournals.Control = this.JournalsGridControl;
            this.ItemForJournals.Location = new System.Drawing.Point(0, 24);
            this.ItemForJournals.Name = "ItemForJournals";
            this.ItemForJournals.Size = new System.Drawing.Size(511, 175);
            this.ItemForJournals.StartNewLine = true;
            this.ItemForJournals.Text = "Journals";
            this.ItemForJournals.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForJournals.TextVisible = false;
            // 
            // ItemForJournalForm
            // 
            this.ItemForJournalForm.Control = this.JournalFormImageComboBoxEdit;
            this.ItemForJournalForm.Location = new System.Drawing.Point(255, 0);
            this.ItemForJournalForm.Name = "ItemForJournalForm";
            this.ItemForJournalForm.Size = new System.Drawing.Size(256, 24);
            this.ItemForJournalForm.Text = "Journal Form";
            this.ItemForJournalForm.TextSize = new System.Drawing.Size(92, 13);
            // 
            // JournalTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "JournalTypeView";
            this.Size = new System.Drawing.Size(531, 219);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JournalTypeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalFormImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit JournalTypeNameTextEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit JournalFormImageComboBoxEdit;
        private DevExpress.XtraGrid.GridControl JournalsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournalTypeName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournalForm;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournals;
    }
}
