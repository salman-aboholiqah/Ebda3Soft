using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class ItemType
    {
        public Guid ItemTypeID { get; set; }
        public String TypeName { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}
