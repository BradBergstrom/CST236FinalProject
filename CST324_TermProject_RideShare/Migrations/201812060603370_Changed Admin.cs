namespace CST324_TermProject_RideShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAdmin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Admin", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Admin", c => c.Int(nullable: false, identity: true));
        }
    }
}
