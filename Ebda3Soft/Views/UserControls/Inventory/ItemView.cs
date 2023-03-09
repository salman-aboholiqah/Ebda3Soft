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
using Ebda3Soft.Core.Database.Entities.Inventory;
namespace Ebda3Soft.Views.UserControls.Inventory
{
    public partial class ItemView : DevExpress.XtraEditors.XtraUserControl, IEntityControl
    {
        private SQLServerDbContext dbContext;
        private TransactionType transactionType;
        public BaseEntity BaseEntity { get; set; }
        public ItemView(BindingSource bindingSource, TransactionType transactionType)
        {
            InitializeComponent();
            SharedView.SetTranslate(dataLayoutControl1);
            dbContext = SQLServerDbContext.Instance;
            dbContext.ItemTypes.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                ItemTypeGridLookUpEdit.Properties.DataSource = dbContext.ItemTypes.Local.ToBindingList();

            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

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
                    BaseEntity.InitNew += (e) => ItemForUnits.Enabled = false;
                    BaseEntity.New();
                    //InitBaseEntity();

                }
                {
                    var newItem = (BaseEntity.CurrentEntity as Item);
                    newItem.Units = new HashSet<ItemUnit>();
                }

            }
            else
            {
            }
            var item = (BaseEntity.CurrentEntity as Item);
            if (item.Units == null)
                item.Units = new HashSet<ItemUnit>();
            dataLayoutControl1.DataSource = BaseEntity.BindingSource;
            SharedView.SetTranslate(dataLayoutControl1);


            unitBindingSource.DataSource = item.Units.ToList();
            unitBindingSource.AllowNew
                = true;
            UnitsGridControl.DataSource = unitBindingSource;
            logInfoControl1.ReferenceGuid = BaseEntity.KeyMember;


        }
        public void InitBaseEntity()
        {

            BaseEntity.Validation = null;
            BaseEntity.Validation += dataLayoutControl1.Validate;
            BaseEntity.BindingSource = new BindingSource();
            BaseEntity.BindingSource = bindingSource;
            BaseEntity.TransactionType = transactionType;
            BaseEntity.EntitySaved -= (e) => ItemForUnits.Enabled = true;
            BaseEntity.EntitySaved += (e) => ItemForUnits.Enabled = true;
            BaseEntity.BeforeSave -= (e) => ItemForUnits.Enabled = true;
            BaseEntity.BeforeSave += (e) => gridView1.PostEditor();

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, colItemID, BaseEntity.KeyMember);
            var item = (BaseEntity.CurrentEntity as Item);
            var newUnit = gridView1.GetFocusedRow() as ItemUnit;
            if (newUnit != null)
            {
                newUnit.ItemID = item.ItemID;
                item.Units.Add(newUnit);
            }
        }

        private void unitBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            var item = (BaseEntity.CurrentEntity as Item);
            var newUnit = e.NewObject as ItemUnit;
            if (newUnit != null)
            {
                newUnit.ItemID = item.ItemID;
                item.Units.Add(newUnit);
            }
        }
    }
}
