using Ebda3Soft.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Models
{
    public class ViewInfo
    {
        public Guid ViewID { get; set; }
        public string ViewName { get; set; }
        public string EditFormName { get; set; }
        public string ViewCaption { get; set; }
        public string EntityType { get; set; }
        public TransactionType ViewType { get; set; }
        public SystemInfo SystemInfo { get; set; }

        public override string ToString()
        {
            return ViewCaption;
        }
    }

}
