using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.GeneralSettings
{
    public class TransactionLog
    {
        public Guid TransactionLogID { get; set; } = Guid.NewGuid();
        public Guid? PreviousLogID { get; set; }
        public Guid EntityID { get; set; }
        public string DisplayValue { get; set; }
        [DefaultValue("getutcdate()")]
        public DateTime? LogDate { get; set; }
        public Guid UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public TransactionType TransactionType { get; set; }
        public string EntityType { get; set; }
        [DataType("xml")]
        public string EntityData { get; set; }

    }
}
