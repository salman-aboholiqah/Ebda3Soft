namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransactionEntityData2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionLogs", "EntityData", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionLogs", "EntityData", c => c.Binary());
        }
    }
}
