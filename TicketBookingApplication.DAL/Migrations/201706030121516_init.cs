namespace TicketBookingApplication.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airplanes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirplaneId = c.Int(nullable: false),
                        ArrivalCityId = c.Int(nullable: false),
                        DepartureCityId = c.Int(nullable: false),
                        ArivalTime = c.DateTime(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airplanes", t => t.AirplaneId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.ArrivalCityId, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.DepartureCityId, cascadeDelete: false)
                .Index(t => t.AirplaneId)
                .Index(t => t.ArrivalCityId)
                .Index(t => t.DepartureCityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PostIndex = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        Flight_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.ProfileId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.Flight_Id)
                .Index(t => t.ProfileId)
                .Index(t => t.Flight_Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comforts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderedTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.TicketId, unique: true)
                .Index(t => t.OrderId, unique: true);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SeatNumber = c.Int(nullable: false),
                        Comfort_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comforts", t => t.Comfort_Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId)
                .Index(t => t.Comfort_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderedTickets", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Tickets", "Comfort_Id", "dbo.Comforts");
            DropForeignKey("dbo.OrderedTickets", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Flight_Id", "dbo.Flights");
            DropForeignKey("dbo.Orders", "ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Flights", "DepartureCityId", "dbo.Cities");
            DropForeignKey("dbo.Flights", "ArrivalCityId", "dbo.Cities");
            DropForeignKey("dbo.Flights", "AirplaneId", "dbo.Airplanes");
            DropIndex("dbo.Tickets", new[] { "Comfort_Id" });
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.OrderedTickets", new[] { "OrderId" });
            DropIndex("dbo.OrderedTickets", new[] { "TicketId" });
            DropIndex("dbo.Orders", new[] { "Flight_Id" });
            DropIndex("dbo.Orders", new[] { "ProfileId" });
            DropIndex("dbo.Flights", new[] { "DepartureCityId" });
            DropIndex("dbo.Flights", new[] { "ArrivalCityId" });
            DropIndex("dbo.Flights", new[] { "AirplaneId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.OrderedTickets");
            DropTable("dbo.Comforts");
            DropTable("dbo.Profiles");
            DropTable("dbo.Orders");
            DropTable("dbo.Cities");
            DropTable("dbo.Flights");
            DropTable("dbo.Airplanes");
        }
    }
}
