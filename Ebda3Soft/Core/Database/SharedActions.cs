using DevExpress.XtraBars.Docking2010.Customization;
using Ebda3Soft.Core.Database.Entities.Financial;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Database.Interfaces;
using Ebda3Soft.Core.Enums;
using Ebda3Soft.Views.Core.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Ebda3Soft.Core.Database
{
    public class SharedActions
    {

        public static bool Save<TEntity>(TEntity entity, TransactionType transactionType, Form parentForm)
        {
            var dbContext = SQLServerDbContext.Instance;
            try
            {
                if (entity != null)
                {
                   
                    ;
                    if (transactionType == TransactionType.Modifying)
                    {
                        dbContext.Entry(entity).State = EntityState.Modified;
                        transactionType = TransactionType.Modifying;
                    }
                    else if(transactionType == TransactionType.Adding)
                    {
                        dbContext.Entry(entity).State = EntityState.Added;
                        transactionType = TransactionType.Adding;
                    }
                    else if(transactionType == TransactionType.Deleting)
                    {
                        var state = dbContext.Entry(entity).State;
                        dbContext.Entry(entity).State = EntityState.Deleted;
                        transactionType = TransactionType.Deleting;
                    }
                    dbContext.SaveChanges();
                    if (transactionType != TransactionType.Deleting)
                    {
                        dbContext.Entry(entity).Reload();
                    }
                    Log(entity, transactionType, parentForm);

                    return true;

                }
            }

            catch (DbEntityValidationException dbExcetion)
            {
                var errors = "\n";
                foreach (var entityError in dbExcetion.EntityValidationErrors)
                {
                    foreach (var error in entityError.ValidationErrors)
                    {
                        errors += error.ErrorMessage + ",";
                    }
                }
                FlyoutDialog.Show(parentForm, "Error", dbExcetion.Message + errors, MessageBoxButtons.OK);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                FlyoutDialog.Show(parentForm, "Error", ex.Message, MessageBoxButtons.OK);
                
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException.HResult == -2146233087)
                {
                    FlyoutDialog.Show(parentForm, "Error", "Cannot Save Duplicated Values", MessageBoxButtons.OK);

                }
                else
                {
                    FlyoutDialog.Show(parentForm, "Error", ex.Message, MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                ExceptionDialog.Show(ex);
            }
            return false;
        }

        public static void Log<T>(T entity, TransactionType transactionType, Form parentForm)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    var dbContext = SQLServerDbContext.Instance;
                    var entityKey = (entity as IMemberable).KeyMember;
                    var previouseID = dbContext.TransactionLogs.Where(t => t.EntityID == entityKey).OrderByDescending(o => o.LogDate).Take(1).FirstOrDefault()?.TransactionLogID;
                    var typeName = entity.GetType().Name;
                    if (typeName.Contains("_"))
                    {
                        typeName = typeName.Split('_')[0];
                    }
                    TransactionLog log = new TransactionLog
                    {
                        UserID = SharedView.User.UserID,
                        LogDate = SQLServerDbContext.GetServerDate(),
                        EntityID = entityKey,
                        EntityType = typeName,
                        DisplayValue = (entity as IMemberable).DisplayMember,
                        PreviousLogID = previouseID,
                        TransactionType = transactionType,
                    };


                    if (entity is IXmlSerializable)
                    {

                        StringBuilder stringBuilder = new StringBuilder();
                        using (XmlWriter writer = XmlWriter.Create(stringBuilder))
                        {
                            (entity as IXmlSerializable).WriteXml(writer);
                            log.EntityData = stringBuilder.ToString();
                            dbContext.TransactionLogs.Add(log);
                            dbContext.Entry(log).State = EntityState.Added;
                            dbContext.SaveChanges();
                        }

                    }
                    //using (MemoryStream ms = new MemoryStream())
                    //{
                    //    var binaryFormatter = new BinaryFormatter();
                    //    binaryFormatter.Serialize(ms, entity);
                    //    log.EntityData = ms.ToArray();
                    //    var account = Restore<T>(ms);

                    //    SetLog(log);
                    //}

                }
                catch (Exception e)
                {
                    ExceptionDialog.Show(e);
                }
            });
        }
        //public static T Restore<T>(Stream stream)
        //{
        //    object deserialized = EntityBackupServices.RestoreDeserialize(stream);//As listed above
        //    if (deserialized.GetType() != this.GetType())
        //        throw new Exception();
        //    foreach (FieldInfo fi in GetType().GetFields())
        //    {
        //        fi.SetValue(this, fi.GetValue(deserialized));
        //    }
        //}

    }
}
