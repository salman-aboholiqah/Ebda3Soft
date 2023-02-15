﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core;
using DevExpress.XtraBars.Docking2010.Customization;
using Ebda3Soft.Core.Database.Interfaces;

namespace Ebda3Soft.Views.UserControls.GeneralSettings
{
    public partial class UserCollectionView : DevExpress.XtraEditors.XtraUserControl, ISupportCollectionActions
    {
        SQLServerDbContext dbContext;
        public UserCollectionView()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = SQLServerDbContext.Instance;
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            RefreshData();            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public void RefreshData()
        {
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                bindingSource.DataSource = dbContext.Users.Local.ToBindingList();
                bsiRecordsCount.Caption = "RECORDS : " + bindingSource.Count;

            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void New()
        {
            SharedView.ShowUserControlForm(new UserView(bindingSource, Ebda3Soft.Core.Enums.TransactionType.Adding));
        }

        public void Delete()
        {
            if(!IsReadyToDelete())
                return;
            var entity = gridView.GetFocusedRow();
            if (entity != null)
            {
                var message = $"Do yout want delete {(entity as IMemberable).DisplayMember}";
                var result = FlyoutDialog.Show(this.ParentForm, "Delete", message, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SharedActions.Save(entity, Ebda3Soft.Core.Enums.TransactionType.Deleting, this.ParentForm);
                    bindingSource.Remove(entity);
                }
            }
        }

        public bool IsReadyToEdit()
        {
            return gridView.GetFocusedRow() != null;
        }
        public void Edit()
        {
            if (IsReadyToEdit())
                SharedView.ShowUserControlForm(new UserView(bindingSource, Ebda3Soft.Core.Enums.TransactionType.Modifying));
        }

        private void UserCollectionView_Load(object sender, EventArgs e)
        {
            bbiDelete.ItemClick += (o, ev) => Delete();
            bbiNew.ItemClick += (o, ev) => New();
            bbiEdit.ItemClick += (o, ev) => Edit();
            bbiRefresh.ItemClick += (o, ev) => RefreshData();
            gridView.RowClick += (o, ev) =>
            {
                if (ev.Clicks == 2)
                    Edit();
            };
        }

        public bool IsReadyToDelete()
        {
            return true;
        }
    }
}
