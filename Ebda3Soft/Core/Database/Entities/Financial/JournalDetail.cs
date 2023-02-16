using Ebda3Soft.Core.CustomAttributes;
using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Financial
{
    public class JournalDetail : BaseEntity
    {
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid JournalDetailID { get; set; } = Guid.NewGuid();
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid AccountID { get; set; }
        [ForeignKey("AccountID"), LocalizableDisplayName(typeof(Lang.Languages),"AccountName")]
        public virtual Account Account { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages),"Debit")]
        public decimal Debit { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages),"Credit")]
        public decimal Credit { get; set; }
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid JournalID { get; set; }
        [ForeignKey("JournalID")]
        public virtual Journal ParentJournal { get; set; }

        public JournalDetailDirection Direction { get; set; }

        public override string DisplayMember => Account?.AccountName;

        public override Guid KeyMember => JournalDetailID;
    }
}
