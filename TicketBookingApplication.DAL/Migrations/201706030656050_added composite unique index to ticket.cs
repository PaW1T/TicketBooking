namespace TicketBookingApplication.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcompositeuniqueindextoticket : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            CreateIndex("dbo.Tickets", new[] { "FlightId", "SeatNumber" }, unique: true, name: "Ticket_FlightSeat");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tickets", "Ticket_FlightSeat");
            CreateIndex("dbo.Tickets", "FlightId");
        }
    }
}
