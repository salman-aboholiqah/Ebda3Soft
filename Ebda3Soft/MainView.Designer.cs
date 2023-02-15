
namespace Ebda3Soft
{
    partial class MainView
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAccountTypes = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCurrencies = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUsers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiJournalTypes = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.bbiJournals = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReceipts = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPayments = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCultureSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiUserFullName = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiAccountTypes,
            this.bbiCurrencies,
            this.bbiAccounts,
            this.bbiUsers,
            this.bbiJournalTypes,
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.bbiJournals,
            this.bbiReceipts,
            this.bbiPayments,
            this.bbiCultureSettings});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(895, 161);
            this.ribbonControl1.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbonControl1_Merge);
            // 
            // bbiAccountTypes
            // 
            this.bbiAccountTypes.Caption = "AccountTypes";
            this.bbiAccountTypes.Id = 1;
            this.bbiAccountTypes.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.itemtypestandard;
            this.bbiAccountTypes.Name = "bbiAccountTypes";
            this.bbiAccountTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAccountTypes_ItemClick);
            // 
            // bbiCurrencies
            // 
            this.bbiCurrencies.Caption = "Currencies";
            this.bbiCurrencies.Id = 2;
            this.bbiCurrencies.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.currency;
            this.bbiCurrencies.Name = "bbiCurrencies";
            this.bbiCurrencies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCurrencies_ItemClick);
            // 
            // bbiAccounts
            // 
            this.bbiAccounts.Caption = "Accounts";
            this.bbiAccounts.Id = 3;
            this.bbiAccounts.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.text;
            this.bbiAccounts.Name = "bbiAccounts";
            this.bbiAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAccounts_ItemClick);
            // 
            // bbiUsers
            // 
            this.bbiUsers.Caption = "Users";
            this.bbiUsers.Id = 4;
            this.bbiUsers.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.allowuserstoeditranges;
            this.bbiUsers.Name = "bbiUsers";
            this.bbiUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUsers_ItemClick);
            // 
            // bbiJournalTypes
            // 
            this.bbiJournalTypes.Caption = "Journal Types";
            this.bbiJournalTypes.Id = 5;
            this.bbiJournalTypes.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.printcurrentpage;
            this.bbiJournalTypes.Name = "bbiJournalTypes";
            this.bbiJournalTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiJournalTypes_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 7;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // bbiJournals
            // 
            this.bbiJournals.Caption = "Journals";
            this.bbiJournals.Id = 8;
            this.bbiJournals.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.bo_invoice;
            this.bbiJournals.Name = "bbiJournals";
            this.bbiJournals.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiJournals_ItemClick);
            // 
            // bbiReceipts
            // 
            this.bbiReceipts.Caption = "Receipts";
            this.bbiReceipts.Id = 9;
            this.bbiReceipts.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.indentdecrease;
            this.bbiReceipts.Name = "bbiReceipts";
            this.bbiReceipts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReceipts_ItemClick);
            // 
            // bbiPayments
            // 
            this.bbiPayments.Caption = "Payments";
            this.bbiPayments.Id = 10;
            this.bbiPayments.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.indentincrease;
            this.bbiPayments.Name = "bbiPayments";
            this.bbiPayments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPayments_ItemClick);
            // 
            // bbiCultureSettings
            // 
            this.bbiCultureSettings.Caption = "Culture Settings";
            this.bbiCultureSettings.Id = 11;
            this.bbiCultureSettings.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.language;
            this.bbiCultureSettings.Name = "bbiCultureSettings";
            this.bbiCultureSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCultureSettings_ItemClick);
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.ParentControl = this;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.financial;
            this.ribbonPage1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Financial";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAccountTypes);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCurrencies);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAccounts);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiJournalTypes);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Initialize";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiJournals);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiReceipts);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiPayments);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Transactions";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.fieldsettingspivottable;
            this.ribbonPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "General Settings";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiUsers);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Initialize";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.security_visibility;
            this.ribbonPage3.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "View";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Style";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiCultureSettings);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Culture Settings";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.SnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.FloatDocumentsAlwaysOnTop = DevExpress.Utils.DefaultBoolean.True;
            this.tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.SingleDocument;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiUserFullName});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiUserFullName)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bsiUserFullName
            // 
            this.bsiUserFullName.Id = 0;
            this.bsiUserFullName.ImageOptions.SvgImage = global::Ebda3Soft.Properties.Resources.bo_user;
            this.bsiUserFullName.Name = "bsiUserFullName";
            this.bsiUserFullName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 516);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiAccountTypes;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarButtonItem bbiCurrencies;
        private DevExpress.XtraBars.BarButtonItem bbiAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem bsiUserFullName;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiJournalTypes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem bbiJournals;
        private DevExpress.XtraBars.BarButtonItem bbiReceipts;
        private DevExpress.XtraBars.BarButtonItem bbiPayments;
        private DevExpress.XtraBars.BarButtonItem bbiCultureSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

