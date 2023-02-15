using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Interfaces
{
    public interface IClosable
    {
        Action CloseAction { get; set; }

    }
}
