using Ebda3Soft.Core.Database;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Models
{
    public class TransactionLogInfo
    {
        private Guid referenceGuid;

        public int? Updates { get; set; }
        public int? Prints { get; set; }
        public TransactionLog AddLog { get; set; }
        public TransactionLog LastUpdate { get; set; }
        public TransactionLog LastPrint { get; set; }
        public TransactionLogInfo(Guid referenceGuid)
        {
            this.referenceGuid = referenceGuid;
            var list = new List<TransactionLog>();

            if (referenceGuid != Guid.Empty)
            {
                list = SQLServerDbContext.Instance.TransactionLogs.Where(t => t.EntityID == referenceGuid).ToList();

            }
            else
            {
                list.Add(new TransactionLog
                {
                    LogDate = DateTime.Now,
                    User = SharedView.User,
                    TransactionType  = TransactionType.Adding,
                });
            }
            Updates = list?.Count(a => a.TransactionType == TransactionType.Modifying);
            Prints = list?.Count(a => a.TransactionType == TransactionType.Printing);
            AddLog = list.FirstOrDefault(a => a.TransactionType == TransactionType.Adding);
            LastUpdate = list.Where(a => a.TransactionType == TransactionType.Modifying).OrderByDescending(a => a.LogDate).FirstOrDefault();
            LastPrint = list.Where(a => a.TransactionType == TransactionType.Printing).OrderByDescending(a => a.LogDate).FirstOrDefault();
        }
    }
}
