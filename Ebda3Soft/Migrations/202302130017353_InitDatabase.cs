namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "AccountType_AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.Accounts", new[] { "AccountType_AccountTypeID" });
            RenameColumn(table: "dbo.Accounts", name: "AccountType_AccountTypeID", newName: "AccountTypeID");
            AddColumn("dbo.AccountTypes", "IsCash", c => c.Boolean(nullable: false));
            AddColumn("dbo.Currencies", "ShortCut", c => c.String(maxLength: 10));
            AddColumn("dbo.Currencies", "Sign", c => c.String(maxLength: 2));
            AddColumn("dbo.Currencies", "IsLocal", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Accounts", "AccountName", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Accounts", "ParentAccount", c => c.Guid());
            AlterColumn("dbo.Accounts", "AccountTypeID", c => c.Guid(nullable: false));
            AlterColumn("dbo.AccountTypes", "TypeName", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Currencies", "CurrencyName", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Currencies", "CountOfDecimals", c => c.Int(nullable: false));
            CreateIndex("dbo.Accounts", "AccountNumber", unique: true);
            CreateIndex("dbo.Accounts", "AccountName", unique: true);
            CreateIndex("dbo.Accounts", "AccountTypeID");
            CreateIndex("dbo.AccountTypes", "TypeName", unique: true);
            CreateIndex("dbo.Currencies", "CurrencyName", unique: true);
            AddForeignKey("dbo.Accounts", "AccountTypeID", "dbo.AccountTypes", "AccountTypeID", cascadeDelete: true);
            DropColumn("dbo.Accounts", "IsCash");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "IsCash", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Accounts", "AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.Currencies", new[] { "CurrencyName" });
            DropIndex("dbo.AccountTypes", new[] { "TypeName" });
            DropIndex("dbo.Accounts", new[] { "AccountTypeID" });
            DropIndex("dbo.Accounts", new[] { "AccountName" });
            DropIndex("dbo.Accounts", new[] { "AccountNumber" });
            AlterColumn("dbo.Currencies", "CountOfDecimals", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Currencies", "CurrencyName", c => c.String());
            AlterColumn("dbo.AccountTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Accounts", "AccountTypeID", c => c.Guid());
            AlterColumn("dbo.Accounts", "ParentAccount", c => c.Guid(nullable: false));
            AlterColumn("dbo.Accounts", "AccountName", c => c.String());
            DropColumn("dbo.Currencies", "IsLocal");
            DropColumn("dbo.Currencies", "Sign");
            DropColumn("dbo.Currencies", "ShortCut");
            DropColumn("dbo.AccountTypes", "IsCash");
            RenameColumn(table: "dbo.Accounts", name: "AccountTypeID", newName: "AccountType_AccountTypeID");
            CreateIndex("dbo.Accounts", "AccountType_AccountTypeID");
            AddForeignKey("dbo.Accounts", "AccountType_AccountTypeID", "dbo.AccountTypes", "AccountTypeID");
        }
    }
}
