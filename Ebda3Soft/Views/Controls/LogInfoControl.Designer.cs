
namespace Ebda3Soft.Views.Controls
{
    partial class LogInfoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInfoControl));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtEdits = new DevExpress.XtraEditors.TextEdit();
            this.PrintsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtAddedBy = new DevExpress.XtraEditors.TextEdit();
            this.txtAddDate = new DevExpress.XtraEditors.TextEdit();
            this.txtLastEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtLastPrint = new DevExpress.XtraEditors.TextEdit();
            this.txtLastEditBy = new DevExpress.XtraEditors.TextEdit();
            this.txtLastPrintBy = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrints = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUpdates = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastEditBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPrintBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            resources.ApplyResources(this.dataLayoutControl1, "dataLayoutControl1");
            this.dataLayoutControl1.Controls.Add(this.txtEdits);
            this.dataLayoutControl1.Controls.Add(this.PrintsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.txtAddedBy);
            this.dataLayoutControl1.Controls.Add(this.txtAddDate);
            this.dataLayoutControl1.Controls.Add(this.txtLastEdit);
            this.dataLayoutControl1.Controls.Add(this.txtLastPrint);
            this.dataLayoutControl1.Controls.Add(this.txtLastEditBy);
            this.dataLayoutControl1.Controls.Add(this.txtLastPrintBy);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            // 
            // txtEdits
            // 
            resources.ApplyResources(this.txtEdits, "txtEdits");
            this.txtEdits.Name = "txtEdits";
            this.txtEdits.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtEdits.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEdits.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEdits.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtEdits.Properties.Mask.UseMaskAsDisplayFormat")));
            this.txtEdits.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEdits.Properties.MaskSettings.Set("mask", "N0");
            this.txtEdits.Properties.ReadOnly = true;
            this.txtEdits.StyleController = this.dataLayoutControl1;
            // 
            // PrintsTextEdit
            // 
            resources.ApplyResources(this.PrintsTextEdit, "PrintsTextEdit");
            this.PrintsTextEdit.Name = "PrintsTextEdit";
            this.PrintsTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.PrintsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PrintsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrintsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("PrintsTextEdit.Properties.Mask.UseMaskAsDisplayFormat")));
            this.PrintsTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.PrintsTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.PrintsTextEdit.Properties.ReadOnly = true;
            this.PrintsTextEdit.StyleController = this.dataLayoutControl1;
            // 
            // txtAddedBy
            // 
            resources.ApplyResources(this.txtAddedBy, "txtAddedBy");
            this.txtAddedBy.Name = "txtAddedBy";
            this.txtAddedBy.Properties.ReadOnly = true;
            this.txtAddedBy.StyleController = this.dataLayoutControl1;
            // 
            // txtAddDate
            // 
            resources.ApplyResources(this.txtAddDate, "txtAddDate");
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.Properties.ReadOnly = true;
            this.txtAddDate.StyleController = this.dataLayoutControl1;
            // 
            // txtLastEdit
            // 
            resources.ApplyResources(this.txtLastEdit, "txtLastEdit");
            this.txtLastEdit.Name = "txtLastEdit";
            this.txtLastEdit.Properties.ReadOnly = true;
            this.txtLastEdit.StyleController = this.dataLayoutControl1;
            // 
            // txtLastPrint
            // 
            resources.ApplyResources(this.txtLastPrint, "txtLastPrint");
            this.txtLastPrint.Name = "txtLastPrint";
            this.txtLastPrint.Properties.ReadOnly = true;
            this.txtLastPrint.StyleController = this.dataLayoutControl1;
            // 
            // txtLastEditBy
            // 
            resources.ApplyResources(this.txtLastEditBy, "txtLastEditBy");
            this.txtLastEditBy.Name = "txtLastEditBy";
            this.txtLastEditBy.Properties.ReadOnly = true;
            this.txtLastEditBy.StyleController = this.dataLayoutControl1;
            // 
            // txtLastPrintBy
            // 
            resources.ApplyResources(this.txtLastPrintBy, "txtLastPrintBy");
            this.txtLastPrintBy.Name = "txtLastPrintBy";
            this.txtLastPrintBy.Properties.ReadOnly = true;
            this.txtLastPrintBy.StyleController = this.dataLayoutControl1;
            // 
            // Root
            // 
            resources.ApplyResources(this.Root, "Root");
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(597, 48);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.ItemForPrints,
            this.ItemForUpdates,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.txt,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(597, 48);
            // 
            // layoutControlItem1
            // 
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Control = this.txtAddedBy;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForPrints
            // 
            resources.ApplyResources(this.ItemForPrints, "ItemForPrints");
            this.ItemForPrints.Control = this.PrintsTextEdit;
            this.ItemForPrints.Location = new System.Drawing.Point(447, 0);
            this.ItemForPrints.Name = "ItemForPrints";
            this.ItemForPrints.Size = new System.Drawing.Size(150, 24);
            this.ItemForPrints.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForUpdates
            // 
            resources.ApplyResources(this.ItemForUpdates, "ItemForUpdates");
            this.ItemForUpdates.Control = this.txtEdits;
            this.ItemForUpdates.Location = new System.Drawing.Point(298, 0);
            this.ItemForUpdates.Name = "ItemForUpdates";
            this.ItemForUpdates.Size = new System.Drawing.Size(149, 24);
            this.ItemForUpdates.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Control = this.txtAddDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(149, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem5
            // 
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Control = this.txtLastEditBy;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem6
            // 
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.Control = this.txtLastPrintBy;
            this.layoutControlItem6.Location = new System.Drawing.Point(298, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 13);
            // 
            // txt
            // 
            resources.ApplyResources(this.txt, "txt");
            this.txt.Control = this.txtLastPrint;
            this.txt.Location = new System.Drawing.Point(447, 24);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(150, 24);
            this.txt.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem3
            // 
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.Control = this.txtLastEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(149, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
            // 
            // LogInfoControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "LogInfoControl";
            this.Load += new System.EventHandler(this.TransactionLogInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastEditBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastPrintBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txtEdits;
        private DevExpress.XtraEditors.TextEdit PrintsTextEdit;
        private DevExpress.XtraEditors.TextEdit txtAddedBy;
        private DevExpress.XtraEditors.TextEdit txtAddDate;
        private DevExpress.XtraEditors.TextEdit txtLastEdit;
        private DevExpress.XtraEditors.TextEdit txtLastPrint;
        private DevExpress.XtraEditors.TextEdit txtLastEditBy;
        private DevExpress.XtraEditors.TextEdit txtLastPrintBy;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem txt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUpdates;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrints;
    }
}
