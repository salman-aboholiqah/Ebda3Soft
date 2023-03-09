using Ebda3Soft.Core.Database.Entities.Financial;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class Invoice : BaseEntity
    {
        [ForeignKey("Journal")]
        public Guid InvoiceID { get; set; }
        public Journal Journal { get; set; }

        public JournalDetail InvoiceAccount { get; set; }
        public JournalDetail CashAccount { get; set; }
        public JournalDetail ThirdPartyAccount { get; set; }

        public override string DisplayMember => Journal?.JournalCode;

        public override Guid KeyMember => InvoiceID;
    }
}
