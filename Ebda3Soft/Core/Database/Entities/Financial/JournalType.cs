
using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ebda3Soft.Core.Database.Entities.Financial
{
    public class JournalType : BaseEntity
    {
        [Display(Order = -1)]
        public Guid JournalTypeID { get; set; } = Guid.NewGuid();
        [Required]
        public string JournalTypeName { get; set; }
        [Required]
        public JournalView JournalForm { get; set; }


        public virtual ICollection<Journal> Journals { get; set; }

        public override string DisplayMember => JournalTypeName;

        public override Guid KeyMember => JournalTypeID;
       
    }
}
