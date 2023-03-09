using Ebda3Soft.Core.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class ItemUnit : BaseEntity
    {
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid ItemUnitID { get; set; } = Guid.NewGuid();

        [Display(Order = -1, AutoGenerateField = false),]
        public Guid UnitID { get; set; }
        [ForeignKey("UnitID"), LocalizableDisplayName(typeof(Lang.Languages), "UnitName")]
        public virtual Unit Unit { get; set; }

        [Display(Order = -1, AutoGenerateField = false)]
        public Guid ItemID { get; set; }
        [ForeignKey("ItemID"), LocalizableDisplayName(typeof(Lang.Languages), "ItemName")]
        public virtual Item Item { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages), "UnitQuantity")]
        public decimal UnitQuantity { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages), "Price")]
        public decimal Price { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages), "Cost")]
        public decimal Cost { get; set; }
        [LocalizableDisplayName(typeof(Lang.Languages), "IsMain")]
        public bool IsMain { get; set; }

        public override string DisplayMember => Unit?.UnitName;

        [Display(Order = -1, AutoGenerateField = false)]
        public override Guid KeyMember => ItemUnitID;
    }
}
