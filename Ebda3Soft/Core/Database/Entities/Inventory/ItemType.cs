using Ebda3Soft.Core.CustomAttributes;
using Ebda3Soft.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class ItemType : BaseEntity
    {
        [Display(Order = -1, AutoGenerateField = false)]
        public Guid ItemTypeID { get; set; } = Guid.NewGuid();
        [Required, StringLength(250), Index(IsUnique = true), LocalizableDisplayName(typeof(Languages), "ItemTypeName")]
        public String TypeName { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public override string DisplayMember => TypeName;

        [Display(Order = -1, AutoGenerateField = false)]
        public override Guid KeyMember => ItemTypeID;
    }
}
