namespace TicketBookingApplication.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ticketcomfortIdfieldadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Comfort_Id", "dbo.Comforts");
            DropIndex("dbo.Tickets", new[] { "Comfort_Id" });
            RenameColumn(table: "dbo.Tickets", name: "Comfort_Id", newName: "ComfortId");
            AlterColumn("dbo.Tickets", "ComfortId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "ComfortId");
            AddForeignKey("dbo.Tickets", "ComfortId", "dbo.Comforts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "ComfortId", "dbo.Comforts");
            DropIndex("dbo.Tickets", new[] { "ComfortId" });
            AlterColumn("dbo.Tickets", "ComfortId", c => c.Int());
            RenameColumn(table: "dbo.Tickets", name: "ComfortId", newName: "Comfort_Id");
            CreateIndex("dbo.Tickets", "Comfort_Id");
            AddForeignKey("dbo.Tickets", "Comfort_Id", "dbo.Comforts", "Id");
        }
    }
}
