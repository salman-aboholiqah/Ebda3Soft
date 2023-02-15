namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUsersTable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "HashedPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "HashedPassword", c => c.Int(nullable: false));
        }
    }
}
