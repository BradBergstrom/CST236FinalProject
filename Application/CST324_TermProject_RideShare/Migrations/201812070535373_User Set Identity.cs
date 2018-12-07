namespace CST324_TermProject_RideShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserSetIdentity : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.User");
            AlterColumn("dbo.RideRequests", "CreditCard#", c => c.String());
            AlterColumn("dbo.User", "UserID", c => c.Int(nullable: false, identity: true));
           // AlterColumn("dbo.User", "Admin", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.User", "UserID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.User");
            AlterColumn("dbo.User", "Admin", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.User", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.RideRequests", "CreditCard#", c => c.Int());
            AddPrimaryKey("dbo.User", "UserID");
        }
    }
}
