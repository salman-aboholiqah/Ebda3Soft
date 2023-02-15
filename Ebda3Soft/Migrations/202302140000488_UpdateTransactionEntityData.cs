namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransactionEntityData : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransactionLogs", "User_UserID", "dbo.Users");
            DropIndex("dbo.TransactionLogs", new[] { "User_UserID" });
            RenameColumn(table: "dbo.TransactionLogs", name: "User_UserID", newName: "UserID");
            AddColumn("dbo.TransactionLogs", "EntityData", c => c.Binary());
            AlterColumn("dbo.TransactionLogs", "UserID", c => c.Guid(nullable: false));
            CreateIndex("dbo.TransactionLogs", "UserID");
            AddForeignKey("dbo.TransactionLogs", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.TransactionLogs", "XMLData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransactionLogs", "XMLData", c => c.String());
            DropForeignKey("dbo.TransactionLogs", "UserID", "dbo.Users");
            DropIndex("dbo.TransactionLogs", new[] { "UserID" });
            AlterColumn("dbo.TransactionLogs", "UserID", c => c.Guid());
            DropColumn("dbo.TransactionLogs", "EntityData");
            RenameColumn(table: "dbo.TransactionLogs", name: "UserID", newName: "User_UserID");
            CreateIndex("dbo.TransactionLogs", "User_UserID");
            AddForeignKey("dbo.TransactionLogs", "User_UserID", "dbo.Users", "UserID");
        }
    }
}
