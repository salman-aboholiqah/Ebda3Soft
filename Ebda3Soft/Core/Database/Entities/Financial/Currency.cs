using Ebda3Soft.Core.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Ebda3Soft.Core.Database.Entities.Financial
{
    public class Currency : BaseEntity
    {
        [Display(Order = -1)]
        public Guid CurrencyID { get; set; } = Guid.NewGuid();
        [Required,StringLength(300),Index(IsUnique =true)]
        public String CurrencyName { get; set; }
        public String SubCurrencyName { get; set; }
        public int CountOfDecimals { get; set; }
        [StringLength(10)]
        public String ShortCut { get; set; }
        [StringLength(2)]
        public String Sign { get; set; }
        public bool IsLocal { get; set; }

        [XmlIgnore]
        public virtual ICollection<Account> Accounts { get; set; }

        public override string DisplayMember => CurrencyName;

        public override Guid KeyMember => CurrencyID;

    }
}
