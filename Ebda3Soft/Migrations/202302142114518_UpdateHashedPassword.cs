namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateHashedPassword : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "HashedPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "HashedPassword", c => c.String());
        }
    }
}
