
namespace Ebda3Soft.Views.Core.Dialogs
{
    partial class ExceptionDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionDialog));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SendReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.DetailsTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.MessageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.SendReportButton);
            this.layoutControl1.Controls.Add(this.CancelButton);
            this.layoutControl1.Controls.Add(this.DetailsTextEdit);
            this.layoutControl1.Controls.Add(this.MessageTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(444, 317);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SendReportButton
            // 
            this.SendReportButton.Location = new System.Drawing.Point(294, 283);
            this.SendReportButton.Name = "SendReportButton";
            this.SendReportButton.Size = new System.Drawing.Size(138, 22);
            this.SendReportButton.StyleController = this.layoutControl1;
            this.SendReportButton.TabIndex = 7;
            this.SendReportButton.Text = "Send Report";
            this.SendReportButton.Click += new System.EventHandler(this.SendReportButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(153, 283);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(137, 22);
            this.CancelButton.StyleController = this.layoutControl1;
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DetailsTextEdit
            // 
            this.DetailsTextEdit.Location = new System.Drawing.Point(12, 165);
            this.DetailsTextEdit.Name = "DetailsTextEdit";
            this.DetailsTextEdit.Properties.ReadOnly = true;
            this.DetailsTextEdit.Size = new System.Drawing.Size(420, 114);
            this.DetailsTextEdit.StyleController = this.layoutControl1;
            this.DetailsTextEdit.TabIndex = 5;
            // 
            // MessageTextEdit
            // 
            this.MessageTextEdit.Location = new System.Drawing.Point(106, 125);
            this.MessageTextEdit.Name = "MessageTextEdit";
            this.MessageTextEdit.Properties.ReadOnly = true;
            this.MessageTextEdit.Size = new System.Drawing.Size(326, 20);
            this.MessageTextEdit.StyleController = this.layoutControl1;
            this.MessageTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(444, 317);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.MessageTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 113);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(424, 24);
            this.layoutControlItem1.Text = "Message";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DetailsTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 137);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(424, 134);
            this.layoutControlItem2.Text = "Exception Details";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CancelButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(141, 271);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(141, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.SendReportButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(282, 271);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 271);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(141, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.Caption.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Caption.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.pictureEdit1.Properties.Caption.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Caption.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.Caption.Offset = new System.Drawing.Point(10, 0);
            this.pictureEdit1.Properties.Caption.Text = "We are sorry";
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SvgImageSize = new System.Drawing.Size(84, 84);
            this.pictureEdit1.Size = new System.Drawing.Size(420, 109);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pictureEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(424, 113);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ExceptionDialog
            // 
            this.AcceptButton = this.SendReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 317);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::Ebda3Soft.Properties.Resources.highimportance;
            this.Name = "ExceptionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We are sorry";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton SendReportButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.MemoEdit DetailsTextEdit;
        private DevExpress.XtraEditors.TextEdit MessageTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}