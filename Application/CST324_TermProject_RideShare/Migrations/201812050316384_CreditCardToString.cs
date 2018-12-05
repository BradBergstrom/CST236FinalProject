namespace CST324_TermProject_RideShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditCardToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RideRequests", "CreditCard#", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RideRequests", "CreditCard#", c => c.Int());
        }
    }
}
