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
    public class AccountType : BaseEntity
    {
        public Guid AccountTypeID { get; set; } = Guid.NewGuid();
        [Required,StringLength(300),Index(IsUnique =true), LocalizableDisplayName(typeof(Languages), "AccountTypeName")]
        public String TypeName { get; set; }

        
        [XmlIgnore()]
        public virtual ICollection<Account> Accounts { get; set; }
        [LocalizableDisplayName(typeof(Languages), nameof(IsCash))]
        public bool IsCash { get; set; }

        public override string DisplayMember => TypeName;

        public override Guid KeyMember => AccountTypeID;


    }
}
