using Ebda3Soft.Core.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class Unit : BaseEntity
    {
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid UnitID { get; set; } = Guid.NewGuid();
        [LocalizableDisplayName(typeof(Lang.Languages), "UnitName")]
        public String UnitName { get; set; }
        public virtual ICollection<ItemUnit> Items { get; set; }

        public override string DisplayMember => UnitName;

        [Display(Order = -1, AutoGenerateField = false)]
        public override Guid KeyMember => UnitID;
    }
}
