namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Guid(nullable: false),
                        AccountNumber = c.Long(nullable: false),
                        AccountName = c.String(nullable: false, maxLength: 300),
                        ParentAccount = c.Guid(),
                        AccountTypeID = c.Guid(nullable: false),
                        IsParent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeID, cascadeDelete: true)
                .Index(t => t.AccountNumber, unique: true)
                .Index(t => t.AccountName, unique: true)
                .Index(t => t.AccountTypeID);
            
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        AccountTypeID = c.Guid(nullable: false),
                        TypeName = c.String(nullable: false, maxLength: 300),
                        IsCash = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AccountTypeID)
                .Index(t => t.TypeName, unique: true);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyID = c.Guid(nullable: false),
                        CurrencyName = c.String(nullable: false, maxLength: 300),
                        SubCurrencyName = c.String(),
                        CountOfDecimals = c.Int(nullable: false),
                        ShortCut = c.String(maxLength: 10),
                        Sign = c.String(maxLength: 2),
                        IsLocal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CurrencyID)
                .Index(t => t.CurrencyName, unique: true);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Guid(nullable: false),
                        ItemName = c.String(nullable: false, maxLength: 250),
                        ItemNumber = c.Int(nullable: false),
                        ItemTypeID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.ItemTypes", t => t.ItemTypeID, cascadeDelete: true)
                .Index(t => t.ItemName, unique: true)
                .Index(t => t.ItemNumber, unique: true)
                .Index(t => t.ItemTypeID);
            
            CreateTable(
                "dbo.ItemTypes",
                c => new
                    {
                        ItemTypeID = c.Guid(nullable: false),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ItemTypeID);
            
            CreateTable(
                "dbo.ItemUnits",
                c => new
                    {
                        ItemUnitID = c.Guid(nullable: false),
                        UnitID = c.Guid(nullable: false),
                        ItemID = c.Guid(nullable: false),
                        UnitQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsMain = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ItemUnitID)
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitID, cascadeDelete: true)
                .Index(t => t.UnitID)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitID = c.Guid(nullable: false),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitID);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        JournalID = c.Guid(nullable: false),
                        JournalTypeID = c.Guid(nullable: false),
                        JournalNumber = c.Long(nullable: false),
                        JournalDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        CurrencyID = c.Guid(nullable: false),
                        IsPosted = c.Boolean(nullable: false),
                        JournalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.JournalID)
                .ForeignKey("dbo.Currencies", t => t.CurrencyID, cascadeDelete: true)
                .ForeignKey("dbo.JournalTypes", t => t.JournalTypeID, cascadeDelete: true)
                .Index(t => t.JournalTypeID)
                .Index(t => t.CurrencyID);
            
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
            
            CreateTable(
                "dbo.JournalTypes",
                c => new
                    {
                        JournalTypeID = c.Guid(nullable: false),
                        JournalTypeName = c.String(nullable: false),
                        JournalForm = c.Int(nullable: false),
                        ShortCode = c.String(),
                    })
                .PrimaryKey(t => t.JournalTypeID);
            
            CreateTable(
                "dbo.TransactionLogs",
                c => new
                    {
                        TransactionLogID = c.Guid(nullable: false),
                        PreviousLogID = c.Guid(),
                        EntityID = c.Guid(nullable: false),
                        DisplayValue = c.String(),
                        LogDate = c.DateTime(),
                        UserID = c.Guid(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        EntityType = c.String(),
                        EntityData = c.String(),
                    })
                .PrimaryKey(t => t.TransactionLogID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 300),
                        LoginID = c.String(nullable: false, maxLength: 300),
                        HashedPassword = c.String(nullable: false),
                        IsSuperAdmin = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.FullName, unique: true)
                .Index(t => t.LoginID, unique: true);
            
            CreateTable(
                "dbo.UserViewInfoes",
                c => new
                    {
                        UserViewInfoID = c.Guid(nullable: false),
                        ViewID = c.Guid(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        User_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.UserViewInfoID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.CurrencyAccounts",
                c => new
                    {
                        Currency_CurrencyID = c.Guid(nullable: false),
                        Account_AccountID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Currency_CurrencyID, t.Account_AccountID })
                .ForeignKey("dbo.Currencies", t => t.Currency_CurrencyID, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_AccountID, cascadeDelete: true)
                .Index(t => t.Currency_CurrencyID)
                .Index(t => t.Account_AccountID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionLogs", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserViewInfoes", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Journals", "JournalTypeID", "dbo.JournalTypes");
            DropForeignKey("dbo.JournalDetails", "JournalID", "dbo.Journals");
            DropForeignKey("dbo.JournalDetails", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.ItemUnits", "UnitID", "dbo.Units");
            DropForeignKey("dbo.ItemUnits", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Items", "ItemTypeID", "dbo.ItemTypes");
            DropForeignKey("dbo.CurrencyAccounts", "Account_AccountID", "dbo.Accounts");
            DropForeignKey("dbo.CurrencyAccounts", "Currency_CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.Accounts", "AccountTypeID", "dbo.AccountTypes");
            DropIndex("dbo.CurrencyAccounts", new[] { "Account_AccountID" });
            DropIndex("dbo.CurrencyAccounts", new[] { "Currency_CurrencyID" });
            DropIndex("dbo.UserViewInfoes", new[] { "User_UserID" });
            DropIndex("dbo.Users", new[] { "LoginID" });
            DropIndex("dbo.Users", new[] { "FullName" });
            DropIndex("dbo.TransactionLogs", new[] { "UserID" });
            DropIndex("dbo.JournalDetails", new[] { "JournalID" });
            DropIndex("dbo.JournalDetails", new[] { "AccountID" });
            DropIndex("dbo.Journals", new[] { "CurrencyID" });
            DropIndex("dbo.Journals", new[] { "JournalTypeID" });
            DropIndex("dbo.ItemUnits", new[] { "ItemID" });
            DropIndex("dbo.ItemUnits", new[] { "UnitID" });
            DropIndex("dbo.Items", new[] { "ItemTypeID" });
            DropIndex("dbo.Items", new[] { "ItemNumber" });
            DropIndex("dbo.Items", new[] { "ItemName" });
            DropIndex("dbo.Currencies", new[] { "CurrencyName" });
            DropIndex("dbo.AccountTypes", new[] { "TypeName" });
            DropIndex("dbo.Accounts", new[] { "AccountTypeID" });
            DropIndex("dbo.Accounts", new[] { "AccountName" });
            DropIndex("dbo.Accounts", new[] { "AccountNumber" });
            DropTable("dbo.CurrencyAccounts");
            DropTable("dbo.UserViewInfoes");
            DropTable("dbo.Users");
            DropTable("dbo.TransactionLogs");
            DropTable("dbo.JournalTypes");
            DropTable("dbo.JournalDetails");
            DropTable("dbo.Journals");
            DropTable("dbo.Units");
            DropTable("dbo.ItemUnits");
            DropTable("dbo.ItemTypes");
            DropTable("dbo.Items");
            DropTable("dbo.Currencies");
            DropTable("dbo.AccountTypes");
            DropTable("dbo.Accounts");
        }
    }
}
