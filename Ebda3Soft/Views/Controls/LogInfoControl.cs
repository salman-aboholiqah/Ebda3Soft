using DevExpress.XtraEditors;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Views.Controls
{
    public partial class LogInfoControl : XtraUserControl
    {
        private Guid referenceGuid;

        public Guid ReferenceGuid
        {
            get => referenceGuid; set
            {
                referenceGuid = value;
            }
        }
        public LogInfoControl()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            var log = new TransactionLogInfo(ReferenceGuid);

            txtAddDate.EditValue = log?.AddLog?.LogDate;
            txtAddedBy.EditValue = log?.AddLog?.User?.FullName;
            txtEdits.EditValue = log?.Updates;
            txtLastEdit.EditValue = log?.LastUpdate?.LogDate;
            txtLastEditBy.EditValue = log?.LastUpdate?.User?.FullName;
            txtLastPrint.EditValue = log?.LastPrint?.LogDate;
            txtLastPrintBy.EditValue = log?.LastPrint?.User?.FullName;
            PrintsTextEdit.EditValue = log?.Prints;
        }
        private void TransactionLogInfoControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadData();
            }
        }
    }
}
