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
using System.Data.Entity;
using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Core;

namespace Ebda3Soft.Views.UserControls.Inventory
{
    public partial class UnitView : DevExpress.XtraEditors.XtraUserControl,IEntityControl
    {
        private SQLServerDbContext dbContext;
        private TransactionType transactionType;
        public BaseEntity BaseEntity { get; set; }
        public UnitView(BindingSource bindingSource, TransactionType transactionType)
        {
            InitializeComponent();

            SharedView.SetTranslate(dataLayoutControl1);


            this.bindingSource.DataSource = bindingSource;
            this.bindingSource.Position = bindingSource.Position;
            this.transactionType = transactionType;
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
            dataLayoutControl1.DataSource = BaseEntity.BindingSource;

            SharedView.SetTranslate(dataLayoutControl1);

            logInfoControl1.ReferenceGuid = BaseEntity.KeyMember;
        }
        public void InitBaseEntity()
        {
            BaseEntity.Validation = null;
            BaseEntity.Validation += dataLayoutControl1.Validate;
            BaseEntity.BindingSource = new BindingSource();
            BaseEntity.BindingSource = bindingSource;
            BaseEntity.TransactionType = transactionType;
        }
    }
}
