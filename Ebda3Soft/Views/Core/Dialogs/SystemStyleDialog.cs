using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Views.Core.Dialogs
{
    public partial class SystemStyleDialog : DevExpress.XtraEditors.XtraForm
    {
        public SystemStyleDialog()
        {
            InitializeComponent();
            LoadSettings();
            FontButtonEdit.ButtonClick += fontEdit1_Properties_ButtonClick;
        }
        private void LoadSettings()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures).Where (a => a.Name == "ar" || a.Name == "en");
            foreach (var item in cultures)
            {
                var numbers = "";
                foreach (var number in item.NumberFormat.NativeDigits)
                {
                    numbers += number;
                }
                NumberGroupComboBoxEdit.Properties.Items.Add(numbers);
            }
            
        }

        private void fontEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FontButtonEdit.EditValue = WindowsFormsSettings.DefaultFont;
            if (e.Button .Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var form =  new FontDialog();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FontButtonEdit.EditValue = form.Font;
                }
            }
        }

        private void fontEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var font  = FontButtonEdit.EditValue as Font;
            WindowsFormsSettings.DefaultFont = Font;
            WindowsFormsSettings.LoadApplicationSettings();

            Properties.Settings.Default.DefaultFont = font;
            Properties.Settings.Default.Save();
        }
    }
}