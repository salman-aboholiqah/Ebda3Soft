namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemTypes", "TypeName", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.ItemTypes", "TypeName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ItemTypes", new[] { "TypeName" });
            AlterColumn("dbo.ItemTypes", "TypeName", c => c.String());
        }
    }
}
