using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class Item
    {
        public Guid ItemID { get; set; }
        public String ItemName { get; set; }
        public int ItemNumber { get; set; }
        public ItemType ItemType { get; set; }
        public ICollection<ItemUnit> Units { get; set; }

    }
}
