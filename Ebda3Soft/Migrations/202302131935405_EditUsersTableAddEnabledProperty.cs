namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUsersTableAddEnabledProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsEnabled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsEnabled");
        }
    }
}
