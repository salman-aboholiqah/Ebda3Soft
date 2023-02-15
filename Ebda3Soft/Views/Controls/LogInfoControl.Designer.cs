
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
            this.components = new System.ComponentModel.Container();
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
            this.dataLayoutControl1.Controls.Add(this.txtEdits);
            this.dataLayoutControl1.Controls.Add(this.PrintsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.txtAddedBy);
            this.dataLayoutControl1.Controls.Add(this.txtAddDate);
            this.dataLayoutControl1.Controls.Add(this.txtLastEdit);
            this.dataLayoutControl1.Controls.Add(this.txtLastPrint);
            this.dataLayoutControl1.Controls.Add(this.txtLastEditBy);
            this.dataLayoutControl1.Controls.Add(this.txtLastPrintBy);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(597, 48);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txtEdits
            // 
            this.txtEdits.Location = new System.Drawing.Point(360, 2);
            this.txtEdits.Name = "txtEdits";
            this.txtEdits.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtEdits.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEdits.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEdits.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEdits.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEdits.Properties.MaskSettings.Set("mask", "N0");
            this.txtEdits.Properties.ReadOnly = true;
            this.txtEdits.Size = new System.Drawing.Size(85, 20);
            this.txtEdits.StyleController = this.dataLayoutControl1;
            this.txtEdits.TabIndex = 4;
            // 
            // PrintsTextEdit
            // 
            this.PrintsTextEdit.Location = new System.Drawing.Point(509, 2);
            this.PrintsTextEdit.Name = "PrintsTextEdit";
            this.PrintsTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.PrintsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PrintsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrintsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PrintsTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.PrintsTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.PrintsTextEdit.Properties.ReadOnly = true;
            this.PrintsTextEdit.Size = new System.Drawing.Size(86, 20);
            this.PrintsTextEdit.StyleController = this.dataLayoutControl1;
            this.PrintsTextEdit.TabIndex = 5;
            // 
            // txtAddedBy
            // 
            this.txtAddedBy.Location = new System.Drawing.Point(62, 2);
            this.txtAddedBy.Name = "txtAddedBy";
            this.txtAddedBy.Properties.ReadOnly = true;
            this.txtAddedBy.Size = new System.Drawing.Size(85, 20);
            this.txtAddedBy.StyleController = this.dataLayoutControl1;
            this.txtAddedBy.TabIndex = 6;
            // 
            // txtAddDate
            // 
            this.txtAddDate.Location = new System.Drawing.Point(211, 2);
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.Properties.ReadOnly = true;
            this.txtAddDate.Size = new System.Drawing.Size(85, 20);
            this.txtAddDate.StyleController = this.dataLayoutControl1;
            this.txtAddDate.TabIndex = 7;
            // 
            // txtLastEdit
            // 
            this.txtLastEdit.Location = new System.Drawing.Point(211, 26);
            this.txtLastEdit.Name = "txtLastEdit";
            this.txtLastEdit.Properties.ReadOnly = true;
            this.txtLastEdit.Size = new System.Drawing.Size(85, 20);
            this.txtLastEdit.StyleController = this.dataLayoutControl1;
            this.txtLastEdit.TabIndex = 8;
            // 
            // txtLastPrint
            // 
            this.txtLastPrint.Location = new System.Drawing.Point(509, 26);
            this.txtLastPrint.Name = "txtLastPrint";
            this.txtLastPrint.Properties.ReadOnly = true;
            this.txtLastPrint.Size = new System.Drawing.Size(86, 20);
            this.txtLastPrint.StyleController = this.dataLayoutControl1;
            this.txtLastPrint.TabIndex = 9;
            // 
            // txtLastEditBy
            // 
            this.txtLastEditBy.Location = new System.Drawing.Point(62, 26);
            this.txtLastEditBy.Name = "txtLastEditBy";
            this.txtLastEditBy.Properties.ReadOnly = true;
            this.txtLastEditBy.Size = new System.Drawing.Size(85, 20);
            this.txtLastEditBy.StyleController = this.dataLayoutControl1;
            this.txtLastEditBy.TabIndex = 10;
            // 
            // txtLastPrintBy
            // 
            this.txtLastPrintBy.Location = new System.Drawing.Point(360, 26);
            this.txtLastPrintBy.Name = "txtLastPrintBy";
            this.txtLastPrintBy.Properties.ReadOnly = true;
            this.txtLastPrintBy.Size = new System.Drawing.Size(85, 20);
            this.txtLastPrintBy.StyleController = this.dataLayoutControl1;
            this.txtLastPrintBy.TabIndex = 11;
            // 
            // Root
            // 
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
            this.layoutControlItem1.Control = this.txtAddedBy;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem1.Text = "Added By";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // ItemForPrints
            // 
            this.ItemForPrints.Control = this.PrintsTextEdit;
            this.ItemForPrints.Location = new System.Drawing.Point(447, 0);
            this.ItemForPrints.Name = "ItemForPrints";
            this.ItemForPrints.Size = new System.Drawing.Size(150, 24);
            this.ItemForPrints.Text = "Prints";
            this.ItemForPrints.TextSize = new System.Drawing.Size(48, 13);
            // 
            // ItemForUpdates
            // 
            this.ItemForUpdates.Control = this.txtEdits;
            this.ItemForUpdates.Location = new System.Drawing.Point(298, 0);
            this.ItemForUpdates.Name = "ItemForUpdates";
            this.ItemForUpdates.Size = new System.Drawing.Size(149, 24);
            this.ItemForUpdates.Text = "Edits";
            this.ItemForUpdates.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtAddDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(149, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem2.Text = "DateTime";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtLastEditBy;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem5.Text = "Last Edit";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtLastPrintBy;
            this.layoutControlItem6.Location = new System.Drawing.Point(298, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem6.Text = "Last Print";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txt
            // 
            this.txt.Control = this.txtLastPrint;
            this.txt.Location = new System.Drawing.Point(447, 24);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(150, 24);
            this.txt.Text = "Print Date";
            this.txt.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtLastEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(149, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem3.Text = "Edit Date";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            // 
            // LogInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "LogInfoControl";
            this.Size = new System.Drawing.Size(597, 48);
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
