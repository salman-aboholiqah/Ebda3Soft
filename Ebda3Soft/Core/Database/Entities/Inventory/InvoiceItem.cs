using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class InvoiceItem : BaseEntity
    {
        public Guid InvoiceItemID { get; set; }
        public Guid ItemUnitID { get; set; }
        [ForeignKey("ItemUnitID")]
        public ItemUnit ItemUnit { get; set; }
        public Guid InvoiceID { get; set; }
        [ForeignKey("ItemUnitID")]
        public Invoice Invoice { get; set; }
        public decimal UnitQuantity { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public override string DisplayMember => ItemUnit?.Item?.ItemName;

        public override Guid KeyMember => InvoiceItemID;
    }
}
