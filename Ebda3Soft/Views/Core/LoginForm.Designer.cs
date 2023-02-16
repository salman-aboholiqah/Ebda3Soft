
namespace Ebda3Soft.Views.UserControls
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.LanguageComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LoginIDEditText = new DevExpress.XtraEditors.TextEdit();
            this.PasswordEditText = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit11 = new DevExpress.XtraEditors.CheckEdit();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIDEditText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEditText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.LanguageComboBox);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.LoginIDEditText);
            this.layoutControl1.Controls.Add(this.PasswordEditText);
            this.layoutControl1.Controls.Add(this.checkEdit11);
            this.layoutControl1.Controls.Add(this.LoginButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(491, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(500, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.EditValue = "English";
            this.LanguageComboBox.Location = new System.Drawing.Point(126, 84);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LanguageComboBox.Properties.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.LanguageComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.LanguageComboBox.Size = new System.Drawing.Size(112, 20);
            this.LanguageComboBox.StyleController = this.layoutControl1;
            this.LanguageComboBox.TabIndex = 9;
            // 
            // LoginIDEditText
            // 
            this.LoginIDEditText.EditValue = "";
            this.LoginIDEditText.Location = new System.Drawing.Point(126, 12);
            this.LoginIDEditText.Name = "LoginIDEditText";
            this.LoginIDEditText.Size = new System.Drawing.Size(202, 20);
            this.LoginIDEditText.StyleController = this.layoutControl1;
            this.LoginIDEditText.TabIndex = 4;
            // 
            // PasswordEditText
            // 
            this.PasswordEditText.EditValue = "";
            this.PasswordEditText.Location = new System.Drawing.Point(126, 36);
            this.PasswordEditText.Name = "PasswordEditText";
            this.PasswordEditText.Properties.PasswordChar = '*';
            this.PasswordEditText.Size = new System.Drawing.Size(202, 20);
            this.PasswordEditText.StyleController = this.layoutControl1;
            this.PasswordEditText.TabIndex = 5;
            // 
            // checkEdit11
            // 
            this.checkEdit11.Location = new System.Drawing.Point(12, 60);
            this.checkEdit11.Name = "checkEdit11";
            this.checkEdit11.Properties.Caption = "Save my credintials";
            this.checkEdit11.Size = new System.Drawing.Size(316, 20);
            this.checkEdit11.StyleController = this.layoutControl1;
            this.checkEdit11.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(242, 84);
            this.LoginButton.MaximumSize = new System.Drawing.Size(0, 20);
            this.LoginButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 20);
            this.LoginButton.StyleController = this.layoutControl1;
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Log in";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(500, 118);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.LoginIDEditText;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem1.Text = "User Name (Login ID)";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.PasswordEditText;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(102, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkEdit11;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.LoginButton;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(230, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.LanguageComboBox;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem6.Text = "Language";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(102, 13);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(332, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(156, 94);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pictureEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(160, 98);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 118);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = global::Ebda3Soft.Properties.Resources.security_key;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LanguageComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIDEditText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEditText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit LoginIDEditText;
        private DevExpress.XtraEditors.TextEdit PasswordEditText;
        private DevExpress.XtraEditors.CheckEdit checkEdit11;
        private DevExpress.XtraEditors.SimpleButton LoginButton;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ComboBoxEdit LanguageComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}