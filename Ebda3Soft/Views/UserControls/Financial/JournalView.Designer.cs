
namespace Ebda3Soft.Views.UserControls.Financial
{
    partial class JournalView
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
            this.JournalNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.JournalDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.IsPostedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.JournalPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForJournalNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJournalPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJournalDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsPosted = new DevExpress.XtraLayout.LayoutControlItem();
            this.journalTypeGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.JournalTypeGridLookUpEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTypeGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.currencyGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.CurrencyGridLookUpEdit();
            this.currencyGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountGridLookUpEdit2 = new Ebda3Soft.Views.Controls.LookUpEditors.AccountGridLookUpEdit();
            this.accountGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountGridLookUpEdit1 = new Ebda3Soft.Views.Controls.LookUpEditors.AccountGridLookUpEdit();
            this.accountGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.logInfoControl1 = new Ebda3Soft.Views.Controls.LogInfoControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForDebitAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForCreditAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForJournalType = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsPostedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsPosted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalTypeGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalTypeGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForDebitAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCreditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForJournalType)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.journalTypeGridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.currencyGridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.accountGridLookUpEdit2);
            this.dataLayoutControl1.Controls.Add(this.accountGridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.logInfoControl1);
            this.dataLayoutControl1.Controls.Add(this.JournalNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.JournalDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.IsPostedCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.JournalPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(817, 204);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // JournalNumberTextEdit
            // 
            this.JournalNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalNumber", true));
            this.JournalNumberTextEdit.Location = new System.Drawing.Point(298, 12);
            this.JournalNumberTextEdit.Name = "JournalNumberTextEdit";
            this.JournalNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.JournalNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JournalNumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.JournalNumberTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.JournalNumberTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.JournalNumberTextEdit.Size = new System.Drawing.Size(108, 20);
            this.JournalNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.JournalNumberTextEdit.TabIndex = 4;
            // 
            // JournalDateDateEdit
            // 
            this.JournalDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalDate", true));
            this.JournalDateDateEdit.EditValue = null;
            this.JournalDateDateEdit.Location = new System.Drawing.Point(497, 12);
            this.JournalDateDateEdit.Name = "JournalDateDateEdit";
            this.JournalDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JournalDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JournalDateDateEdit.Size = new System.Drawing.Size(108, 20);
            this.JournalDateDateEdit.StyleController = this.dataLayoutControl1;
            this.JournalDateDateEdit.TabIndex = 5;
            // 
            // IsPostedCheckEdit
            // 
            this.IsPostedCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsPosted", true));
            this.IsPostedCheckEdit.Location = new System.Drawing.Point(609, 12);
            this.IsPostedCheckEdit.Name = "IsPostedCheckEdit";
            this.IsPostedCheckEdit.Properties.Caption = "Is Posted";
            this.IsPostedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsPostedCheckEdit.Size = new System.Drawing.Size(196, 20);
            this.IsPostedCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsPostedCheckEdit.TabIndex = 7;
            // 
            // JournalPriceTextEdit
            // 
            this.JournalPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalPrice", true));
            this.JournalPriceTextEdit.Location = new System.Drawing.Point(99, 120);
            this.JournalPriceTextEdit.Name = "JournalPriceTextEdit";
            this.JournalPriceTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.JournalPriceTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.JournalPriceTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.JournalPriceTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.JournalPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.JournalPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JournalPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.JournalPriceTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.JournalPriceTextEdit.Properties.MaskSettings.Set("mask", "G");
            this.JournalPriceTextEdit.Size = new System.Drawing.Size(307, 20);
            this.JournalPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.JournalPriceTextEdit.TabIndex = 8;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(99, 60);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(706, 56);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(817, 204);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForJournalNumber,
            this.ItemForDescription,
            this.ItemForJournalPrice,
            this.ItemForJournalDate,
            this.ItemForIsPosted,
            this.layoutControlItem1,
            this.itemForDebitAccount,
            this.itemForCreditAccount,
            this.itemForCurrency,
            this.itemForJournalType});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(797, 184);
            // 
            // ItemForJournalNumber
            // 
            this.ItemForJournalNumber.Control = this.JournalNumberTextEdit;
            this.ItemForJournalNumber.Location = new System.Drawing.Point(199, 0);
            this.ItemForJournalNumber.Name = "ItemForJournalNumber";
            this.ItemForJournalNumber.Size = new System.Drawing.Size(199, 24);
            this.ItemForJournalNumber.Text = "Journal Number";
            this.ItemForJournalNumber.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForDescription.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(797, 60);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextLocation = DevExpress.Utils.Locations.Left;
            this.ItemForDescription.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForJournalPrice
            // 
            this.ItemForJournalPrice.Control = this.JournalPriceTextEdit;
            this.ItemForJournalPrice.Location = new System.Drawing.Point(0, 108);
            this.ItemForJournalPrice.Name = "ItemForJournalPrice";
            this.ItemForJournalPrice.Size = new System.Drawing.Size(398, 24);
            this.ItemForJournalPrice.Text = "Journal Price";
            this.ItemForJournalPrice.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForJournalDate
            // 
            this.ItemForJournalDate.Control = this.JournalDateDateEdit;
            this.ItemForJournalDate.Location = new System.Drawing.Point(398, 0);
            this.ItemForJournalDate.Name = "ItemForJournalDate";
            this.ItemForJournalDate.Size = new System.Drawing.Size(199, 24);
            this.ItemForJournalDate.Text = "Journal Date";
            this.ItemForJournalDate.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForIsPosted
            // 
            this.ItemForIsPosted.Control = this.IsPostedCheckEdit;
            this.ItemForIsPosted.Location = new System.Drawing.Point(597, 0);
            this.ItemForIsPosted.Name = "ItemForIsPosted";
            this.ItemForIsPosted.Size = new System.Drawing.Size(200, 24);
            this.ItemForIsPosted.Text = "Is Posted";
            this.ItemForIsPosted.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsPosted.TextVisible = false;
            // 
            // journalTypeGridLookUpEdit1
            // 
            this.journalTypeGridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "JournalTypeID", true));
            this.journalTypeGridLookUpEdit1.Location = new System.Drawing.Point(99, 12);
            this.journalTypeGridLookUpEdit1.Name = "journalTypeGridLookUpEdit1";
            this.journalTypeGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.journalTypeGridLookUpEdit1.Properties.PopupView = this.journalTypeGridLookUpEdit1View;
            this.journalTypeGridLookUpEdit1.Size = new System.Drawing.Size(108, 20);
            this.journalTypeGridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.journalTypeGridLookUpEdit1.TabIndex = 13;
            this.journalTypeGridLookUpEdit1.EditValueChanged += new System.EventHandler(this.journalTypeGridLookUpEdit1_EditValueChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.Financial.Journal);
            // 
            // journalTypeGridLookUpEdit1View
            // 
            this.journalTypeGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.journalTypeGridLookUpEdit1View.Name = "journalTypeGridLookUpEdit1View";
            this.journalTypeGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.journalTypeGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // currencyGridLookUpEdit1
            // 
            this.currencyGridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CurrencyID", true));
            this.currencyGridLookUpEdit1.Location = new System.Drawing.Point(497, 120);
            this.currencyGridLookUpEdit1.Name = "currencyGridLookUpEdit1";
            this.currencyGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyGridLookUpEdit1.Properties.PopupView = this.currencyGridLookUpEdit1View;
            this.currencyGridLookUpEdit1.Size = new System.Drawing.Size(308, 20);
            this.currencyGridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.currencyGridLookUpEdit1.TabIndex = 12;
            // 
            // currencyGridLookUpEdit1View
            // 
            this.currencyGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.currencyGridLookUpEdit1View.Name = "currencyGridLookUpEdit1View";
            this.currencyGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.currencyGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // accountGridLookUpEdit2
            // 
            this.accountGridLookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CreditAccountID", true));
            this.accountGridLookUpEdit2.Location = new System.Drawing.Point(497, 36);
            this.accountGridLookUpEdit2.Name = "accountGridLookUpEdit2";
            this.accountGridLookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.accountGridLookUpEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.accountGridLookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.accountGridLookUpEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.accountGridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountGridLookUpEdit2.Properties.PopupView = this.accountGridLookUpEdit2View;
            this.accountGridLookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.accountGridLookUpEdit2.Size = new System.Drawing.Size(308, 20);
            this.accountGridLookUpEdit2.StyleController = this.dataLayoutControl1;
            this.accountGridLookUpEdit2.TabIndex = 11;
            // 
            // accountGridLookUpEdit2View
            // 
            this.accountGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.accountGridLookUpEdit2View.Name = "accountGridLookUpEdit2View";
            this.accountGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.accountGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // accountGridLookUpEdit1
            // 
            this.accountGridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DebitAccountID", true));
            this.accountGridLookUpEdit1.Location = new System.Drawing.Point(99, 36);
            this.accountGridLookUpEdit1.Name = "accountGridLookUpEdit1";
            this.accountGridLookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.accountGridLookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.accountGridLookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.accountGridLookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.accountGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountGridLookUpEdit1.Properties.PopupView = this.accountGridLookUpEdit1View;
            this.accountGridLookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.accountGridLookUpEdit1.Size = new System.Drawing.Size(307, 20);
            this.accountGridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.accountGridLookUpEdit1.TabIndex = 10;
            // 
            // accountGridLookUpEdit1View
            // 
            this.accountGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.accountGridLookUpEdit1View.Name = "accountGridLookUpEdit1View";
            this.accountGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.accountGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // logInfoControl1
            // 
            this.logInfoControl1.Location = new System.Drawing.Point(12, 144);
            this.logInfoControl1.Name = "logInfoControl1";
            this.logInfoControl1.ReferenceGuid = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.logInfoControl1.Size = new System.Drawing.Size(793, 48);
            this.logInfoControl1.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.logInfoControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 52);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(460, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(797, 52);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // itemForDebitAccount
            // 
            this.itemForDebitAccount.Control = this.accountGridLookUpEdit1;
            this.itemForDebitAccount.Location = new System.Drawing.Point(0, 24);
            this.itemForDebitAccount.Name = "itemForDebitAccount";
            this.itemForDebitAccount.Size = new System.Drawing.Size(398, 24);
            this.itemForDebitAccount.Text = "Debit Account";
            this.itemForDebitAccount.TextSize = new System.Drawing.Size(75, 13);
            // 
            // itemForCreditAccount
            // 
            this.itemForCreditAccount.Control = this.accountGridLookUpEdit2;
            this.itemForCreditAccount.Location = new System.Drawing.Point(398, 24);
            this.itemForCreditAccount.Name = "itemForCreditAccount";
            this.itemForCreditAccount.Size = new System.Drawing.Size(399, 24);
            this.itemForCreditAccount.Text = "Credit Account";
            this.itemForCreditAccount.TextSize = new System.Drawing.Size(75, 13);
            // 
            // itemForCurrency
            // 
            this.itemForCurrency.Control = this.currencyGridLookUpEdit1;
            this.itemForCurrency.Location = new System.Drawing.Point(398, 108);
            this.itemForCurrency.Name = "itemForCurrency";
            this.itemForCurrency.Size = new System.Drawing.Size(399, 24);
            this.itemForCurrency.Text = "Currency";
            this.itemForCurrency.TextSize = new System.Drawing.Size(75, 13);
            // 
            // itemForJournalType
            // 
            this.itemForJournalType.Control = this.journalTypeGridLookUpEdit1;
            this.itemForJournalType.Location = new System.Drawing.Point(0, 0);
            this.itemForJournalType.Name = "itemForJournalType";
            this.itemForJournalType.Size = new System.Drawing.Size(199, 24);
            this.itemForJournalType.Text = "Journal Type";
            this.itemForJournalType.TextSize = new System.Drawing.Size(75, 13);
            // 
            // JournalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "JournalView";
            this.Size = new System.Drawing.Size(817, 204);
            this.Tag = "";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JournalNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsPostedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJournalDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsPosted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalTypeGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalTypeGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForDebitAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCreditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForJournalType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit JournalNumberTextEdit;
        private DevExpress.XtraEditors.DateEdit JournalDateDateEdit;
        private DevExpress.XtraEditors.CheckEdit IsPostedCheckEdit;
        private DevExpress.XtraEditors.TextEdit JournalPriceTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournalNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournalDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsPosted;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJournalPrice;
        private Controls.LookUpEditors.JournalTypeGridLookUpEdit journalTypeGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView journalTypeGridLookUpEdit1View;
        private Controls.LookUpEditors.CurrencyGridLookUpEdit currencyGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView currencyGridLookUpEdit1View;
        private Controls.LookUpEditors.AccountGridLookUpEdit accountGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView accountGridLookUpEdit2View;
        private Controls.LookUpEditors.AccountGridLookUpEdit accountGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView accountGridLookUpEdit1View;
        private Controls.LogInfoControl logInfoControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem itemForDebitAccount;
        private DevExpress.XtraLayout.LayoutControlItem itemForCreditAccount;
        private DevExpress.XtraLayout.LayoutControlItem itemForCurrency;
        private DevExpress.XtraLayout.LayoutControlItem itemForJournalType;
        private DevExpress.XtraEditors.MemoEdit DescriptionTextEdit;
    }
}
