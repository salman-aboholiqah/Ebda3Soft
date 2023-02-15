namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPermissionsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        JournalID = c.Guid(nullable: false),
                        JournalNumber = c.Long(nullable: false),
                        JournalDate = c.DateTime(nullable: false),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        IsPosted = c.Boolean(nullable: false),
                        CreditAccount_AccountID = c.Guid(),
                        Currency_CurrencyID = c.Guid(),
                        DebitAccount_AccountID = c.Guid(),
                        JournalType_JournalTypeID = c.Guid(),
                    })
                .PrimaryKey(t => t.JournalID)
                .ForeignKey("dbo.Accounts", t => t.CreditAccount_AccountID)
                .ForeignKey("dbo.Currencies", t => t.Currency_CurrencyID)
                .ForeignKey("dbo.Accounts", t => t.DebitAccount_AccountID)
                .ForeignKey("dbo.JournalTypes", t => t.JournalType_JournalTypeID)
                .Index(t => t.CreditAccount_AccountID)
                .Index(t => t.Currency_CurrencyID)
                .Index(t => t.DebitAccount_AccountID)
                .Index(t => t.JournalType_JournalTypeID);
            
            CreateTable(
                "dbo.JournalTypes",
                c => new
                    {
                        JournalTypeID = c.Guid(nullable: false),
                        JournalTypeName = c.String(),
                        JournalForm = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JournalTypeID);
            
            CreateTable(
                "dbo.TransactionLogs",
                c => new
                    {
                        TransactionLogID = c.Guid(nullable: false),
                        PreviousLogID = c.Guid(nullable: false),
                        EntityID = c.Guid(nullable: false),
                        DisplayValue = c.String(),
                        LogDate = c.DateTime(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        EntityType = c.String(),
                        XMLData = c.String(),
                        User_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.TransactionLogID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 300),
                        LoginID = c.String(nullable: false, maxLength: 300),
                        HashedPassword = c.Int(nullable: false),
                        PlainText = c.String(),
                        IsSuperAdmin = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.FullName, unique: true)
                .Index(t => t.LoginID, unique: true);
            
            CreateTable(
                "dbo.UserViews",
                c => new
                    {
                        UserViewID = c.Guid(nullable: false),
                        ViewID = c.Guid(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        User_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.UserViewID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionLogs", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.UserViews", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Journals", "JournalType_JournalTypeID", "dbo.JournalTypes");
            DropForeignKey("dbo.Journals", "DebitAccount_AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "Currency_CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.Journals", "CreditAccount_AccountID", "dbo.Accounts");
            DropIndex("dbo.UserViews", new[] { "User_UserID" });
            DropIndex("dbo.Users", new[] { "LoginID" });
            DropIndex("dbo.Users", new[] { "FullName" });
            DropIndex("dbo.TransactionLogs", new[] { "User_UserID" });
            DropIndex("dbo.Journals", new[] { "JournalType_JournalTypeID" });
            DropIndex("dbo.Journals", new[] { "DebitAccount_AccountID" });
            DropIndex("dbo.Journals", new[] { "Currency_CurrencyID" });
            DropIndex("dbo.Journals", new[] { "CreditAccount_AccountID" });
            DropTable("dbo.UserViews");
            DropTable("dbo.Users");
            DropTable("dbo.TransactionLogs");
            DropTable("dbo.JournalTypes");
            DropTable("dbo.Journals");
        }
    }
}
