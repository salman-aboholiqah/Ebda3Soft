using Ebda3Soft.Core.Database.Entities.Financial;
using Ebda3Soft.Core.Database.Entities.GeneralSettings;
using Ebda3Soft.Core.Database.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ebda3Soft.Core.Database
{
    public class SQLServerDbContext : DbContext
    {

        private static SQLServerDbContext dbContext;

        public static SQLServerDbContext Instance
        {
            get
            {
                if (dbContext == null || dbContext.IsDisposed())
                    dbContext = new SQLServerDbContext();
                return dbContext;
            }
            set { dbContext = value; }
        }

        public SQLServerDbContext() : base("name=SQLServerConnectionString")
        {
        }

        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<JournalType> JournalTypes { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }


        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TransactionLog> TransactionLogs { get; set; }
        public virtual DbSet<UserViewInfo> UserViews { get; set; }


        public static DateTime GetServerDate()
        {
            var dateQuery = dbContext.Database.SqlQuery<DateTime>("SELECT getdate()");
            return dateQuery.AsEnumerable().First();
        }

        public bool IsDisposed()
        {
            var result = true;

            var typeDbContext = typeof(DbContext);
            var typeInternalContext = typeDbContext.Assembly.GetType("System.Data.Entity.Internal.InternalContext");

            var fi_InternalContext = typeDbContext.GetField("_internalContext", BindingFlags.NonPublic | BindingFlags.Instance);
            var pi_IsDisposed = typeInternalContext.GetProperty("IsDisposed");

            var ic = fi_InternalContext.GetValue(this);

            if (ic != null)
            {
                result = (bool)pi_IsDisposed.GetValue(ic);
            }

            return result;
        }
    }
}
