using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class ItemUnit
    {
        public Guid ItemUnitID { get; set; }

        public Unit Unit { get; set; }
        
        public Item Item { get; set; }
        public int UnitQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public bool IsMain { get; set; }
    }
}
