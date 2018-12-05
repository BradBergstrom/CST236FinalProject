namespace CST324_TermProject_RideShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Driver",
            //    c => new
            //        {
            //            DriverID = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(nullable: false, maxLength: 55),
            //            LicensePlate = c.String(nullable: false, maxLength: 8),
            //            VehicleType = c.String(nullable: false, maxLength: 255),
            //            RideRequests = c.Int(),
            //        })
            //    .PrimaryKey(t => t.DriverID)
            //    .ForeignKey("dbo.RideRequests", t => t.RideRequests, cascadeDelete: true)
            //    .Index(t => t.RideRequests);
            
            //CreateTable(
            //    "dbo.RideRequests",
            //    c => new
            //        {
            //            RideRequestID = c.Int(nullable: false, identity: true),
            //            CreditCard = c.Int(name: "CreditCard#"),
            //            Destination = c.String(nullable: false, maxLength: 255),
            //            Rider_Desired_Time = c.Time(precision: 7),
            //            Driver_ETA = c.Time(precision: 7),
            //        })
            //    .PrimaryKey(t => t.RideRequestID);
            
            //CreateTable(
            //    "dbo.Rider",
            //    c => new
            //        {
            //            RiderID = c.Int(nullable: false, identity: true),
            //            RideRequest = c.Int(),
            //        })
            //    .PrimaryKey(t => t.RiderID)
            //    .ForeignKey("dbo.RideRequests", t => t.RideRequest, cascadeDelete: true)
            //    .Index(t => t.RideRequest);
            
            //CreateTable(
            //    "dbo.User",
            //    c => new
            //        {
            //            UserID = c.Int(nullable: false),
            //            Location = c.String(nullable: false, maxLength: 255),
            //            Admin = c.Int(nullable: false, identity: true),
            //            RiderID = c.Int(),
            //            DriverID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.UserID)
            //    .ForeignKey("dbo.Driver", t => t.DriverID)
            //    .ForeignKey("dbo.Rider", t => t.RiderID, cascadeDelete: true)
            //    .Index(t => t.RiderID)
            //    .Index(t => t.DriverID);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Rider", "RideRequest", "dbo.RideRequests");
            //DropForeignKey("dbo.User", "RiderID", "dbo.Rider");
            //DropForeignKey("dbo.User", "DriverID", "dbo.Driver");
            //DropForeignKey("dbo.Driver", "RideRequests", "dbo.RideRequests");
            //DropIndex("dbo.User", new[] { "DriverID" });
            //DropIndex("dbo.User", new[] { "RiderID" });
            //DropIndex("dbo.Rider", new[] { "RideRequest" });
            //DropIndex("dbo.Driver", new[] { "RideRequests" });
            //DropTable("dbo.User");
            //DropTable("dbo.Rider");
            //DropTable("dbo.RideRequests");
            //DropTable("dbo.Driver");
        }
    }
}
