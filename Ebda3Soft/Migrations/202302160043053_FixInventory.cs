namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixInventory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Journals", "CreditAccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "DebitAccountID", "dbo.Accounts");
            DropForeignKey("dbo.Items", "ItemType_ItemTypeID", "dbo.ItemTypes");
            DropForeignKey("dbo.ItemUnits", "Item_ItemID", "dbo.Items");
            DropForeignKey("dbo.ItemUnits", "Unit_UnitID", "dbo.Units");
            DropIndex("dbo.Items", new[] { "ItemType_ItemTypeID" });
            DropIndex("dbo.ItemUnits", new[] { "Item_ItemID" });
            DropIndex("dbo.ItemUnits", new[] { "Unit_UnitID" });
            DropIndex("dbo.Journals", new[] { "CreditAccountID" });
            DropIndex("dbo.Journals", new[] { "DebitAccountID" });
            RenameColumn(table: "dbo.Items", name: "ItemType_ItemTypeID", newName: "ItemTypeID");
            RenameColumn(table: "dbo.ItemUnits", name: "Item_ItemID", newName: "ItemID");
            RenameColumn(table: "dbo.ItemUnits", name: "Unit_UnitID", newName: "UnitID");
            CreateTable(
                "dbo.JournalDetails",
                c => new
                    {
                        JournalDetailID = c.Guid(nullable: false),
                        AccountID = c.Guid(nullable: false),
                        Debit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        JournalID = c.Guid(nullable: false),
                        Direction = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JournalDetailID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Journals", t => t.JournalID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.JournalID);
            
            AddColumn("dbo.Journals", "JournalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Items", "ItemName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Items", "ItemTypeID", c => c.Guid(nullable: false));
            AlterColumn("dbo.ItemTypes", "TypeName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ItemUnits", "UnitQuantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ItemUnits", "ItemID", c => c.Guid(nullable: false));
            AlterColumn("dbo.ItemUnits", "UnitID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Items", "ItemName", unique: true);
            CreateIndex("dbo.Items", "ItemNumber", unique: true);
            CreateIndex("dbo.Items", "ItemTypeID");
            CreateIndex("dbo.ItemTypes", "TypeName", unique: true);
            CreateIndex("dbo.ItemUnits", "UnitID");
            CreateIndex("dbo.ItemUnits", "ItemID");
            AddForeignKey("dbo.Items", "ItemTypeID", "dbo.ItemTypes", "ItemTypeID", cascadeDelete: true);
            AddForeignKey("dbo.ItemUnits", "ItemID", "dbo.Items", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.ItemUnits", "UnitID", "dbo.Units", "UnitID", cascadeDelete: true);
            DropColumn("dbo.Journals", "CreditAccountID");
            DropColumn("dbo.Journals", "DebitAccountID");
            DropColumn("dbo.Journals", "Credit");
            DropColumn("dbo.Journals", "Debit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Journals", "Debit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Journals", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Journals", "DebitAccountID", c => c.Guid(nullable: false));
            AddColumn("dbo.Journals", "CreditAccountID", c => c.Guid(nullable: false));
            DropForeignKey("dbo.ItemUnits", "UnitID", "dbo.Units");
            DropForeignKey("dbo.ItemUnits", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Items", "ItemTypeID", "dbo.ItemTypes");
            DropForeignKey("dbo.JournalDetails", "JournalID", "dbo.Journals");
            DropForeignKey("dbo.JournalDetails", "AccountID", "dbo.Accounts");
            DropIndex("dbo.JournalDetails", new[] { "JournalID" });
            DropIndex("dbo.JournalDetails", new[] { "AccountID" });
            DropIndex("dbo.ItemUnits", new[] { "ItemID" });
            DropIndex("dbo.ItemUnits", new[] { "UnitID" });
            DropIndex("dbo.ItemTypes", new[] { "TypeName" });
            DropIndex("dbo.Items", new[] { "ItemTypeID" });
            DropIndex("dbo.Items", new[] { "ItemNumber" });
            DropIndex("dbo.Items", new[] { "ItemName" });
            AlterColumn("dbo.ItemUnits", "UnitID", c => c.Guid());
            AlterColumn("dbo.ItemUnits", "ItemID", c => c.Guid());
            AlterColumn("dbo.ItemUnits", "UnitQuantity", c => c.Int(nullable: false));
            AlterColumn("dbo.ItemTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Items", "ItemTypeID", c => c.Guid());
            AlterColumn("dbo.Items", "ItemName", c => c.String());
            DropColumn("dbo.Journals", "JournalPrice");
            DropTable("dbo.JournalDetails");
            RenameColumn(table: "dbo.ItemUnits", name: "UnitID", newName: "Unit_UnitID");
            RenameColumn(table: "dbo.ItemUnits", name: "ItemID", newName: "Item_ItemID");
            RenameColumn(table: "dbo.Items", name: "ItemTypeID", newName: "ItemType_ItemTypeID");
            CreateIndex("dbo.Journals", "DebitAccountID");
            CreateIndex("dbo.Journals", "CreditAccountID");
            CreateIndex("dbo.ItemUnits", "Unit_UnitID");
            CreateIndex("dbo.ItemUnits", "Item_ItemID");
            CreateIndex("dbo.Items", "ItemType_ItemTypeID");
            AddForeignKey("dbo.ItemUnits", "Unit_UnitID", "dbo.Units", "UnitID");
            AddForeignKey("dbo.ItemUnits", "Item_ItemID", "dbo.Items", "ItemID");
            AddForeignKey("dbo.Items", "ItemType_ItemTypeID", "dbo.ItemTypes", "ItemTypeID");
            AddForeignKey("dbo.Journals", "DebitAccountID", "dbo.Accounts", "AccountID", cascadeDelete: true);
            AddForeignKey("dbo.Journals", "CreditAccountID", "dbo.Accounts", "AccountID", cascadeDelete: true);
        }
    }
}
