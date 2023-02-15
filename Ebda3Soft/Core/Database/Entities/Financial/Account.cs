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
    public class Account : BaseEntity
    {
        [Display(Order = -1)]
        public Guid AccountID { get; set; } = Guid.NewGuid();
        [Required, Index(IsUnique = true)]
        public Int64 AccountNumber { get; set; }
        [Required, StringLength(300), Index(IsUnique = true)]
        public String AccountName { get; set; }
        public Guid? ParentAccount { get; set; }

        [Required]
        [Display(Order = -1)]
        public Guid AccountTypeID { get; set; }


        [ForeignKey("AccountTypeID")]
        public virtual AccountType AccountType
        {
            get;set;
        }


        [XmlIgnore]
        [Display(Order = -1)]
        public virtual ICollection<Currency> Currencies { get; set; }
        public bool IsParent { get; set; }
        public override string DisplayMember => AccountName;

        [Display(Order = -1)]
        public override Guid KeyMember => AccountID;

        
    }
}
