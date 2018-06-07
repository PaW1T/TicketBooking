namespace TicketBookingApplication.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedflight : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Flight_Id", "dbo.Flights");
            DropIndex("dbo.Orders", new[] { "Flight_Id" });
            DropColumn("dbo.Orders", "Flight_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Flight_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Flight_Id");
            AddForeignKey("dbo.Orders", "Flight_Id", "dbo.Flights", "Id");
        }
    }
}
