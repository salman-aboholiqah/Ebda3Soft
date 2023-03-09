using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Views.Core.Dialogs
{
    public partial class UserControlForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly XtraUserControl control;
        public UserControlForm(XtraUserControl control)
        {
            InitializeComponent();
            string selectedLange = Properties.Settings.Default.Lanuage;
            if (selectedLange == "Arabic")
            {

                RightToLeft
                  = RightToLeft.Yes;
                RightToLeftLayout = true;

            }
            this.control = control;
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(control);
        }

        private void UserControlForm_Load(object sender, EventArgs e)
        {
            var entityControl = control as IEntityControl;

            this.Size = new Size(control.Width, control.Height + mainRibbonControl.Height);
            if (entityControl != null)
            {
                var entity = entityControl.BaseEntity;
                entity.CloseAction = Close;
                bbiSave.ItemClick += (s, ev) => entity.Save();
                bbiSaveAndClose.ItemClick += (s, ev) => entity.SaveAndClose();
                bbiSaveAndNew.ItemClick += (s, ev) => entity.SaveAndNew();
                bbiClose.ItemClick += (s, ev) => entity. Close();
                bbiDelete.ItemClick += (s, ev) => entity.Delete();
                bbiReset.ItemClick += (s, ev) => entity.ResetChanges();
            }

        }

        private void UserControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var entity = control as IEntityControl;
            entity?.BaseEntity?.ResetChanges();
        }
    }
}
