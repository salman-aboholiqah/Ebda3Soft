
namespace Ebda3Soft.Views.UserControls.GeneralSettings
{
    partial class UserView
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
            this.ConfirmPasswordEditText = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LoginIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PlainTextTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsSuperAdminCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.IsAdminCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.UserViewsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colViewInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsSuperAdmin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUserViews = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPlainText = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsAdmin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLoginID = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForConfirmPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblChangePasswordHint = new DevExpress.XtraEditors.LabelControl();
            this.itemForPasswordHint = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordEditText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlainTextTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSuperAdminCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsAdminCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserViewsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsSuperAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlainText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoginID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForPasswordHint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.lblChangePasswordHint);
            this.dataLayoutControl1.Controls.Add(this.ConfirmPasswordEditText);
            this.dataLayoutControl1.Controls.Add(this.FullNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LoginIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PlainTextTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsSuperAdminCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.IsAdminCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.UserViewsGridControl);
            this.dataLayoutControl1.DataSource = this.bindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(600, 276);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ConfirmPasswordEditText
            // 
            this.ConfirmPasswordEditText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "PasswordConfirmation", true));
            this.ConfirmPasswordEditText.Location = new System.Drawing.Point(397, 36);
            this.ConfirmPasswordEditText.Name = "ConfirmPasswordEditText";
            this.ConfirmPasswordEditText.Properties.UseSystemPasswordChar = true;
            this.ConfirmPasswordEditText.Size = new System.Drawing.Size(191, 20);
            this.ConfirmPasswordEditText.StyleController = this.dataLayoutControl1;
            this.ConfirmPasswordEditText.TabIndex = 10;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Ebda3Soft.Core.Database.Entities.GeneralSettings.User);
            // 
            // FullNameTextEdit
            // 
            this.FullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "FullName", true));
            this.FullNameTextEdit.Location = new System.Drawing.Point(107, 12);
            this.FullNameTextEdit.Name = "FullNameTextEdit";
            this.FullNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.FullNameTextEdit.Size = new System.Drawing.Size(191, 20);
            this.FullNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FullNameTextEdit.TabIndex = 4;
            // 
            // LoginIDTextEdit
            // 
            this.LoginIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "LoginID", true));
            this.LoginIDTextEdit.Location = new System.Drawing.Point(397, 12);
            this.LoginIDTextEdit.Name = "LoginIDTextEdit";
            this.LoginIDTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LoginIDTextEdit.Size = new System.Drawing.Size(191, 20);
            this.LoginIDTextEdit.StyleController = this.dataLayoutControl1;
            this.LoginIDTextEdit.TabIndex = 5;
            // 
            // PlainTextTextEdit
            // 
            this.PlainTextTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "PlainText", true));
            this.PlainTextTextEdit.Location = new System.Drawing.Point(107, 36);
            this.PlainTextTextEdit.Name = "PlainTextTextEdit";
            this.PlainTextTextEdit.Properties.UseSystemPasswordChar = true;
            this.PlainTextTextEdit.Size = new System.Drawing.Size(191, 20);
            this.PlainTextTextEdit.StyleController = this.dataLayoutControl1;
            this.PlainTextTextEdit.TabIndex = 6;
            this.PlainTextTextEdit.DoubleClick += new System.EventHandler(this.PlainTextTextEdit_DoubleClick);
            // 
            // IsSuperAdminCheckEdit
            // 
            this.IsSuperAdminCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsSuperAdmin", true));
            this.IsSuperAdminCheckEdit.Location = new System.Drawing.Point(12, 77);
            this.IsSuperAdminCheckEdit.Name = "IsSuperAdminCheckEdit";
            this.IsSuperAdminCheckEdit.Properties.Caption = "Is Super Admin";
            this.IsSuperAdminCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsSuperAdminCheckEdit.Size = new System.Drawing.Size(286, 20);
            this.IsSuperAdminCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsSuperAdminCheckEdit.TabIndex = 7;
            this.IsSuperAdminCheckEdit.CheckedChanged += new System.EventHandler(this.IsSuperAdminCheckEdit_CheckedChanged);
            // 
            // IsAdminCheckEdit
            // 
            this.IsAdminCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "IsAdmin", true));
            this.IsAdminCheckEdit.Location = new System.Drawing.Point(302, 77);
            this.IsAdminCheckEdit.Name = "IsAdminCheckEdit";
            this.IsAdminCheckEdit.Properties.Caption = "Is Admin";
            this.IsAdminCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsAdminCheckEdit.Size = new System.Drawing.Size(286, 20);
            this.IsAdminCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsAdminCheckEdit.TabIndex = 8;
            // 
            // UserViewsGridControl
            // 
            this.UserViewsGridControl.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "UserViews", true));
            this.UserViewsGridControl.Location = new System.Drawing.Point(12, 101);
            this.UserViewsGridControl.MainView = this.gridView1;
            this.UserViewsGridControl.Name = "UserViewsGridControl";
            this.UserViewsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1});
            this.UserViewsGridControl.Size = new System.Drawing.Size(576, 163);
            this.UserViewsGridControl.TabIndex = 9;
            this.UserViewsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionType,
            this.colViewInfo});
            this.gridView1.GridControl = this.UserViewsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTransactionType
            // 
            this.colTransactionType.ColumnEdit = this.repositoryItemCheckedComboBoxEdit1;
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            this.colTransactionType.Width = 765;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AllowMultiSelect = true;
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // colViewInfo
            // 
            this.colViewInfo.FieldName = "ViewInfo";
            this.colViewInfo.Name = "colViewInfo";
            this.colViewInfo.Visible = true;
            this.colViewInfo.VisibleIndex = 0;
            this.colViewInfo.Width = 306;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(600, 276);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFullName,
            this.ItemForIsSuperAdmin,
            this.ItemForUserViews,
            this.ItemForPlainText,
            this.ItemForIsAdmin,
            this.ItemForLoginID,
            this.itemForConfirmPassword,
            this.itemForPasswordHint});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(580, 256);
            // 
            // ItemForFullName
            // 
            this.ItemForFullName.Control = this.FullNameTextEdit;
            this.ItemForFullName.Location = new System.Drawing.Point(0, 0);
            this.ItemForFullName.Name = "ItemForFullName";
            this.ItemForFullName.Size = new System.Drawing.Size(290, 24);
            this.ItemForFullName.Text = "Full Name";
            this.ItemForFullName.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForIsSuperAdmin
            // 
            this.ItemForIsSuperAdmin.Control = this.IsSuperAdminCheckEdit;
            this.ItemForIsSuperAdmin.Enabled = false;
            this.ItemForIsSuperAdmin.Location = new System.Drawing.Point(0, 65);
            this.ItemForIsSuperAdmin.Name = "ItemForIsSuperAdmin";
            this.ItemForIsSuperAdmin.Size = new System.Drawing.Size(290, 24);
            this.ItemForIsSuperAdmin.Text = "Is Super Admin";
            this.ItemForIsSuperAdmin.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsSuperAdmin.TextVisible = false;
            // 
            // ItemForUserViews
            // 
            this.ItemForUserViews.Control = this.UserViewsGridControl;
            this.ItemForUserViews.Location = new System.Drawing.Point(0, 89);
            this.ItemForUserViews.Name = "ItemForUserViews";
            this.ItemForUserViews.Size = new System.Drawing.Size(580, 167);
            this.ItemForUserViews.StartNewLine = true;
            this.ItemForUserViews.Text = "User Views";
            this.ItemForUserViews.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForUserViews.TextVisible = false;
            // 
            // ItemForPlainText
            // 
            this.ItemForPlainText.Control = this.PlainTextTextEdit;
            this.ItemForPlainText.Location = new System.Drawing.Point(0, 24);
            this.ItemForPlainText.Name = "ItemForPlainText";
            this.ItemForPlainText.Size = new System.Drawing.Size(290, 24);
            this.ItemForPlainText.Text = "Password";
            this.ItemForPlainText.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForIsAdmin
            // 
            this.ItemForIsAdmin.Control = this.IsAdminCheckEdit;
            this.ItemForIsAdmin.Location = new System.Drawing.Point(290, 65);
            this.ItemForIsAdmin.Name = "ItemForIsAdmin";
            this.ItemForIsAdmin.Size = new System.Drawing.Size(290, 24);
            this.ItemForIsAdmin.Text = "Is Admin";
            this.ItemForIsAdmin.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsAdmin.TextVisible = false;
            // 
            // ItemForLoginID
            // 
            this.ItemForLoginID.Control = this.LoginIDTextEdit;
            this.ItemForLoginID.Location = new System.Drawing.Point(290, 0);
            this.ItemForLoginID.Name = "ItemForLoginID";
            this.ItemForLoginID.Size = new System.Drawing.Size(290, 24);
            this.ItemForLoginID.Text = "Login ID";
            this.ItemForLoginID.TextSize = new System.Drawing.Size(83, 13);
            // 
            // itemForConfirmPassword
            // 
            this.itemForConfirmPassword.Control = this.ConfirmPasswordEditText;
            this.itemForConfirmPassword.Location = new System.Drawing.Point(290, 24);
            this.itemForConfirmPassword.Name = "itemForConfirmPassword";
            this.itemForConfirmPassword.Size = new System.Drawing.Size(290, 24);
            this.itemForConfirmPassword.Text = "ConfirmPassword";
            this.itemForConfirmPassword.TextSize = new System.Drawing.Size(83, 13);
            // 
            // lblChangePasswordHint
            // 
            this.lblChangePasswordHint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblChangePasswordHint.Appearance.Options.UseForeColor = true;
            this.lblChangePasswordHint.Location = new System.Drawing.Point(12, 60);
            this.lblChangePasswordHint.Name = "lblChangePasswordHint";
            this.lblChangePasswordHint.Size = new System.Drawing.Size(212, 13);
            this.lblChangePasswordHint.StyleController = this.dataLayoutControl1;
            this.lblChangePasswordHint.TabIndex = 11;
            this.lblChangePasswordHint.Text = "Double Click On Password Field to change it.";
            // 
            // itemForPasswordHint
            // 
            this.itemForPasswordHint.Control = this.lblChangePasswordHint;
            this.itemForPasswordHint.Location = new System.Drawing.Point(0, 48);
            this.itemForPasswordHint.Name = "itemForPasswordHint";
            this.itemForPasswordHint.Size = new System.Drawing.Size(580, 17);
            this.itemForPasswordHint.TextSize = new System.Drawing.Size(0, 0);
            this.itemForPasswordHint.TextVisible = false;
            this.itemForPasswordHint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(600, 276);
            this.Load += new System.EventHandler(this.UserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordEditText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlainTextTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSuperAdminCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsAdminCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserViewsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsSuperAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPlainText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoginID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForPasswordHint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit FullNameTextEdit;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.TextEdit LoginIDTextEdit;
        private DevExpress.XtraEditors.TextEdit PlainTextTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsSuperAdminCheckEdit;
        private DevExpress.XtraEditors.CheckEdit IsAdminCheckEdit;
        private DevExpress.XtraGrid.GridControl UserViewsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLoginID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPlainText;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsSuperAdmin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsAdmin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserViews;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colViewInfo;
        private DevExpress.XtraEditors.TextEdit ConfirmPasswordEditText;
        private DevExpress.XtraLayout.LayoutControlItem itemForConfirmPassword;
        private DevExpress.XtraEditors.LabelControl lblChangePasswordHint;
        private DevExpress.XtraLayout.LayoutControlItem itemForPasswordHint;
    }
}
