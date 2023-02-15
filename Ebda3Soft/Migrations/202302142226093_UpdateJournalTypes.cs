namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateJournalTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JournalTypes", "JournalTypeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JournalTypes", "JournalTypeName", c => c.String());
        }
    }
}
