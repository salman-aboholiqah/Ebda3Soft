using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraDataLayout;
using Ebda3Soft.Core.Database.Interfaces;
using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Ebda3Soft.Core.Database
{
    public abstract class BaseEntity : ISupportEntityActions, IMemberable, IXmlSerializable, IClosable
    {
        //public DataLayoutControl DataLayoutControl;


        public event Action<BaseEntity> EntitySaved;
        public event Action<BaseEntity> InitNew;
        public event Action<BaseEntity> BeforeSave;

        public BindingSource BindingSource;
        public Form ParentForm;
        public TransactionType TransactionType;
        [NotMapped]
        public Action CloseAction { get; set; }
        [NotMapped]
        public Func<bool> Validation { get; set; }
        public abstract string DisplayMember { get; }
        public abstract Guid KeyMember { get; }

        public BaseEntity CurrentEntity { get => BindingSource?.Current as BaseEntity ?? this; }
        public bool Save()
        {
            BeforeSave?.Invoke(BindingSource.Current as BaseEntity);
            if (!IsReadyToSave())
                return false;
            BindingSource.EndEdit();

            var entity = BindingSource.Current;
            if (SharedActions.Save(entity, TransactionType, ParentForm))
            {
                TransactionType = TransactionType.Modifying;
                EntitySaved?.Invoke(entity as BaseEntity);
                return true;
            }
            else
            {
                BindingSource.ResetBindings(true);
            }
            return false;
        }

        public void SaveAndClose()
        {
            if (Save())
                Close();
        }

        public void SaveAndNew()
        {
            if (Save())
                New();
        }

        public void ResetChanges()
        {
            BindingSource.CancelEdit();
            TransactionType = TransactionType.Modifying;
        }
        public virtual bool IsReadyToSave()
        {
            if (Validation?.Invoke() == false)
                return false;
            return true;
        }
        public virtual bool IsReadyToDelete()
        {
            return true;
        }
        public bool Delete()
        {
            if (!IsReadyToDelete())
                return false;

            var entity = BindingSource.Current;
            if (entity != null)
            {
                var message = $"Do yout want delete {(entity as IMemberable).DisplayMember}";
                var result = FlyoutDialog.Show(this.ParentForm, "Delete", message, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (TransactionType == TransactionType.Adding)
                    {
                        Close();
                    }
                    else
                    {
                        if (SharedActions.Save(entity, Ebda3Soft.Core.Enums.TransactionType.Deleting, this.ParentForm))
                        {
                            BindingSource.Remove(entity);
                            return true;
                        }
                    }

                }
            }
            return false;
        }

        public void Close()
        {
            if (TransactionType == TransactionType.Adding)
            {
                BindingSource.RemoveCurrent();

            }
            else if (TransactionType == TransactionType.Modifying)
            {
                BindingSource.CancelEdit();

            }
            var changes = SQLServerDbContext.Instance.ChangeTracker.HasChanges();
            CloseAction?.Invoke();
        }

        public void New()
        {
            BindingSource.AddNew();
            InitNew?.Invoke(CurrentEntity ?? this);
            TransactionType = TransactionType.Adding;

        }
        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return DisplayMember;
        }

        public void WriteXml(XmlWriter writer)
        {
            SharedFormat.WriteXmlFormat(CurrentEntity, writer);
        }
    }
}
