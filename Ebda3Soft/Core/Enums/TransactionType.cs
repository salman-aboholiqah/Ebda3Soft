using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Enums
{
    [Flags]
    public enum TransactionType
    {
        Viewing,
        Adding,
        Modifying,
        Deleting,
        Printing
    }
}
