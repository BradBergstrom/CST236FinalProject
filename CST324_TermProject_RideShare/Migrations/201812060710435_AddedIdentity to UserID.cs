namespace CST324_TermProject_RideShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIdentitytoUserID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.User");
            AlterColumn("dbo.User", "UserID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.User", "UserID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.User");
            AlterColumn("dbo.User", "UserID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.User", "UserID");
        }
    }
}
