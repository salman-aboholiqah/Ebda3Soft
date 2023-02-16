
namespace Ebda3Soft.Views.Core.Dialogs
{
    partial class UserControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlForm));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            resources.ApplyResources(this.mainRibbonControl, "mainRibbonControl");
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.ExpandCollapseItem.ImageOptions.ImageIndex = ((int)(resources.GetObject("mainRibbonControl.ExpandCollapseItem.ImageOptions.ImageIndex")));
            this.mainRibbonControl.ExpandCollapseItem.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("mainRibbonControl.ExpandCollapseItem.ImageOptions.LargeImageIndex")));
            this.mainRibbonControl.ExpandCollapseItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mainRibbonControl.ExpandCollapseItem.ImageOptions.SvgImage")));
            this.mainRibbonControl.ExpandCollapseItem.SearchTags = resources.GetString("mainRibbonControl.ExpandCollapseItem.SearchTags");
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.mainRibbonControl.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            resources.ApplyResources(this.bbiSave, "bbiSave");
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiSave.ImageOptions.ImageIndex")));
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiSave.ImageOptions.LargeImageIndex")));
            this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            resources.ApplyResources(this.bbiSaveAndClose, "bbiSaveAndClose");
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiSaveAndClose.ImageOptions.ImageIndex")));
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiSaveAndClose.ImageOptions.LargeImageIndex")));
            this.bbiSaveAndClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSaveAndClose.ImageOptions.SvgImage")));
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            resources.ApplyResources(this.bbiSaveAndNew, "bbiSaveAndNew");
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiSaveAndNew.ImageOptions.ImageIndex")));
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiSaveAndNew.ImageOptions.LargeImageIndex")));
            this.bbiSaveAndNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSaveAndNew.ImageOptions.SvgImage")));
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            resources.ApplyResources(this.bbiReset, "bbiReset");
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiReset.ImageOptions.ImageIndex")));
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiReset.ImageOptions.LargeImageIndex")));
            this.bbiReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReset.ImageOptions.SvgImage")));
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            resources.ApplyResources(this.bbiDelete, "bbiDelete");
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiDelete.ImageOptions.ImageIndex")));
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiDelete.ImageOptions.LargeImageIndex")));
            this.bbiDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelete.ImageOptions.SvgImage")));
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            resources.ApplyResources(this.bbiClose, "bbiClose");
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageIndex = ((int)(resources.GetObject("bbiClose.ImageOptions.ImageIndex")));
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("bbiClose.ImageOptions.LargeImageIndex")));
            this.bbiClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiClose.ImageOptions.SvgImage")));
            this.bbiClose.Name = "bbiClose";
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.ParentControl = this;
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            resources.ApplyResources(this.mainRibbonPage, "mainRibbonPage");
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            resources.ApplyResources(this.mainRibbonPageGroup, "mainRibbonPageGroup");
            // 
            // UserControlForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.mainRibbonControl);
            this.IsMdiContainer = true;
            this.Name = "UserControlForm";
            this.Ribbon = this.mainRibbonControl;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserControlForm_FormClosing);
            this.Load += new System.EventHandler(this.UserControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
    }
}