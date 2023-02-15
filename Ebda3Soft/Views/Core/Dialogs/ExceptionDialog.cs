using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Views.Core.Dialogs
{
    public partial class ExceptionDialog : DevExpress.XtraEditors.XtraForm
    {
        public static DialogResult Show(Exception exception)
        {
            return new ExceptionDialog(exception).ShowDialog();
        }
        public ExceptionDialog(Exception ex)
        {
            InitializeComponent();
            MessageTextEdit.EditValue = ex.Message;
            DetailsTextEdit.EditValue = ex.ToString();
        }

        private void SendReportButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}