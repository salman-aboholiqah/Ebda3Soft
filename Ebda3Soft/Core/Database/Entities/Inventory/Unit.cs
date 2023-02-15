using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Entities.Inventory
{
    public class Unit
    {
        public Guid UnitID { get; set; }
        public String UnitName { get; set; }
        public ICollection<ItemUnit> Items { get; set; }
    }
}
