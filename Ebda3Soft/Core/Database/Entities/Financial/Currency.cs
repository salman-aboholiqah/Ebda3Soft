using Ebda3Soft.Core.CustomAttributes;
using Ebda3Soft.Core.Database.Interfaces;
using Ebda3Soft.Lang;
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
        [Display(Order = -1,AutoGenerateField =false)]
        public Guid CurrencyID { get; set; } = Guid.NewGuid();
        [Required,StringLength(300),Index(IsUnique =true),LocalizableDisplayName(typeof(Languages), nameof(CurrencyName))]
        public String CurrencyName { get; set; }
        [LocalizableDisplayName(typeof(Languages), nameof(SubCurrencyName))]
        public String SubCurrencyName { get; set; }
        [LocalizableDisplayName(typeof(Languages), nameof(CountOfDecimals))]
        public int CountOfDecimals { get; set; }
        [StringLength(10)]
        [LocalizableDisplayName(typeof(Languages), nameof(ShortCut))]
        public String ShortCut { get; set; }
        [StringLength(2)]
        [LocalizableDisplayName(typeof(Languages), nameof(Sign))]
        public String Sign { get; set; }
        [LocalizableDisplayName(typeof(Languages), nameof(IsLocal))]
        public bool IsLocal { get; set; }

        [XmlIgnore]
        public virtual ICollection<Account> Accounts { get; set; }

        public override string DisplayMember => CurrencyName;

        public override Guid KeyMember => CurrencyID;

    }
}
