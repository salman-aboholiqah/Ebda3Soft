namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLogs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionLogs", "PreviousLogID", c => c.Guid());
            AlterColumn("dbo.TransactionLogs", "LogDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionLogs", "LogDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TransactionLogs", "PreviousLogID", c => c.Guid(nullable: false));
        }
    }
}
