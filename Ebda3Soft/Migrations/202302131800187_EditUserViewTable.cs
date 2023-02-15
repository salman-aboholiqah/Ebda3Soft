namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUserViewTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserViews", newName: "UserViewInfoes");
            DropPrimaryKey("dbo.UserViewInfoes");
            AddColumn("dbo.UserViewInfoes", "UserViewInfoID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.UserViewInfoes", "UserViewInfoID");
            DropColumn("dbo.UserViewInfoes", "UserViewID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserViewInfoes", "UserViewID", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.UserViewInfoes");
            DropColumn("dbo.UserViewInfoes", "UserViewInfoID");
            AddPrimaryKey("dbo.UserViewInfoes", "UserViewID");
            RenameTable(name: "dbo.UserViewInfoes", newName: "UserViews");
        }
    }
}
