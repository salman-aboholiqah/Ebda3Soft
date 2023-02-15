using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database
{
    class Ebda3SoftDBInitializer : CreateDatabaseIfNotExists<SQLServerDbContext>
    {
        protected override void Seed(SQLServerDbContext context)
        {
            base.Seed(context);
        }
    }
}
