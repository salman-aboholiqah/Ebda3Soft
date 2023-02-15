using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database.Interfaces
{
    public interface ISupportEntityActions
    {
        bool Save();
        void SaveAndClose();
        void SaveAndNew();
        void ResetChanges();
        bool Delete();
        void Close();
        void New();
        bool IsReadyToSave();
        bool IsReadyToDelete();

    }
}
