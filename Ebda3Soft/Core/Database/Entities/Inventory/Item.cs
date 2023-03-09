using DevExpress.XtraBars.Docking2010.Customization;
using Ebda3Soft.Core.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class Item : BaseEntity
    {
        [Display(Order = -1,AutoGenerateField =false)]
        public Guid ItemID { get; set; } = Guid.NewGuid();
        [Required,StringLength(250), Index(IsUnique = true), LocalizableDisplayName(typeof(Lang.Languages), "ItemName")]
        public String ItemName { get; set; }
        [Required, Index(IsUnique = true), LocalizableDisplayName(typeof(Lang.Languages), "ItemNumber")]
        public int ItemNumber { get; set; }
        [Display(Order = -1,AutoGenerateField =false)]
        public Guid ItemTypeID { get; set; }
        [ForeignKey("ItemTypeID"), LocalizableDisplayName(typeof(Lang.Languages),"ItemTypeName")]
        public virtual  ItemType ItemType { get; set; }
        public virtual ICollection<ItemUnit> Units { get; set; } 
        public override string DisplayMember => ItemName;

        [Display(Order = -1,AutoGenerateField =false)]
        public override Guid KeyMember => ItemID;
        public override bool IsReadyToSave()
        {
            if(Units.Count(a => a.IsMain) == 0)
            {
                var result = FlyoutDialog.Show(this.ParentForm, "Delete", "You have to enter the main unit", MessageBoxButtons.YesNo);
                return false;
            }
            if (SQLServerDbContext.Instance.Items.Count(a => a.ItemNumber == ItemNumber && a.ItemID != ItemID) > 0)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "The number is recorded before", MessageBoxButtons.OK);
                return false;
            }
            return base.IsReadyToSave();
        }
    }
}
