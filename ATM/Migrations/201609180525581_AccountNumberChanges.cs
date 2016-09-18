namespace ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChanges : DbMigration
    {
        // this method rolling the database to new changes
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        // this method rolling the database back
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false));
        }
    }
}
