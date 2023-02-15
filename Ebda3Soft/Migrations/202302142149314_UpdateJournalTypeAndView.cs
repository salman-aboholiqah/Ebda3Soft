namespace Ebda3Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateJournalTypeAndView : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Journals", "CreditAccount_AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "Currency_CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.Journals", "DebitAccount_AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "JournalType_JournalTypeID", "dbo.JournalTypes");
            DropIndex("dbo.Journals", new[] { "CreditAccount_AccountID" });
            DropIndex("dbo.Journals", new[] { "Currency_CurrencyID" });
            DropIndex("dbo.Journals", new[] { "DebitAccount_AccountID" });
            DropIndex("dbo.Journals", new[] { "JournalType_JournalTypeID" });
            RenameColumn(table: "dbo.Journals", name: "CreditAccount_AccountID", newName: "CreditAccountID");
            RenameColumn(table: "dbo.Journals", name: "Currency_CurrencyID", newName: "CurrencyID");
            RenameColumn(table: "dbo.Journals", name: "DebitAccount_AccountID", newName: "DebitAccountID");
            RenameColumn(table: "dbo.Journals", name: "JournalType_JournalTypeID", newName: "JournalTypeID");
            AlterColumn("dbo.Journals", "CreditAccountID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Journals", "CurrencyID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Journals", "DebitAccountID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Journals", "JournalTypeID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Journals", "JournalTypeID");
            CreateIndex("dbo.Journals", "CreditAccountID");
            CreateIndex("dbo.Journals", "DebitAccountID");
            CreateIndex("dbo.Journals", "CurrencyID");
            AddForeignKey("dbo.Journals", "CreditAccountID", "dbo.Accounts", "AccountID");
            AddForeignKey("dbo.Journals", "CurrencyID", "dbo.Currencies", "CurrencyID", cascadeDelete: true);
            AddForeignKey("dbo.Journals", "DebitAccountID", "dbo.Accounts", "AccountID");
            AddForeignKey("dbo.Journals", "JournalTypeID", "dbo.JournalTypes", "JournalTypeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journals", "JournalTypeID", "dbo.JournalTypes");
            DropForeignKey("dbo.Journals", "DebitAccountID", "dbo.Accounts");
            DropForeignKey("dbo.Journals", "CurrencyID", "dbo.Currencies");
            DropForeignKey("dbo.Journals", "CreditAccountID", "dbo.Accounts");
            DropIndex("dbo.Journals", new[] { "CurrencyID" });
            DropIndex("dbo.Journals", new[] { "DebitAccountID" });
            DropIndex("dbo.Journals", new[] { "CreditAccountID" });
            DropIndex("dbo.Journals", new[] { "JournalTypeID" });
            AlterColumn("dbo.Journals", "JournalTypeID", c => c.Guid());
            AlterColumn("dbo.Journals", "DebitAccountID", c => c.Guid());
            AlterColumn("dbo.Journals", "CurrencyID", c => c.Guid());
            AlterColumn("dbo.Journals", "CreditAccountID", c => c.Guid());
            RenameColumn(table: "dbo.Journals", name: "JournalTypeID", newName: "JournalType_JournalTypeID");
            RenameColumn(table: "dbo.Journals", name: "DebitAccountID", newName: "DebitAccount_AccountID");
            RenameColumn(table: "dbo.Journals", name: "CurrencyID", newName: "Currency_CurrencyID");
            RenameColumn(table: "dbo.Journals", name: "CreditAccountID", newName: "CreditAccount_AccountID");
            CreateIndex("dbo.Journals", "JournalType_JournalTypeID");
            CreateIndex("dbo.Journals", "DebitAccount_AccountID");
            CreateIndex("dbo.Journals", "Currency_CurrencyID");
            CreateIndex("dbo.Journals", "CreditAccount_AccountID");
            AddForeignKey("dbo.Journals", "JournalType_JournalTypeID", "dbo.JournalTypes", "JournalTypeID");
            AddForeignKey("dbo.Journals", "DebitAccount_AccountID", "dbo.Accounts", "AccountID");
            AddForeignKey("dbo.Journals", "Currency_CurrencyID", "dbo.Currencies", "CurrencyID");
            AddForeignKey("dbo.Journals", "CreditAccount_AccountID", "dbo.Accounts", "AccountID");
        }
    }
}
