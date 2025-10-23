namespace TvService.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        City_CityID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Cities", t => t.City_CityID)
                .Index(t => t.City_CityID);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        DeviceID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        SerialNumber = c.String(),
                        ProblemDescription = c.String(),
                        Status = c.String(),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeviceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.ServiceRecords",
                c => new
                    {
                        ServiceRecordID = c.Int(nullable: false, identity: true),
                        ReceivedDate = c.DateTime(nullable: false),
                        CompletedDate = c.DateTime(),
                        OperationsDone = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeviceID = c.Int(nullable: false),
                        TechnicianID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceRecordID)
                .ForeignKey("dbo.Devices", t => t.DeviceID, cascadeDelete: true)
                .ForeignKey("dbo.Technicians", t => t.TechnicianID, cascadeDelete: true)
                .Index(t => t.DeviceID)
                .Index(t => t.TechnicianID);
            
            CreateTable(
                "dbo.Technicians",
                c => new
                    {
                        TechnicianID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        City = c.String(),
                        Specialty = c.String(),
                        City_CityID = c.Int(),
                    })
                .PrimaryKey(t => t.TechnicianID)
                .ForeignKey("dbo.Cities", t => t.City_CityID)
                .Index(t => t.City_CityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technicians", "City_CityID", "dbo.Cities");
            DropForeignKey("dbo.Customers", "City_CityID", "dbo.Cities");
            DropForeignKey("dbo.ServiceRecords", "TechnicianID", "dbo.Technicians");
            DropForeignKey("dbo.ServiceRecords", "DeviceID", "dbo.Devices");
            DropForeignKey("dbo.Devices", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Technicians", new[] { "City_CityID" });
            DropIndex("dbo.ServiceRecords", new[] { "TechnicianID" });
            DropIndex("dbo.ServiceRecords", new[] { "DeviceID" });
            DropIndex("dbo.Devices", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "City_CityID" });
            DropTable("dbo.Technicians");
            DropTable("dbo.ServiceRecords");
            DropTable("dbo.Devices");
            DropTable("dbo.Customers");
            DropTable("dbo.Cities");
        }
    }
}
