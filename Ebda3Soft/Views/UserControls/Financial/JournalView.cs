﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Core.Database.Entities.Financial;

namespace Ebda3Soft.Views.UserControls.Financial
{
    public partial class JournalView : XtraUserControl, IEntityControl
    {
        private SQLServerDbContext dbContext;
        private readonly BindingSource bindingSource1;
        private TransactionType transactionType;
        private readonly Ebda3Soft.Core.Enums.JournalView journalView;

        public BaseEntity BaseEntity { get; set; }
        public JournalView(BindingSource bindingSource, TransactionType transactionType, Ebda3Soft.Core.Enums.JournalView journalView)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = SQLServerDbContext.Instance;
            // Call the Load method to get the data for the given DbSet from the database.
            this.bindingSource.DataSource = bindingSource;
            this.bindingSource.Position = bindingSource.Position;
            bindingSource1 = bindingSource;
            this.transactionType = transactionType;
            this.journalView = journalView;
            BaseEntity = bindingSource.Current as BaseEntity;
            //BaseEntity.DataLayoutControl = dataLayoutControl1;
            if (BaseEntity != null)
            {
                InitBaseEntity();
            }
            if (this.transactionType == TransactionType.Adding)
            {
                if (BaseEntity == null)
                {
                    bindingSource.AddNew();
                    BaseEntity = bindingSource.Current as BaseEntity;
                    InitBaseEntity();
                }
                else
                {
                    BaseEntity.New();
                    //InitBaseEntity();
                }
            }
            journalTypeGridLookUpEdit1.Properties.DataSource = new BindingSource(dbContext.JournalTypes.Where(a => a.JournalForm == journalView).ToList(), "");
            dataLayoutControl1.DataSource = BaseEntity.BindingSource;
        }
        public void InitBaseEntity()
        {
            BaseEntity.Validation = null;
            BaseEntity.Validation += dataLayoutControl1.Validate;

            BaseEntity.BindingSource = new BindingSource();
            BaseEntity.BindingSource = bindingSource;
            BaseEntity.TransactionType = transactionType;


            BaseEntity.BeforeSave += (e) =>
            {
                logInfoControl1.Focus();
            };
            BaseEntity.InitNew += AutoNumbering;
        }
        private void AutoNumbering(BaseEntity e)
        {
            var journal = e.CurrentEntity as Journal;
            if (journal != null)
            {
                var journalType = journalTypeGridLookUpEdit1.GetSelectedDataRow() as JournalType;
                if (journalType != null)
                    journal.JournalNumber = dbContext.Journals.Where(j => j.JournalTypeID == journalType.JournalTypeID)?.Max(a => (long?)a.JournalNumber) + 1 ?? 1;
            }
        }

        private void journalTypeGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (transactionType == TransactionType.Adding)
            {
                AutoNumbering(BaseEntity.CurrentEntity);
            }
        }
    }
}
