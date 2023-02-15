namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransactionDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionLogs", "LogDate", c => c.DateTime(defaultValueSql: "getutcdate()"));
        }

        public override void Down()
        {
            AlterColumn("dbo.TransactionLogs", "LogDate", c => c.DateTime());

        }
    }
}
