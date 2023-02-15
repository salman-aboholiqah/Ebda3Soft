namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUsersTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PlainText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PlainText", c => c.String());
        }
    }
}
