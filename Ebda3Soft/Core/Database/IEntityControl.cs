using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database
{
    public interface IEntityControl
    {
        BaseEntity BaseEntity { get; set; }
        void InitBaseEntity();
    }
}
